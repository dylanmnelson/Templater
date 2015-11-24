using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templater
{
    class Template
    {
        private string original;
        private string title;
        private string code;
        private string js;
        private string css;

        public string Original
        {
            get { return original; }
            set { original = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
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
            Code = "";
        }

        /// <summary>
        /// Gets the template title and used scripts, and formats them into the HTML template.
        /// </summary>
        /// <returns>The HTML code of the template.</returns>
        public override string ToString()
        {
            if(this.Code == "")
            {
                this.Code = this.Original;

                // Replace title placeholder.
                string newCode = this.Code;
                newCode = newCode.Replace("<!-- Insert title here -->", this.Title);
                this.Code = newCode;
            }

            return this.Code;
        }
    }
}
