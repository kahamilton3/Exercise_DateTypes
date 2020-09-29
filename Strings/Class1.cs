using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class Class1
    {
        public static bool TermSearch(string sentence, string term)
        {
            return sentence.ToLower().IndexOf(term.ToLower()) > -1;
        }
    }
}
