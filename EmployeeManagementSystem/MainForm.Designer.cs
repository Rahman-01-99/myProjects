namespace EmployeeManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_salary = new System.Windows.Forms.Button();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.lbl_greetUser = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dashboard1 = new EmployeeManagementSystem.Dashboard();
            this.addEmployee1 = new EmployeeManagementSystem.AddEmployee();
            this.salary1 = new EmployeeManagementSystem.Salary();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 37);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Simplex_IV50", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1073, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Controls.Add(this.btn_logout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_salary);
            this.panel2.Controls.Add(this.btn_addEmployee);
            this.panel2.Controls.Add(this.btn_dashboard);
            this.panel2.Controls.Add(this.lbl_greetUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 563);
            this.panel2.TabIndex = 1;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DeepPink;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(17, 511);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(200, 40);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_salary
            // 
            this.btn_salary.BackColor = System.Drawing.Color.DeepPink;
            this.btn_salary.FlatAppearance.BorderSize = 0;
            this.btn_salary.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orchid;
            this.btn_salary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btn_salary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.btn_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salary.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salary.Location = new System.Drawing.Point(17, 372);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(200, 40);
            this.btn_salary.TabIndex = 8;
            this.btn_salary.Text = "SALARY";
            this.btn_salary.UseVisualStyleBackColor = false;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.DeepPink;
            this.btn_addEmployee.FlatAppearance.BorderSize = 0;
            this.btn_addEmployee.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orchid;
            this.btn_addEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btn_addEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.btn_addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addEmployee.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addEmployee.Location = new System.Drawing.Point(17, 316);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(200, 40);
            this.btn_addEmployee.TabIndex = 7;
            this.btn_addEmployee.Text = "ADD EMPLOYEE";
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.DeepPink;
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.Orchid;
            this.btn_dashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orchid;
            this.btn_dashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orchid;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(17, 259);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(200, 40);
            this.btn_dashboard.TabIndex = 6;
            this.btn_dashboard.Text = "DASHBOARD";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // lbl_greetUser
            // 
            this.lbl_greetUser.AutoSize = true;
            this.lbl_greetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_greetUser.ForeColor = System.Drawing.Color.White;
            this.lbl_greetUser.Location = new System.Drawing.Point(53, 162);
            this.lbl_greetUser.Name = "lbl_greetUser";
            this.lbl_greetUser.Size = new System.Drawing.Size(130, 20);
            this.lbl_greetUser.TabIndex = 5;
            this.lbl_greetUser.Text = "Welcome, User";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addEmployee1);
            this.panel3.Controls.Add(this.salary1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(231, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(869, 563);
            this.panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(869, 563);
            this.dashboard1.TabIndex = 2;
            // 
            // addEmployee1
            // 
            this.addEmployee1.Location = new System.Drawing.Point(0, 0);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(869, 563);
            this.addEmployee1.TabIndex = 1;
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(869, 563);
            this.salary1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_greetUser;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel3;
        private Dashboard dashboard1;
        private AddEmployee addEmployee1;
        private Salary salary1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}