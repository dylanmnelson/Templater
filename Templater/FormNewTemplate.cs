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
    public partial class FormNewTemplate : Form
    {
        public FormNewTemplate()
        {
            InitializeComponent();
            this.AcceptButton = buttonCreateTemplate;
            this.buttonCreateTemplate.DialogResult = DialogResult.OK;
        }

        public bool IsHTML5Selected
        {
            get { return radioButtonHTML5.Checked; }
        }

        public bool IsHTML4Selected
        {
            get { return radioButtonHTML4.Checked; }
        }

        public bool IsXHTMLSelected
        {
            get { return radioButtonXHTML.Checked; }
        }

        public string Title
        {
            get { return textBoxTitle.Text; }
        }
    }
}
