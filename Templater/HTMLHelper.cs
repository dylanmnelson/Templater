using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templater
{
    public static class HTMLHelper
    {
        #region Constants

        // HTML Templates.
        public const string HTML5_DEFAULT = "<!DOCTYPE html>";
        public const string HTML4_DTD_STRICT = "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\">";
        public const string HTML4_DTD_TRANSITIONAL = "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">";
        public const string HTML4_DTD_FRAMESET = "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Frameset//EN\" \"http://www.w3.org/TR/html4/frameset.dtd\">";
        public const string XHTML_DTD_STRICT = "<!DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\">";
        public const string XHTML_DTD_TRANSITIONAL = "<!DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
        public const string XHTML_DTD_FRAMESET = "<!DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Frameset//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd\">";
        public const string HTML_BASE_START = "\n<html>\n\t<head>\n\t\t<meta charset=\"UTF-8\">\n\t\t<title><!-- Insert title here --></title>\n\t\t<!-- Insert CSS here -->\n\t</head>\n\t<body>\n\t\t<!-- Start body content -->\n\t\t<!-- End body content -->";
        public const string HTML_BASE_SCRIPTS = "\n\t\t<!-- Insert scripts here -->";
        public const string HTML_BASE_END = "\n\t</body>\n</html>";

        // Dependencies.
        public const string DEPENDENCY_JQUERY_1X = "<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js\"></script>";
        public const string DEPENDENCY_JQUERY_2X = "<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.1.4/jquery.min.js\"></script>";

        public const string DEPENDENCY_ANGULAR_1_4 = "<script src=\"https://ajax.googleapis.com/ajax/libs/angularjs/1.4.2/angular.min.js\"></script>";

        public const string DEPENDENCY_BOOTSTRAP_3_CSS = "<link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css\" rel=\"stylesheet\">";
        public const string DEPENDENCY_BOOTSTRAP_3_JS = "<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js\"></script>";
        #endregion
    }
}
