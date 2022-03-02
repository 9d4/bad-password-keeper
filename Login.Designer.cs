namespace Password_Keeper
{
    partial class Logind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logind));
            this.Container = new System.Windows.Forms.Panel();
            this.hint = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.box_password = new System.Windows.Forms.TextBox();
            this.box_username = new System.Windows.Forms.TextBox();
            this.title_head = new System.Windows.Forms.Label();
            this.title_bar = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.Container.SuspendLayout();
            this.title_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(43)))), ((int)(((byte)(82)))));
            this.Container.Controls.Add(this.hint);
            this.Container.Controls.Add(this.btn_login);
            this.Container.Controls.Add(this.btn_cancel);
            this.Container.Controls.Add(this.box_password);
            this.Container.Controls.Add(this.box_username);
            this.Container.Location = new System.Drawing.Point(59, 68);
            this.Container.Margin = new System.Windows.Forms.Padding(100);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(194, 142);
            this.Container.TabIndex = 0;
            // 
            // hint
            // 
            this.hint.Font = new System.Drawing.Font("Anonymous Pro", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hint.ForeColor = System.Drawing.Color.Green;
            this.hint.Location = new System.Drawing.Point(10, 113);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(178, 29);
            this.hint.TabIndex = 4;
            this.hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.Green;
            this.btn_login.Location = new System.Drawing.Point(113, 81);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 29);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.Red;
            this.btn_cancel.Location = new System.Drawing.Point(13, 81);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(76, 29);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // box_password
            // 
            this.box_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(45)))), ((int)(((byte)(92)))));
            this.box_password.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_password.ForeColor = System.Drawing.Color.White;
            this.box_password.Location = new System.Drawing.Point(29, 52);
            this.box_password.Name = "box_password";
            this.box_password.Size = new System.Drawing.Size(159, 23);
            this.box_password.TabIndex = 1;
            this.box_password.UseSystemPasswordChar = true;
            this.box_password.Enter += new System.EventHandler(this.box_password_Enter);
            this.box_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_password_KeyDown);
            this.box_password.Leave += new System.EventHandler(this.box_password_Leave);
            // 
            // box_username
            // 
            this.box_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(45)))), ((int)(((byte)(92)))));
            this.box_username.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_username.ForeColor = System.Drawing.Color.White;
            this.box_username.Location = new System.Drawing.Point(29, 14);
            this.box_username.Name = "box_username";
            this.box_username.Size = new System.Drawing.Size(159, 23);
            this.box_username.TabIndex = 0;
            this.box_username.Enter += new System.EventHandler(this.box_username_Enter);
            this.box_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_username_KeyDown);
            this.box_username.Leave += new System.EventHandler(this.box_username_Leave);
            // 
            // title_head
            // 
            this.title_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_head.Font = new System.Drawing.Font("Anonymous Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_head.Location = new System.Drawing.Point(2, 29);
            this.title_head.Name = "title_head";
            this.title_head.Size = new System.Drawing.Size(308, 36);
            this.title_head.TabIndex = 1;
            this.title_head.Text = "LOGIN";
            this.title_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title_bar
            // 
            this.title_bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title_bar.Controls.Add(this.btn_minimize);
            this.title_bar.Controls.Add(this.btn_close);
            this.title_bar.Location = new System.Drawing.Point(2, 0);
            this.title_bar.Name = "title_bar";
            this.title_bar.Size = new System.Drawing.Size(308, 28);
            this.title_bar.TabIndex = 0;
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Anonymous Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.Blue;
            this.btn_minimize.Location = new System.Drawing.Point(225, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 23);
            this.btn_minimize.TabIndex = 0;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Text = "-";
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimize.UseVisualStyleBackColor = true;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(263, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(45, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(43)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(310, 227);
            this.Controls.Add(this.title_bar);
            this.Controls.Add(this.title_head);
            this.Controls.Add(this.Container);
            this.Font = new System.Drawing.Font("Yu Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Password Keeper";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Container.ResumeLayout(false);
            this.Container.PerformLayout();
            this.title_bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Label title_head;
        private System.Windows.Forms.Panel title_bar;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.TextBox box_password;
        private System.Windows.Forms.TextBox box_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label hint;
    }
}

