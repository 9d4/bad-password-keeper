using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Keeper
{
    public static class User_Preferences
    {
        private static readonly string _cryptokeyuser = "fksl-4ds9-ksjb89";
        private static readonly string _cryptokeypass = "kdhs-3gn7-owie31";

        //encryption key
        public static string cryptokeyuser
        {
            get { return _cryptokeyuser; }
        }
        public static string cryptokeypass
        {
            get { return _cryptokeypass; }
        }
    }
}
