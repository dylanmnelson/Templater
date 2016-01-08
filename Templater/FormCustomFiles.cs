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
    public partial class FormCustomFiles : Form
    {
        public FormCustomFiles()
        {
            InitializeComponent();
            this.AcceptButton = buttonAcceptChanges;
            this.buttonAcceptChanges.DialogResult = DialogResult.OK;
            this.CancelButton = buttonDiscardChanges;
            this.buttonDiscardChanges.DialogResult = DialogResult.Cancel;
        }

        public string CustomCSSFilename
        {
            get { return textBoxCSSFilename.Text; }
            set { textBoxCSSFilename.Text = value; }
        }

        public string CustomJSFilename
        {
            get { return textBoxJSFilename.Text; }
            set { textBoxJSFilename.Text = value; }
        }
    }
}
