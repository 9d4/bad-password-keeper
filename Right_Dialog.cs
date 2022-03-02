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
    public partial class Right_Dialog : Form
    {
        public Right_Dialog()
        {
            InitializeComponent();
        }

        private Point offset;
        bool mousedown = false;
        private string ttl;
        public event EventHandler close;
        private void Right_Dialog_Load(object sender, EventArgs e)
        {
            this.Show();
            btn_save.Hide();
        }
        public void show(string title)
        {
            ttl = title.Remove(0, 4);
            ttl = ttl.Replace("_", " ");
            titlebar.Text = ttl;
            ////
            this.Show();
        }

        //btns
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_show_Click(object sender, EventArgs e)
        {
            string[] data = show_stuff();
            box_username.Text = data[0];
            box_password.Text = data[1];
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Hide();
            btn_save.Show();
            box_username.Enabled = true;
            box_password.Enabled = true;
            EventHandler show = null;
            show += btn_show_Click;
            show(sender, e);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Hide();
            btn_edit.Show();
            box_username.Enabled = false;
            box_password.Enabled = false;
            Account account = new Account(ttl, box_username.Text, box_password.Text);
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Pass_Access.delete(ttl + ".txt");
            EventHandler a = null;
            a += btn_cancel_Click;
            a(sender, e);
        }
        //btns handling
        private string[] show_stuff()
        {
            string[] datas = Pass_Access.get_pass(ttl + ".txt");
            string[] a = { datas[1], datas[2] };
            return a;
        }
        private void edit()
        {

        }

        //drag
        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            offset.X = e.X;
            offset.Y = e.Y;
        }
        private void titlebar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                Point currentpos = PointToScreen(e.Location);
                Location = new Point(currentpos.X, currentpos.Y);
            }
        }
        private void titlebar_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

        }


        //copy
        private void btn_copy2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(box_username.Text);
        }
        private void btn_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(box_password.Text);
        }

        private void Right_Dialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            close(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_cancel_Click(sender, e);
        }
    }
}
