namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.btn_RegSignUp = new System.Windows.Forms.Button();
            this.showPass_Register = new System.Windows.Forms.CheckBox();
            this.txt_RegPass = new System.Windows.Forms.TextBox();
            this.lbl_RegPass = new System.Windows.Forms.Label();
            this.txt_RegName = new System.Windows.Forms.TextBox();
            this.lbl_RegName = new System.Windows.Forms.Label();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ems = new System.Windows.Forms.Label();
            this.lbl_RegisterLogIn = new System.Windows.Forms.Label();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RegSignUp
            // 
            this.btn_RegSignUp.BackColor = System.Drawing.Color.DeepPink;
            this.btn_RegSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegSignUp.ForeColor = System.Drawing.Color.White;
            this.btn_RegSignUp.Location = new System.Drawing.Point(306, 296);
            this.btn_RegSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.btn_RegSignUp.Name = "btn_RegSignUp";
            this.btn_RegSignUp.Size = new System.Drawing.Size(87, 35);
            this.btn_RegSignUp.TabIndex = 15;
            this.btn_RegSignUp.Text = "SIGNUP";
            this.btn_RegSignUp.UseVisualStyleBackColor = false;
            this.btn_RegSignUp.Click += new System.EventHandler(this.btn_RegSignUp_Click);
            // 
            // showPass_Register
            // 
            this.showPass_Register.AutoSize = true;
            this.showPass_Register.Location = new System.Drawing.Point(444, 260);
            this.showPass_Register.Name = "showPass_Register";
            this.showPass_Register.Size = new System.Drawing.Size(102, 17);
            this.showPass_Register.TabIndex = 14;
            this.showPass_Register.Text = "Show Password";
            this.showPass_Register.UseVisualStyleBackColor = true;
            this.showPass_Register.CheckedChanged += new System.EventHandler(this.showPass_Register_CheckedChanged);
            // 
            // txt_RegPass
            // 
            this.txt_RegPass.Location = new System.Drawing.Point(306, 224);
            this.txt_RegPass.Multiline = true;
            this.txt_RegPass.Name = "txt_RegPass";
            this.txt_RegPass.PasswordChar = '*';
            this.txt_RegPass.Size = new System.Drawing.Size(240, 30);
            this.txt_RegPass.TabIndex = 13;
            // 
            // lbl_RegPass
            // 
            this.lbl_RegPass.AutoSize = true;
            this.lbl_RegPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegPass.Location = new System.Drawing.Point(303, 203);
            this.lbl_RegPass.Name = "lbl_RegPass";
            this.lbl_RegPass.Size = new System.Drawing.Size(75, 18);
            this.lbl_RegPass.TabIndex = 12;
            this.lbl_RegPass.Text = "Password";
            // 
            // txt_RegName
            // 
            this.txt_RegName.Location = new System.Drawing.Point(306, 158);
            this.txt_RegName.Multiline = true;
            this.txt_RegName.Name = "txt_RegName";
            this.txt_RegName.Size = new System.Drawing.Size(240, 30);
            this.txt_RegName.TabIndex = 11;
            // 
            // lbl_RegName
            // 
            this.lbl_RegName.AutoSize = true;
            this.lbl_RegName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegName.Location = new System.Drawing.Point(303, 137);
            this.lbl_RegName.Name = "lbl_RegName";
            this.lbl_RegName.Size = new System.Drawing.Size(77, 18);
            this.lbl_RegName.TabIndex = 10;
            this.lbl_RegName.Text = "Username";
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Font = new System.Drawing.Font("Artifakt Element", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register.Location = new System.Drawing.Point(301, 67);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(183, 29);
            this.lbl_Register.TabIndex = 9;
            this.lbl_Register.Text = "Register Account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_ems);
            this.panel1.Controls.Add(this.lbl_RegisterLogIn);
            this.panel1.Controls.Add(this.btn_SignIn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 450);
            this.panel1.TabIndex = 8;
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
            // lbl_RegisterLogIn
            // 
            this.lbl_RegisterLogIn.AutoSize = true;
            this.lbl_RegisterLogIn.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RegisterLogIn.ForeColor = System.Drawing.Color.White;
            this.lbl_RegisterLogIn.Location = new System.Drawing.Point(54, 372);
            this.lbl_RegisterLogIn.Name = "lbl_RegisterLogIn";
            this.lbl_RegisterLogIn.Size = new System.Drawing.Size(122, 23);
            this.lbl_RegisterLogIn.TabIndex = 1;
            this.lbl_RegisterLogIn.Text = "Login your Account";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.Color.DeepPink;
            this.btn_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn.ForeColor = System.Drawing.Color.White;
            this.btn_SignIn.Location = new System.Drawing.Point(12, 403);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(226, 32);
            this.btn_SignIn.TabIndex = 0;
            this.btn_SignIn.Text = "SIGNIN";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(551, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(24, 23);
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_RegSignUp);
            this.Controls.Add(this.showPass_Register);
            this.Controls.Add(this.txt_RegPass);
            this.Controls.Add(this.lbl_RegPass);
            this.Controls.Add(this.txt_RegName);
            this.Controls.Add(this.lbl_RegName);
            this.Controls.Add(this.lbl_Register);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_RegSignUp;
        private System.Windows.Forms.CheckBox showPass_Register;
        private System.Windows.Forms.TextBox txt_RegPass;
        private System.Windows.Forms.Label lbl_RegPass;
        private System.Windows.Forms.TextBox txt_RegName;
        private System.Windows.Forms.Label lbl_RegName;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ems;
        private System.Windows.Forms.Label lbl_RegisterLogIn;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}