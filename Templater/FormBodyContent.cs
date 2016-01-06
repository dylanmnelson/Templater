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
    public partial class FormBodyContent : Form
    {
        public FormBodyContent()
        {
            InitializeComponent();
            this.AcceptButton = buttonAcceptChanges;
            this.buttonAcceptChanges.DialogResult = DialogResult.OK;
            this.CancelButton = buttonDiscardChanges;
            this.buttonDiscardChanges.DialogResult = DialogResult.Cancel;
        }

        public string Body
        {
            get { return richTextBoxBody.Text; }
            set { richTextBoxBody.Text = value; }
        }
    }
}
