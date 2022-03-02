using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Password_Keeper
{
    public class Account
    {
        public string _name;
        public string _username;
        public string _password;
        public Account(string name, string username, string password)
        {
            _name = name;
            _username = username;
            _password = password;
            Pass_Access.create_account(_name, _username, _password);
        }


    }
}
