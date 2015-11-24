﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templater
{
    public static class HTMLHelper
    {
        #region Constants
        public const string HTML5_DEFAULT = "<!DOCTYPE html>\n<html>\n\t<head>\n\t\t<meta charset=\"UTF-8\">\n\t\t<title><!-- Insert title here --></title>\n\t</head>\n\t<body>\n\n\t</body>\n</html>";
        public const string HTML4_DTD_STRICT = "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"http://www.w3.org/TR/html4/strict.dtd\">";
        public const string HTML4_DTD_TRANSITIONAL = "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Transitional//EN\" \"http://www.w3.org/TR/html4/loose.dtd\">";
        public const string HTML4_DTD_FRAMESET = "<!DOCTYPE HTML PUBLIC \" -//W3C//DTD HTML 4.01 Frameset//EN\" \"http://www.w3.org/TR/html4/frameset.dtd\">";
        public const string XHTML_DTD_STRICT = "<!DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Strict//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd\">";
        public const string XHTML_DTD_TRANSITIONAL = "<!DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">";
        public const string XHTML_DTD_FRAMESET = "<!DOCTYPE html PUBLIC \" -//W3C//DTD XHTML 1.0 Frameset//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-frameset.dtd\">";
        #endregion
    }
}
