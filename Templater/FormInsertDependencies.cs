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
