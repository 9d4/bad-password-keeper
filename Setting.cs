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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            string[] data = Data_Access.read_user_pass();
            box_username.Text = data[0];
            box_password.Text = data[1];
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Data_Access.mk_pass(box_username.Text, box_password.Text);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
