namespace EmployeeManagementSystem
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ems = new System.Windows.Forms.Label();
            this.lbl_AccReg = new System.Windows.Forms.Label();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.lbl_LogRegister = new System.Windows.Forms.Label();
            this.lbl_LogUser = new System.Windows.Forms.Label();
            this.txt_LogUser = new System.Windows.Forms.TextBox();
            this.txt_LogPass = new System.Windows.Forms.TextBox();
            this.lbl_LogPass = new System.Windows.Forms.Label();
            this.showPass_Login = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_ems);
            this.panel1.Controls.Add(this.lbl_AccReg);
            this.panel1.Controls.Add(this.btn_SignUp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 450);
            this.panel1.TabIndex = 0;
            // 
            // lbl_ems
            // 
            this.lbl_ems.AutoSize = true;
            this.lbl_ems.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ems.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ems.Location = new System.Drawing.Point(6, 169);
            this.lbl_ems.Name = "lbl_ems";
            this.lbl_ems.Size = new System.Drawing.Size(246, 19);
            this.lbl_ems.TabIndex = 2;
            this.lbl_ems.Text = "Employee Management System";
            // 
            // lbl_AccReg
            // 
            this.lbl_AccReg.AutoSize = true;
            this.lbl_AccReg.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccReg.ForeColor = System.Drawing.Color.White;
            this.lbl_AccReg.Location = new System.Drawing.Point(54, 372);
            this.lbl_AccReg.Name = "lbl_AccReg";
            this.lbl_AccReg.Size = new System.Drawing.Size(138, 23);
            this.lbl_AccReg.TabIndex = 1;
            this.lbl_AccReg.Text = "Register your Account";
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.Color.DeepPink;
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.White;
            this.btn_SignUp.Location = new System.Drawing.Point(12, 403);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(226, 32);
            this.btn_SignUp.TabIndex = 0;
            this.btn_SignUp.Text = "SIGNUP";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // lbl_LogRegister
            // 
            this.lbl_LogRegister.AutoSize = true;
            this.lbl_LogRegister.Font = new System.Drawing.Font("Artifakt Element", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogRegister.Location = new System.Drawing.Point(288, 67);
            this.lbl_LogRegister.Name = "lbl_LogRegister";
            this.lbl_LogRegister.Size = new System.Drawing.Size(153, 29);
            this.lbl_LogRegister.TabIndex = 1;
            this.lbl_LogRegister.Text = "Login Account";
            // 
            // lbl_LogUser
            // 
            this.lbl_LogUser.AutoSize = true;
            this.lbl_LogUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogUser.Location = new System.Drawing.Point(290, 137);
            this.lbl_LogUser.Name = "lbl_LogUser";
            this.lbl_LogUser.Size = new System.Drawing.Size(77, 18);
            this.lbl_LogUser.TabIndex = 2;
            this.lbl_LogUser.Text = "Username";
            // 
            // txt_LogUser
            // 
            this.txt_LogUser.Location = new System.Drawing.Point(293, 158);
            this.txt_LogUser.Multiline = true;
            this.txt_LogUser.Name = "txt_LogUser";
            this.txt_LogUser.Size = new System.Drawing.Size(240, 30);
            this.txt_LogUser.TabIndex = 3;
            // 
            // txt_LogPass
            // 
            this.txt_LogPass.Location = new System.Drawing.Point(293, 224);
            this.txt_LogPass.Multiline = true;
            this.txt_LogPass.Name = "txt_LogPass";
            this.txt_LogPass.PasswordChar = '*';
            this.txt_LogPass.Size = new System.Drawing.Size(240, 30);
            this.txt_LogPass.TabIndex = 5;
            // 
            // lbl_LogPass
            // 
            this.lbl_LogPass.AutoSize = true;
            this.lbl_LogPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogPass.Location = new System.Drawing.Point(290, 203);
            this.lbl_LogPass.Name = "lbl_LogPass";
            this.lbl_LogPass.Size = new System.Drawing.Size(75, 18);
            this.lbl_LogPass.TabIndex = 4;
            this.lbl_LogPass.Text = "Password";
            // 
            // showPass_Login
            // 
            this.showPass_Login.AutoSize = true;
            this.showPass_Login.Location = new System.Drawing.Point(431, 260);
            this.showPass_Login.Name = "showPass_Login";
            this.showPass_Login.Size = new System.Drawing.Size(102, 17);
            this.showPass_Login.TabIndex = 6;
            this.showPass_Login.Text = "Show Password";
            this.showPass_Login.UseVisualStyleBackColor = true;
            this.showPass_Login.CheckedChanged += new System.EventHandler(this.showPass_Login_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.DeepPink;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(293, 296);
            this.btn_login.Margin = new System.Windows.Forms.Padding(0);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(87, 35);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(552, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(24, 23);
            this.btn_exit.TabIndex = 8;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.showPass_Login);
            this.Controls.Add(this.txt_LogPass);
            this.Controls.Add(this.lbl_LogPass);
            this.Controls.Add(this.txt_LogUser);
            this.Controls.Add(this.lbl_LogUser);
            this.Controls.Add(this.lbl_LogRegister);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_LogRegister;
        private System.Windows.Forms.Label lbl_LogUser;
        private System.Windows.Forms.TextBox txt_LogUser;
        private System.Windows.Forms.TextBox txt_LogPass;
        private System.Windows.Forms.Label lbl_LogPass;
        private System.Windows.Forms.CheckBox showPass_Login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label lbl_AccReg;
        private System.Windows.Forms.Label lbl_ems;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

