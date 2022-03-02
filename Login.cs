using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Keeper
{
    public partial class Logind : Form
    {
        public Logind()
        {
            InitializeComponent();
        }
        //var
        private event EventHandler exit;
        private event EventHandler submit;
        private bool firsttime;

        private void Login_Load(object sender, EventArgs e)
        {
            init_placeholder();
            if (Data_Access.check_pass_exist())
            {
                firsttime_hint();
                firsttime = true;
            }
            else
            {
                firsttime = false;
            }
        }

        //utils
        //hint first time
        private void firsttime_hint()
        {
            hint.Text = "First Time !";
        }
        // /utils

        //========
        // BUTTONS
        //btn close
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //btn minimize
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //@form btn cancel
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            exit += btn_close_Click;
            exit(sender, e);
        }
        // /BUTTONS


        // PLACEHOLDERS
        //placeholder init
        private void init_placeholder()
        {
            box_username.Text = "username";
            box_username.ForeColor = Color.Gray;
            box_password.Text = "password";
            box_password.ForeColor = Color.Gray;
        }
        //make placeholder
        private TextBox mk_placeholder(object sender, string objtext)
        {
            TextBox obj = sender as TextBox;
            obj.Text = objtext;
            obj.ForeColor = Color.Gray;
            return obj;
        }
        //remove placeholder
        private TextBox rm_placeholder(object sender)
        {
            TextBox snd = sender as TextBox;
            snd.Text = "";
            snd.ForeColor = Color.White;
            return snd;
        }
        // /PLACEHOLDERS

        // TEXTBOXES FORMS 
        //box entering
        private void box_username_Enter(object sender, EventArgs e)
        {
            if (box_username.Text == "username" || String.IsNullOrEmpty(box_username.Text))
            {
                box_username = rm_placeholder(sender);
            }
        }
        private void box_password_Enter(object sender, EventArgs e)
        {
            if (box_password.Text == "password" || String.IsNullOrEmpty(box_password.Text))
            {
                box_password = rm_placeholder(sender);
            }
        }

        //box leaving
        private void box_username_Leave(object sender, EventArgs e)
        {
            if (box_username.Text == "" || String.IsNullOrWhiteSpace(box_username.Text))
            {
                mk_placeholder(sender, "username");
            }
        }
        private void box_password_Leave(object sender, EventArgs e)
        {
            if (box_password.Text == "" || String.IsNullOrWhiteSpace(box_password.Text))
            {
                mk_placeholder(sender, "password");
            }
        }

        //btn login submit
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (firsttime)
                firsttimelogin();
            else
                generallogin();
        }

        // /FORMS

        //login system
        private void firsttimelogin()
        {
            Data_Access.mk_pass(box_username.Text, box_password.Text);
            firsttime = false;
            open_dashboard();
        }
        private void generallogin()
        {
            string user = box_username.Text;
            string pass = box_password.Text;
            if (Data_Access.read_pass(user, pass))
            {
                hint.Text = "Correct!";
                open_dashboard();
            }
            else
            {
                hint.Text = "Wrong!";
            }

        }

        //closing
        private void open_dashboard()
        {
            Dashboard dashboard = new Dashboard();
            dashboard.close_app += btn_close_Click;
            dashboard.Show();
            this.Hide();
        }
        // /login system

        //keys
        private void box_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                submit += btn_login_Click;
                submit(sender, e);
            }
            submit = null;
        }
        private void box_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                submit += btn_login_Click;
                submit(sender, e);
            }
            submit = null;
        }
        // /keys

    }
}
