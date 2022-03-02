using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Password_Keeper
{
    public static class Pass_Access
    {

        //var
        static string app_data = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        static DirectoryInfo directory = new DirectoryInfo(Path.Combine(app_data, "pkeep", "store"));

        public static void create_account(string name, string username, string password)
        {
            string _name = name + ".txt";

            if (!directory.Exists)
                directory.Create();

            FileInfo file = new FileInfo(Path.Combine(app_data, "pkeep", "store", _name.ToUpper()));
            FileStream fs = file.Create();
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(Crypto_Engine.Encrypt(name, User_Preferences.cryptokeyuser));
            sw.WriteLine(Crypto_Engine.Encrypt(username, User_Preferences.cryptokeyuser));
            sw.WriteLine(Crypto_Engine.Encrypt(password, User_Preferences.cryptokeypass));
            sw.Close();
        }

        public static List<string> list_account()
        {
            string[] datas = Directory.GetFiles(directory.ToString());
            List<string> listing = new List<string>();
            foreach (var i in datas)
                listing.Add(Path.GetFileNameWithoutExtension(i));
            return listing;
        }

        public static string[] list_account_array()
        {
            string[] datas = Directory.GetFiles(directory.ToString());
            for (int i = 0; i < datas.Length; i++)
            {
                datas[i] = Path.GetFileNameWithoutExtension(datas[i]);
            }
            return datas;
        }

        public static string[] get_pass(string path)
        {
            FileInfo file = new FileInfo(Path.Combine(directory.ToString(), path));
            FileStream fs = new FileStream(file.ToString(), FileMode.Open);

            string[] data_get = new string[3];
            StreamReader sr = new StreamReader(fs);
            data_get[0] = sr.ReadLine();
            data_get[1] = sr.ReadLine();
            data_get[2] = sr.ReadLine();

            sr.Close();
            data_get[0] = Crypto_Engine.Decrypt(data_get[0], User_Preferences.cryptokeyuser);
            data_get[1] = Crypto_Engine.Decrypt(data_get[1], User_Preferences.cryptokeyuser);
            data_get[2] = Crypto_Engine.Decrypt(data_get[2], User_Preferences.cryptokeypass);
            return data_get;
        }

        public static void delete(string path)
        {
            FileInfo file = new FileInfo(Path.Combine(directory.ToString(), path));
            file.Delete();
        }

        public static void edit(string path)
        {

        }
    }
}
