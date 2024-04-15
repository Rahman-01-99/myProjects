using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout ?",
                "confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                 
               LoginForm logForm = new LoginForm();
                logForm.ShowDialog();
                this.Hide();
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salary1.Visible = false;
        }

        private void btn_addEmployee_Click(object sender, EventArgs e)
        {

            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salary1.Visible = false;
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salary1.Visible = true;
        }
    }
}
