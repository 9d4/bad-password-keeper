using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Password_Keeper
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public event EventHandler exit;
        public event EventHandler submit;
        public event EventHandler refresh;
        public event EventHandler delete;
        public event EventHandler view;
        public event EventHandler close_app;

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            close_app(sender, e);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            Logind logind = new Logind();
            logind.ShowDialog();
            listing();
            flexbox_list();
        }
        private void Exit()
        {
            Application.Exit();
        }

        //toolbar
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }
        // //toolbar
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (box_name.Text != "" || !string.IsNullOrWhiteSpace(box_name.Text))
            {
                Account ac = new Account(box_name.Text, box_username.Text, box_password.Text);
                listing();
                flexbox_list();
                clearbox();
            }
            
        }
        //clearbox
        private void clearbox()
        {
            box_name.Text = null;
            box_username.Text = null;
            box_password.Text = null;
        }

        //listing
        private void listing()
        {
            //List<string> list = Pass_Access.list_account();
            //list_account.DataSource = list;
        }
        private void flexbox_list()
        {
            if (flexbox.Controls.Count > 0)
                flexbox.Controls.Clear();
            string[] datas = Pass_Access.list_account_array();
            foreach(var i in datas)
            {
                Button a = mk_btn(i);
                flexbox.Controls.Add(a);
                a.Click += new EventHandler(btn_handle);
            }
        }

        //submit on enter
        private void box_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                submit += btn_save_Click;
                submit(sender, e);
            }
        }
        private void box_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                submit += btn_save_Click;
                submit(sender, e);
            }
        }
        private void box_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                submit += btn_save_Click;
                submit(sender, e);
            }
        }

        //refresh
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listing();
            flexbox_list();
        }

        private void list_account_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            get_item();
        }
        //get item
        private void get_item()
        {
            //string[] datas = new string[3];

            //if (list_account.SelectedIndex >= 0)
            //{
            //    string file = list_account.SelectedItem.ToString();
            //    file = file += ".txt";
            //    datas = Pass_Access.get_pass(file);
                
            //    message_show(datas[0], datas[1], datas[2]);
            //}
        }
        //delete item
        private void rm_item()
        {
            //if (list_account.SelectedIndex >= 0)
            //{
            //    string file = list_account.SelectedItem.ToString();
            //    file = file + ".txt";
            //    Pass_Access.delete(file);
            //}
        }
        //edit item
        private void edit_item()
        {
            //string[] datas = new string[3];

            //if (list_account.SelectedIndex >= 0)
            //{
            //    string file = list_account.SelectedItem.ToString();
            //    file = file += ".txt";
            //    datas = Pass_Access.get_pass(file);
            //}

            //box_name.Text = datas[0];
            //box_username.Text = datas[1];
            //box_password.Text = datas[2];
        }

        //show pop up output
        private void message_show(string name, string user, string pass)
        {
            var btn = MessageBoxButtons.OK;
            var icon = MessageBoxIcon.Information;
            var msg = "Username : " + user + "\n";
            msg += "Password : " + pass;
            MessageBox.Show(msg, name.ToUpper(), btn, icon);

        }

        //button delete
        private void btn_delete_Click(object sender, EventArgs e)
        {
            rm_item();
            refresh += refreshToolStripMenuItem_Click;
            refresh(sender, e);
        }
        //list handle
        private void list_account_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                get_item(); e.SuppressKeyPress = true;
            }
            if(e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }
            
        }

        //btn_EDIT
        private void btn_edit_Click(object sender, EventArgs e)
        {
            edit_item();
        }

        //btn setting name
        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
        }

        ////create button
        Button mk_btn(string name)
        {
            Button b = new Button();
            b.Name = "btn_" + name.Replace(" ","_");
            b.Text = name;
            b.ForeColor = Color.Black;
            b.FlatStyle = FlatStyle.Flat;
            b.AutoSize = true;
            b.BackColor = Color.FromArgb(235, 234, 190);
            return b;
        }
        //////hanlde buttons
        private void btn_handle(object sender, EventArgs e)
        {
            Button current = sender as Button;
            Right_Dialog dialog = new Right_Dialog();
            dialog.show(current.Name);
            //refresh on closing
            dialog.close += refreshToolStripMenuItem_Click;
        }


    }
}
