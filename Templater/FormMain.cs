using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Templater
{
    public partial class FormMain : Form
    {

        private FormNewTemplate newTemplateForm;
        private FormInsertDependencies insertDependenciesForm;
        private FormCustomFiles customFilesForm;
        private FormBodyContent bodyContentForm;

        Template page = new Template();

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Creates a new HTML template and displays in the output text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newTemplateForm = new FormNewTemplate();
            if(newTemplateForm.ShowDialog() == DialogResult.OK)
            {

                // Reset the template.
                page = new Template();

                richTextBoxOutput.ReadOnly = false;

                // Set the standard / DTD of the document.
                if(newTemplateForm.IsHTML5Selected)
                {
                    page.Original = HTMLHelper.HTML5_DEFAULT;
                }
                else if(newTemplateForm.IsHTML4Selected)
                {
                    page.Original = HTMLHelper.HTML4_DTD_STRICT;
                }
                else
                {
                    page.Original = HTMLHelper.XHTML_DTD_STRICT;
                }

                // Include the base tags.
                page.Original += HTMLHelper.HTML_BASE_START;

                // Get the page title from the new template form.
                page.Title = newTemplateForm.Title;

                // Get the custom JS and CSS files from the form.
                page.CustomCSS = newTemplateForm.CustomCSSFilename;
                page.CustomJS = newTemplateForm.CustomJSFilename;

                displayTemplate(page.ToString());

                // Updating the UI.
                buttonInsertDependencies.Enabled = true;
                buttonEditCustomFiles.Enabled = true;
                buttonEditBodyContent.Enabled = true;
                // saveTemplateSettingsToolStripMenuItem.Enabled = true;
                exportHTMLTemplateToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// Saves the template settings as a text file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTemplateSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // TODO Save the template settings (button is disabled temporarily).
        }

        /// <summary>
        /// Opens a template settings .txt file from the file system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadTemplateSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO Get a text file with template settings (button is disabled temporarily).

            //// Get a file from the open file dialog.
            //try
            //{
            //    DialogResult result = openFileDialogTemplate.ShowDialog();
            //    if(result == DialogResult.OK)
            //    {

            //        // Check if the file is a HTML file.
            //        if(Path.GetExtension(openFileDialogTemplate.FileName)!= ".html")
            //        {
            //            MessageBox.Show("Template files can only be of type '.html'", "Error: Wrong file type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        else
            //        {
            //            string output = File.ReadAllText(openFileDialogTemplate.FileName);
            //            displayTemplate(output);
            //        }
            //    }
            //}
            //catch (FileLoadException ex)
            //{
            //    MessageBox.Show("The template file could not be loaded correctly.", "Error: File not loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    throw ex;
            //}
            //catch (FileNotFoundException ex)
            //{
            //    MessageBox.Show("The template file could not be found.", "Error: File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    throw ex;
            //}
        }

        /// <summary>
        /// Displays a HTML template in the output text box from a file.
        /// </summary>
        /// <param name="output">The file name of the template to load.</param>
        private void displayTemplate(string output)
        {
            richTextBoxOutput.Text = output;
        }

        /// <summary>
        /// Shows the Insert Dependencies window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInsertDependencies_Click(object sender, EventArgs e)
        {
            insertDependenciesForm = new FormInsertDependencies();

            // Check for dependencies in the template (to check the correct radio buttons).
            if(page.JS.Count > 0)
            {

                // Detect jQuery version in the template.
                for(int dep = 0; dep < page.JS.Count; dep++)
                {
                    if(page.JS[dep].Contains("jquery"))
                    {
                        if(page.JS[dep].Contains("1.11.3"))
                        {
                            insertDependenciesForm.IsJQuery1xSelected = true;
                        }
                        else if(page.JS[dep].Contains("2.1.4"))
                        {
                            insertDependenciesForm.IsJQuery2xSelected = true;
                        }

                        // jQuery version has been found, so stop looking.
                        break;
                    }
                    else
                    {
                        insertDependenciesForm.IsNoJQuerySelected = true;
                    }
                }

                // Detect Bootstrap dependency in the template.
                for(int dep = 0; dep < page.JS.Count; dep++)
                {
                    if(page.JS[dep].Contains("bootstrap"))
                    {

                        // Bootstrap JS is found, so look for the CSS.
                        for(int d = 0; d < page.CSS.Count; d++)
                        {
                            if(page.CSS[d].Contains("bootstrap"))
                            {
                                insertDependenciesForm.IsBootstrap3Selected = true;

                                // Bootstrap CSS and JS have been found.
                                break;
                            }
                            else
                            {
                                insertDependenciesForm.IsNoBootstrapSelected = true;
                            }
                        }
                        
                        break;
                    }
                    else
                    {
                        insertDependenciesForm.IsNoBootstrapSelected = true;
                    }
                }
            }
            else
            {

                // Since there is no JS in the template, the default options should be 'No jQuery' etc.
                insertDependenciesForm.IsNoJQuerySelected = true;
                insertDependenciesForm.IsNoBootstrapSelected = true;
            }

            // Show the form now, and update dependencies once the form has been submitted.
            if(insertDependenciesForm.ShowDialog() == DialogResult.OK)
            {

                // Get jQuery dependency from the form.
                if(!insertDependenciesForm.IsNoJQuerySelected)
                {

                    // Check for jQuery script already included, allow it to be edited / removed.
                    bool replace = false;
                    int index = -1;
                    for (int dep = 0; dep < page.JS.Count; dep++)
                    {
                        if (page.JS[dep].Contains("jquery"))
                        {
                            replace = true;
                            index = dep;
                            break;
                        }
                    }

                    // Check the jQuery version selected.
                    if (insertDependenciesForm.IsJQuery1xSelected)
                    {
                        if(replace)
                        {
                            page.JS[index] = HTMLHelper.DEPENDENCY_JQUERY_1X;
                        }
                        else
                        {
                            page.JS.Add(HTMLHelper.DEPENDENCY_JQUERY_1X);
                        }
                    }
                    else
                    {
                        if(replace)
                        {
                            page.JS[index] = HTMLHelper.DEPENDENCY_JQUERY_2X;
                        }
                        else
                        {
                            page.JS.Add(HTMLHelper.DEPENDENCY_JQUERY_2X);
                        }
                    }
                }
                else
                {

                    // Remove jQuery dependency.
                    for (int dep = 0; dep < page.JS.Count; dep++)
                    {
                        if (page.JS[dep].Contains("jquery"))
                        {
                            page.JS.RemoveAt(dep);
                            break;
                        }
                    }
                }

                // Get Bootstrap dependency from the form.
                if(insertDependenciesForm.IsBootstrap3Selected)
                {

                    // Check if Bootstrap is already present, don't add it again if it is.
                    bool bootstrapPresent = false;
                    int index = -1;
                    for (int dep = 0; dep < page.JS.Count; dep++)
                    {
                        if (page.JS[dep].Contains("bootstrap"))
                        {
                            bootstrapPresent = true;
                            index = dep;
                            break;
                        }
                    }

                    if(!bootstrapPresent)
                    {
                        page.JS.Add(HTMLHelper.DEPENDENCY_BOOTSTRAP_3_JS);
                        page.CSS.Add(HTMLHelper.DEPENDENCY_BOOTSTRAP_3_CSS);
                    }
                }
                else
                {

                    // Remove Bootstrap JS.
                    for (int dep = 0; dep < page.JS.Count; dep++)
                    {
                        if (page.JS[dep].Contains("bootstrap"))
                        {
                            page.JS.RemoveAt(dep);
                            break;
                        }
                    }

                    // Remove Bootstrap CSS.
                    for (int dep = 0; dep < page.CSS.Count; dep++)
                    {
                        if (page.CSS[dep].Contains("bootstrap"))
                        {
                            page.CSS.RemoveAt(dep);
                            break;
                        }
                    }
                }

                // Display the updated template.
                displayTemplate(page.ToString());
            }
        }

        /// <summary>
        /// Shows the Custom Files window, will pull the CSS and JS file name and allow them to be editable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditCustomFiles_Click(object sender, EventArgs e)
        {
            customFilesForm = new FormCustomFiles();

            // Pull the file names from the template to allow editing.
            customFilesForm.CustomJSFilename = page.CustomJS;
            customFilesForm.CustomCSSFilename = page.CustomCSS;

            // Show the form.
            if(customFilesForm.ShowDialog() == DialogResult.OK)
            {

                // Set the new file names once the form has been submitted.
                page.CustomJS = customFilesForm.CustomJSFilename;
                page.CustomCSS = customFilesForm.CustomCSSFilename;

                // Display the updated template.
                displayTemplate(page.ToString());
            }
        }

        /// <summary>
        /// Shows the Body Content window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditBodyContent_Click(object sender, EventArgs e)
        {
            bodyContentForm = new FormBodyContent();

            // Pull the body from the template to allow editing.
            bodyContentForm.Lines = page.Body;

            // Show the form.
            if(bodyContentForm.ShowDialog() == DialogResult.OK)
            {
                page.Body = bodyContentForm.Lines;

                // Display the updated template.
                displayTemplate(page.ToString());
            }
        }

        /// <summary>
        /// Exports the text in the output text box to a HTML file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportHTMLTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialogTemplate.ShowDialog() == DialogResult.OK && saveFileDialogTemplate.FileName.Length > 0)
                {
                    richTextBoxOutput.SaveFile(saveFileDialogTemplate.FileName, RichTextBoxStreamType.PlainText);
                    statusLabelFileSaved.Text = "File '" + saveFileDialogTemplate.FileName + "' saved successfully";
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Could not save the template file.");
                throw ex;
            }
        }
    }
}
