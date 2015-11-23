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
                richTextBoxOutput.ReadOnly = false;

                // Set the base template.
                if(newTemplateForm.IsHTML5Selected)
                {
                    richTextBoxOutput.Text = HTMLHelper.HTML5_DEFAULT;
                }
                else if(newTemplateForm.IsHTML4Selected)
                {
                    richTextBoxOutput.Text = HTMLHelper.HTML4_DTD_STRICT;
                }
                else
                {
                    richTextBoxOutput.Text = HTMLHelper.XHTML_DTD_STRICT;
                }

                // Get the page title.
                page.Title = newTemplateForm.Title;
                Debug.WriteLine(page.Title);
            }
        }

        /// <summary>
        /// Saves the text in the output text box to a HTML file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(saveFileDialogTemplate.ShowDialog() == DialogResult.OK && saveFileDialogTemplate.FileName.Length > 0)
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

        /// <summary>
        /// Opens a HTML template from the file system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Get a file from the open file dialog.
            try
            {
                DialogResult result = openFileDialogTemplate.ShowDialog();
                if(result == DialogResult.OK)
                {

                    // Check if the file is a HTML file.
                    if(Path.GetExtension(openFileDialogTemplate.FileName)!= ".html")
                    {
                        MessageBox.Show("Template files can only be of type '.html'", "Error: Wrong file type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        displayTemplate(openFileDialogTemplate.FileName);
                    }
                }
            }
            catch (FileLoadException ex)
            {
                MessageBox.Show("The template file could not be loaded correctly.", "Error: File not loaded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("The template file could not be found.", "Error: File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        /// <summary>
        /// Displays a HTML template in the output text box from a file.
        /// </summary>
        /// <param name="fileName">The file name of the template to load.</param>
        private void displayTemplate(string fileName)
        {
            richTextBoxOutput.LoadFile(fileName, RichTextBoxStreamType.PlainText);
        }
    }
}
