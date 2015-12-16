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
        private List<string> js;
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

        public List<string> JS
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
            JS = new List<string>();
        }

        /// <summary>
        /// Gets the template title and used scripts, and formats them into the HTML template.
        /// </summary>
        /// <returns>The HTML code of the template.</returns>
        public override string ToString()
        {

            // If this is a new template just created, update the title.
            if(this.Code == "")
            {
                this.Code = this.Original;
                this.Code += HTMLHelper.HTML_BASE_SCRIPTS + HTMLHelper.HTML_BASE_END;
            }
            else
            {

                // Add scripts if there any.
                if(this.JS.Count == 0)
                {
                    this.Code = this.Original + HTMLHelper.HTML_BASE_SCRIPTS + HTMLHelper.HTML_BASE_END;
                }
                else
                {
                    string[] scripts = this.JS.ToArray();
                    string updatedScripts = HTMLHelper.HTML_BASE_SCRIPTS;
                    string scriptCode = "";

                    foreach (string script in scripts) {
                        scriptCode += "\n\t\t" + script;
                    }

                    // TODO add more than one script.
                    updatedScripts = updatedScripts.Replace("\n\t\t<!-- Insert scripts here -->", scriptCode);
                    this.Code = this.Original + updatedScripts + HTMLHelper.HTML_BASE_END;
                }
            }

            // Replace title placeholder.
            string newCode = this.Code;
            newCode = newCode.Replace("<!-- Insert title here -->", this.Title);
            this.Code = newCode;

            return this.Code;
        }
    }
}
