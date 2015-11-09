using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Templater
{
    public partial class Form1 : Form
    {
        public Form1()
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
            richTextBoxOutput.ReadOnly = false;
            richTextBoxOutput.Text = HTMLHelper.HTML5_DEFAULT;
        }

        /// <summary>
        /// Saves the text in the output text box to a html file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(saveFileDialogTemplate.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialogTemplate.FileName.Length > 0)
                {
                    richTextBoxOutput.SaveFile(saveFileDialogTemplate.FileName, RichTextBoxStreamType.PlainText);
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
            // TODO open file dialog, display in output box.
        }
    }
}
