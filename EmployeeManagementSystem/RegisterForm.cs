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

namespace EmployeeManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=RAHMAN;Initial Catalog=Employee_DB;Integrated Security=True;");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            LoginForm logForm = new LoginForm();
            logForm.Show();
            this.Hide();
        }

        private void showPass_Register_CheckedChanged(object sender, EventArgs e)
        {
            txt_RegPass.PasswordChar = showPass_Register.Checked ? '\0' : '*';
        }

        private void btn_RegSignUp_Click(object sender, EventArgs e)
        {
            if(txt_RegName.Text == "" || txt_RegPass.Text == "")
            {
                MessageBox.Show("Please fill all the details","Error Messsage", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        String selectUsername = "SELECT COUNT(id) FROM tbl_users WHERE username=@user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", txt_RegName.Text.Trim());
                            int count = (int) checkUser.ExecuteScalar();

                            // Not working

                            if(count>= 1) 
                            {
                                MessageBox.Show(btn_RegSignUp.Text.Trim() + "is already taken", 
                                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;


                                string insertData = "INSERT INTO tbl_users " +
                                    "(username, password, date_register) " +
                                    "VALUES(@username, @password, @dateReg) ";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", txt_RegName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", txt_RegPass.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Successfully!", "Information Message"
                                        , MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm logForm = new LoginForm();
                                    logForm.Show();
                                    this.Hide();
                                }
                        }
  
                        }

                    }catch(Exception ex)
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
