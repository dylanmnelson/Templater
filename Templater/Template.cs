using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templater
{
    class Template
    {
        private string title;
        private string code;
        private string js;
        private string css;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Code
        {
            get { return code; }
        }

        public string JS
        {
            get { return js; }
            set { js = value; }
        }

        public string CSS
        {
            get { return css; }
            set { css = value; }
        }

        public Template()
        {

        }
    }
}
