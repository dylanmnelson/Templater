using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Templater
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the GitHub repository for this program in the default web browser.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGoToSourceCode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dylanmnelson/Templater");
        }
    }
}
