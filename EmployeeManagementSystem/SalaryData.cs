using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    internal class SalaryData
    {
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }


        SqlConnection connect = new SqlConnection(@"Data Source=RAHMAN;Initial Catalog=Employee_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public List<SalaryData> salaryEmployeeListData()
        {
            List<SalaryData> Listdata = new List<SalaryData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM tbl_employeeRecords";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            SalaryData sd = new SalaryData();

                            sd.EmployeeID = reader["employee_id"].ToString();
                            sd.Name = reader["full_name"].ToString();
                            sd.Gender = reader["gender"].ToString();
                            sd.Contact = reader["contact_number"].ToString();
                            sd.Position = reader["position"].ToString();
                            sd.Salary = (int)reader["salary"];

                            Listdata.Add(sd);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return Listdata;
        }


    }
}
