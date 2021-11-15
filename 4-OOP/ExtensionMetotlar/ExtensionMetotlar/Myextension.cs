using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMetotlar
{
    public static class Myextension
    {
        public static string IlkHarfBuyuk (this string val)
        {
            return val.Substring(0, 1).ToUpper() + val.Substring(1).ToLower();
        }
        public static string HepsiBuyuk(this string val)
        {
            return val.ToUpper();
        }
    }
}
