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
        private List<string> css;
        private string customCss;
        private string customJs;
        private string body;

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

        public List<string> CSS
        {
            get { return css; }
            set { css = value; }
        }

        public string CustomCSS
        {
            get { return customCss; }
            set { customCss = value; }
        }

        public string CustomJS
        {
            get { return customJs; }
            set { customJs = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public Template()
        {
            Code = "";
            JS = new List<string>();
            CSS = new List<string>();
            CustomCSS = "";
            CustomJS = "";
            Body = "";
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

            // Add scripts if there any.
            if(this.JS.Count == 0 && this.CustomJS == "")
            {
                this.Code = this.Original + HTMLHelper.HTML_BASE_SCRIPTS + HTMLHelper.HTML_BASE_END;
            }
            else
            {
                string[] scripts = this.JS.ToArray();
                string updatedScripts = HTMLHelper.HTML_BASE_SCRIPTS;
                string scriptCode = "";

                // Add each script.
                foreach (string script in scripts) {
                    scriptCode += "\n\t\t" + script;
                }

                // Add the custom JS file if there is one.
                if(this.CustomJS != "")
                {
                    scriptCode += "\n\t\t<script src=\"" + this.CustomJS + ".js\"></script>";
                }
                    
                // Replace the scripts placeholder with the new script list.
                updatedScripts = updatedScripts.Replace("\n\t\t<!-- Insert scripts here -->", scriptCode);

                this.Code = this.Original + updatedScripts + HTMLHelper.HTML_BASE_END;
            }

            // Add CSS files if there are any.
            if(this.CSS.Count == 0 && this.CustomCSS == "")
            {

                // TODO: remove CSS files, create new base files helper variable.
            }
            else
            {
                string[] files = this.CSS.ToArray();
                string filesCode = "";

                // Add each file.
                foreach (string file in files)
                {
                    filesCode += "\n\t\t" + file;
                }

                // Add the custom CSS file if there is one.
                if (this.CustomCSS != "")
                {
                    filesCode += "\n\t\t<link href=\"" + this.CustomCSS + ".css\" rel=\"stylesheet\">";
                }

                this.Code = this.Code.Replace("\n\t\t<!-- Insert CSS here -->", filesCode);
            }

            // Replace title placeholder.
            string newCode = this.Code;
            newCode = newCode.Replace("<!-- Insert title here -->", this.Title);
            this.Code = newCode;

            // Replace common body content, if it's not empty.
            if (this.Body != "")
            {
                newCode = newCode.Replace("<!-- Start body content -->", this.Body);
                this.Code = newCode;
            }

            return this.Code;
        }
    }
}
