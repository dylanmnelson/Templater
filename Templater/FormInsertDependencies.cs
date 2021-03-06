﻿using System;
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
        public FormInsertDependencies()
        {
            InitializeComponent();
            this.AcceptButton = buttonAcceptChanges;
            this.buttonAcceptChanges.DialogResult = DialogResult.OK;
            this.CancelButton = buttonDiscardChanges;
            this.buttonDiscardChanges.DialogResult = DialogResult.Cancel;
        }

        public bool IsNoJQuerySelected
        {
            get { return radioButtonNoJQuery.Checked; }
            set { radioButtonNoJQuery.Checked = value; }
        }

        public bool IsJQuery1xSelected
        {
            get { return radioButtonAddJQuery1x.Checked; }
            set { radioButtonAddJQuery1x.Checked = value; }
        }

        public bool IsJQuery2xSelected
        {
            get { return radioButtonAddJQuery2x.Checked; }
            set { radioButtonAddJQuery2x.Checked = value; }
        }

        public bool IsNoBootstrapSelected
        {
            get { return radioButtonNoBootstrap.Checked; }
            set { radioButtonNoBootstrap.Checked = value; }
        }
        public bool IsBootstrap3Selected
        {
            get { return radioButtonAddBootstrap3.Checked; }
            set { radioButtonAddBootstrap3.Checked = value; }
        }

        /// <summary>
        /// The dependencies will be validated (e.g. jQuery not selected when Bootstrap is)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAcceptChanges_Click(object sender, EventArgs e)
        {

            // If a version of Bootstrap is selected and jQuery isn't, display an error message.
            if(IsNoJQuerySelected && !IsNoBootstrapSelected)
            {
                MessageBox.Show("Since Bootstrap depends on jQuery, please add a jQuery version or remove the Bootstrap dependency.", "Dependency Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
