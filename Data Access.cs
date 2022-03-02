using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Password_Keeper
{
    public static class Data_Access
    {
        private static string app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string app_folder = "pkeep";
        private static string pass_store = Path.Combine(app_data, app_folder);
        private static string pass_file = "wot.txt";

        public static DirectoryInfo passfolder = new DirectoryInfo(pass_store);
        public static FileInfo passfile = new FileInfo(Path.Combine(pass_store, pass_file));
        public static FileStream fs;
        public static bool check_pass_exist()
        {
            FileInfo passfile = new FileInfo(Path.Combine(pass_store, pass_file));
            if (!passfile.Exists)
            {
                create_pass();
                return true;
            }
            return false;
        }
        public static void create_pass()
        {
            if (!passfolder.Exists)
                passfolder.Create();
            DirectoryInfo directory = new DirectoryInfo(Path.Combine(app_data, "pkeep", "store"));
            directory.Create();
        }
        public static void mk_pass(string username, string password)
        {
            string user = Crypto_Engine.Encrypt(username, "cxfw-9kx3-whcv20");
            string pass = Crypto_Engine.Encrypt(password, "whcv-2kx0-cxto20");
            fs = passfile.Create();
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(user + "\n" + pass);
                sw.Close();
            }

        }
        public static bool read_pass(string user, string pass)
        {
            string[] divider = { "\n" };
            fs = passfile.Open(FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string user_auth = sr.ReadLine();
            string pass_auth = sr.ReadLine();
            sr.Close();

            user_auth = Crypto_Engine.Decrypt(user_auth, "cxfw-9kx3-whcv20");
            pass_auth = Crypto_Engine.Decrypt(pass_auth, "whcv-2kx0-cxto20");

            if (user == user_auth && pass == pass_auth)
                return true;
            else
                return false;
        }

        public static string[] read_user_pass()
        {
            string[] divider = { "\n" };
            fs = passfile.Open(FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string user_auth = sr.ReadLine();
            string pass_auth = sr.ReadLine();
            sr.Close();
            user_auth = Crypto_Engine.Decrypt(user_auth, "cxfw-9kx3-whcv20");
            pass_auth = Crypto_Engine.Decrypt(pass_auth, "whcv-2kx0-cxto20");
            string[] combine = new string[2];
            combine[0] = user_auth;
            combine[1] = pass_auth;

            return combine;
        }
    }
}
