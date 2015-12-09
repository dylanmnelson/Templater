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
    public partial class FormInsertDependencies : Form
    {
        private static FormInsertDependencies theForm = null;

        public FormInsertDependencies()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Resets the form trigger on close to allow for another form to be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInsertDependencies_FormClosed(object sender, FormClosedEventArgs e)
        {
            theForm = null;
        }

        /// <summary>
        /// This method is used to prevent more than one instance of the form from being displayed, if there is already an instance it will be brought to the front.
        /// </summary>
        public void ShowForm()
        {
            if(theForm != null)
            {
                theForm.BringToFront();
            }
            else
            {
                theForm = new FormInsertDependencies();
                theForm.Show();
            }
        }

        public bool IsNoJQuerySelected
        {
            get { return radioButtonNoJQuery.Checked; }
        }

        public bool IsJQuery1xSelected
        {
            get { return radioButtonAddJQuery1x.Checked; }
        }

        public bool IsJQuery2xSelected
        {
            get { return radioButtonAddJQuery2x.Checked; }
        }
    }
}
