using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVCBasicBlog.Areas.Admin.Models.Services.TextServices
{
    public class Slugify
    {
        public static string Generate(string word)
        {
            string returnvalue = Regex.Replace(word, @"\s+", " ");
            returnvalue = returnvalue.Replace("ü", "u");
            returnvalue = returnvalue.Replace("ğ", "g");
            returnvalue = returnvalue.Replace("ö", "o");
            returnvalue = returnvalue.Replace("ş", "s");
            returnvalue = returnvalue.Replace("ç", "c");
            returnvalue = returnvalue.Replace("ı", "i");
            returnvalue = returnvalue.Replace(" ", "-");
            returnvalue = returnvalue.Replace("\'", "");
            returnvalue = returnvalue.Replace("İ", "i");
            returnvalue = returnvalue.Replace("I", "i");
            returnvalue = returnvalue.Replace("Ğ", "g");
            returnvalue = returnvalue.Replace("G", "g");
            returnvalue = returnvalue.Replace("Ş", "s");
            returnvalue = returnvalue.Replace("Ç", "c");
            returnvalue = returnvalue.Replace("Ü", "u");
            returnvalue = returnvalue.Replace("Ö", "o");
            returnvalue = returnvalue.Replace("/", "-");
            returnvalue = returnvalue.Replace("?", "");
            returnvalue = returnvalue.Replace("\"", "");
            returnvalue = returnvalue.Replace("*", "");
            returnvalue = returnvalue.Replace("'", "");
            returnvalue = returnvalue.Replace("\"", "");
            returnvalue = returnvalue.Replace("+", "");
            returnvalue = returnvalue.Replace("++", "plus");
            returnvalue = returnvalue.Replace("#", "sharp");
            returnvalue = returnvalue.Replace(",", "");
            returnvalue = returnvalue.Replace(";", "");
            returnvalue = returnvalue.Replace(":", "");
            returnvalue = returnvalue.Replace("!", "");
            returnvalue = returnvalue.Replace("...", "");
            returnvalue = returnvalue.Replace(".", "");
            returnvalue = returnvalue.Replace("\'", "");
            returnvalue = returnvalue.Replace("%", "-yuzde-");
            returnvalue = returnvalue.Replace("&", "");
            returnvalue = returnvalue.Replace("---", "-");
            returnvalue = returnvalue.Replace("--", "-");
            returnvalue = returnvalue[0] == '-' ?
                returnvalue.Substring(1, returnvalue.Length - 1) : returnvalue;
            returnvalue = returnvalue[returnvalue.Length - 1] == '-' ?
                returnvalue.Substring(0, returnvalue.Length - 2) : returnvalue;
            return returnvalue.ToLower();

        }
    }
    }