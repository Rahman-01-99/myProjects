using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EmployeeManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=RAHMAN;Initial Catalog=Employee_DB;Integrated Security=True;");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();

        }

        private void showPass_Login_CheckedChanged(object sender, EventArgs e)
        {
            txt_LogPass.PasswordChar = showPass_Login.Checked ? '\0' : '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_LogUser.Text == "" || txt_LogPass.Text == "")
            {
                MessageBox.Show("Please fill all the details", "Error Messsage",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM tbl_users WHERE username = @username " +
                            " AND password = @password";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", txt_LogUser.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", txt_LogPass.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successfully!", "Information Message",MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password", "Error Message", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                            }



                        }
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show("Error : " + ex, "Error Messsage",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
             
            }
            
        }
    }
}
