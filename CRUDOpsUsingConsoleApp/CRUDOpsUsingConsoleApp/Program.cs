using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CRUDOpsUsingConsoleApp
{
    public class Program
    {
        public static string connectionString = "Server=Rahman\\MSSQLSERVER02; Database=TestDB; Integrated Security=True";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Select an Option");
                Console.WriteLine("1. Create Student Details");
                Console.WriteLine("2. Insert Student Academic Details");
                Console.WriteLine("3. View Student Details");
                Console.WriteLine("4. Edit Student Mark Details");
                Console.WriteLine("5. Sort Student Details");
                Console.WriteLine("6. Delete Student Details");
                Console.WriteLine("7. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateStudent();
                        break;
                    case "2":
                        InsertStudentAcademicDetails();
                        break;
                    case "3":
                        ViewStudentDetails();
                        break;
                    case "4":
                        UpdateStudentDetails();
                        break;
                    case "5":
                        SortStudentDetails();
                        break;
                    case "6":
                        DeleteStudentDetails();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid Options... Enter Correctly !!!");
                        break;
                }
            }
        }

        static void CreateStudent()
        {
            Console.WriteLine("Enter Student Roll Number : ");
            int rollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Student Name : ");
            string studentname = Console.ReadLine();
            Console.WriteLine("Enter Class: ");
            string studentClass = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth");
            DateTime studentDob = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email: ");
            string studentEmail = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number : ");
            string studentPhone = Console.ReadLine();
            Console.WriteLine("Enter the City : ");
            string studentCity = Console.ReadLine();
            Console.WriteLine("Enter the Gender : ");
            string studentGender = Console.ReadLine();
            Console.WriteLine("Enter the Nationality: ");
            string studentNationality = Console.ReadLine();

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var command = new SqlCommand("INSERT INTO StudentDetails (RollNumber, Name, Class, DateOfBirth, Email, PhoneNumber, City, Gender, Nationality) " +
                        "VALUES (@RollNumber, @Name, @Class, @DateOfBirth, @Email, @PhoneNumber, @City, @Gender, @Nationality)", connection);
                    command.Parameters.AddWithValue("RollNumber", rollNumber);
                    command.Parameters.AddWithValue("@Name", studentname);
                    command.Parameters.AddWithValue("@Class", studentClass);
                    command.Parameters.AddWithValue("@DateOfBirth", studentDob);
                    command.Parameters.AddWithValue("@Email", studentEmail);
                    command.Parameters.AddWithValue("@PhoneNumber", studentPhone);
                    command.Parameters.AddWithValue("@City", studentCity);
                    command.Parameters.AddWithValue("@Gender", studentGender);
                    command.Parameters.AddWithValue("@Nationality", studentNationality);

                    command.ExecuteNonQuery();
                    Console.WriteLine("Student Record Created");
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine($"Input format is incorrect: {ex.Message}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
        }

        static void InsertStudentAcademicDetails()
        {
            try
            {

                Console.WriteLine("Enter Student Roll Number : ");
                int rollNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Class : ");
                string studentClass = Console.ReadLine();


                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var command = new SqlCommand("SELECT COUNT(*) FROM StudentDetails WHERE RollNumber = @RollNumber AND Class = @Class", connection);
                    command.Parameters.AddWithValue("@RollNumber", rollNumber);
                    command.Parameters.AddWithValue("@Class", studentClass);

                    int studentCount = (int)command.ExecuteScalar();
                    if (studentCount == 0)
                    {
                        Console.WriteLine("Invalid Student Id !!!");
                        return;
                    }

                    Console.WriteLine("Enter English Marks");
                    int englishMark = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Tamil Marks");
                    int tamilMark = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Maths Marks");
                    int mathsMark = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Science Marks");
                    int scienceMark = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Social Marks");
                    int socialMark = Convert.ToInt32(Console.ReadLine());

                    int totalMarks = englishMark + tamilMark + mathsMark + scienceMark + socialMark;
                    decimal StudentGpa = Math.Round((decimal)totalMarks / 500 * 10, 2);


                    var marksCommand = new SqlCommand("INSERT INTO StudentAcademicDetails (RollNumber, Class, English, Tamil, Maths, Science, Social, Total, GPA) " +
                        "VALUES(@RollNumber, @Class, @English, @Tamil, @Maths, @Science, @Social, @Total, @GPA)", connection);

                    marksCommand.Parameters.AddWithValue("@RollNumber", rollNumber);
                    marksCommand.Parameters.AddWithValue("@Class", studentClass);
                    marksCommand.Parameters.AddWithValue("@English", englishMark);
                    marksCommand.Parameters.AddWithValue("@Tamil", tamilMark);
                    marksCommand.Parameters.AddWithValue("@Maths", mathsMark);
                    marksCommand.Parameters.AddWithValue("@Science", scienceMark);
                    marksCommand.Parameters.AddWithValue("@Social", socialMark);
                    marksCommand.Parameters.AddWithValue("@Total", totalMarks);
                    marksCommand.Parameters.AddWithValue("@GPA", StudentGpa);

                    marksCommand.ExecuteNonQuery();
                    Console.WriteLine("Student Marks Entered Successfully");

                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input format is incorrect: {ex.Message}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
        }

        static void ViewStudentDetails()
        {

            Console.WriteLine("Select an Option:");
            Console.WriteLine("1. View Specific Student Details");
            Console.WriteLine("2. View All Student Names");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Enter Student Roll Number: ");
                int rollNumber = Convert.ToInt32(Console.ReadLine());


                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    try
                    {
                        var studentCommand = new SqlCommand("SELECT * FROM StudentDetails WHERE RollNumber = @RollNumber", connection);
                        studentCommand.Parameters.AddWithValue("@RollNumber", rollNumber);

                        var academicCommand = new SqlCommand("SELECT * FROM StudentAcademicDetails WHERE RollNumber = @RollNumber", connection);
                        academicCommand.Parameters.AddWithValue("@RollNumber", rollNumber);

                        using (var reader = studentCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Console.WriteLine("Student Details:");
                                Console.WriteLine($"Roll Number: {reader["RollNumber"]}");
                                Console.WriteLine($"Name: {reader["Name"]}");
                                Console.WriteLine($"Class: {reader["Class"]}");
                                Console.WriteLine($"Date Of Birth: {reader["DateOfBirth"]}");
                                Console.WriteLine($"Email: {reader["Email"]}");
                                Console.WriteLine($"Phone Number: {reader["PhoneNumber"]}");
                                Console.WriteLine($"City: {reader["City"]}");
                                Console.WriteLine($"Gender: {reader["Gender"]}");
                                Console.WriteLine($"Nationality: {reader["Nationality"]}");
                            }
                        }                          

                            using (var academicReader = academicCommand.ExecuteReader())
                            {
                                if (academicReader.Read())
                                {
                                    Console.WriteLine("Academic Details:");
                                    Console.WriteLine($"English: {academicReader["English"]}");
                                    Console.WriteLine($"Tamil: {academicReader["Tamil"]}");
                                    Console.WriteLine($"Maths: {academicReader["Maths"]}");
                                    Console.WriteLine($"Science: {academicReader["Science"]}");
                                    Console.WriteLine($"Social: {academicReader["Social"]}");
                                    Console.WriteLine($"Total Marks: {academicReader["Total"]}");
                                    Console.WriteLine($"GPA: {academicReader["GPA"]}");
                                }

                                else
                                {
                                    Console.WriteLine("No academic details found for the given Roll Number and Class.");
                                }
                            }
                        }

                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
            }
            else if (choice == "2")
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    try
                    {
                        var namesCommand = new SqlCommand("SELECT RollNumber, Name FROM StudentDetails", connection);
                        using (var namesReader = namesCommand.ExecuteReader())
                        {
                            Console.WriteLine("List of All Students:");
                            while (namesReader.Read())
                            {
                                Console.WriteLine($"Roll Number: {namesReader["RollNumber"]}, Name: {namesReader["Name"]}");
                            }
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Input format is incorrect: {ex.Message}");
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Database error: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select either 1 or 2.");
            }
        }


        static void UpdateStudentDetails()
        {
            try
            {
                Console.WriteLine("Enter Student Roll Number : ");
                int rollNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Class : ");
                string studentClass = Console.ReadLine();

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();


                    var checkStudentCommand = new SqlCommand(
                        "SELECT COUNT(*) FROM StudentAcademicDetails WHERE RollNumber = @RollNumber AND Class = @Class", connection);
                    checkStudentCommand.Parameters.AddWithValue("@RollNumber", rollNumber);
                    checkStudentCommand.Parameters.AddWithValue("@Class", studentClass);

                    int studentCount = (int)checkStudentCommand.ExecuteScalar();
                    if (studentCount == 0)
                    {
                        Console.WriteLine("No academic details found for the given Roll Number and Class.");
                        return;
                    }

                    Console.WriteLine("Which mark would you like to update?");
                    Console.WriteLine("1. English");
                    Console.WriteLine("2. Tamil");
                    Console.WriteLine("3. Maths");
                    Console.WriteLine("4. Science");
                    Console.WriteLine("5. Social");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    SqlCommand updateCommand = new SqlCommand();
                    string setClause = "";
                    int markValue = 0;

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter new English Marks");
                            markValue = Convert.ToInt32(Console.ReadLine());
                            setClause = "English = @Mark";
                            break;
                        case 2:
                            Console.WriteLine("Enter new Tamil Marks");
                            markValue = Convert.ToInt32(Console.ReadLine());
                            setClause = "Tamil = @Mark";
                            break;
                        case 3:
                            Console.WriteLine("Enter new Maths Marks");
                            markValue = Convert.ToInt32(Console.ReadLine());
                            setClause = "Maths = @Mark";
                            break;
                        case 4:
                            Console.WriteLine("Enter new Science Marks");
                            markValue = Convert.ToInt32(Console.ReadLine());
                            setClause = "Science = @Mark";
                            break;
                        case 5:
                            Console.WriteLine("Enter new Social Marks");
                            markValue = Convert.ToInt32(Console.ReadLine());
                            setClause = "Social = @Mark";
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            return;
                    }

                    updateCommand.Connection = connection;
                    updateCommand.CommandText = $"UPDATE StudentAcademicDetails SET {setClause} WHERE RollNumber = @RollNumber AND Class = @Class";
                    updateCommand.Parameters.AddWithValue("@RollNumber", rollNumber);
                    updateCommand.Parameters.AddWithValue("@Class", studentClass);
                    updateCommand.Parameters.AddWithValue("@Mark", markValue);

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Academic details updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Update failed. No records were affected.");
                    }
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine($"Input format is incorrect: {ex.Message}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
        }

        static void SortStudentDetails()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    var command = new SqlCommand(@" SELECT TOP 3 RollNumber, English, Tamil, Maths, Science, Social, Total, GPA 
                                                    FROM StudentAcademicDetails ORDER BY Total DESC", connection);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            Console.WriteLine("Student Academic Details (Sorted by Total Marks):");
                            while (reader.Read())
                            {
                                Console.WriteLine($"Roll Number: {reader["RollNumber"]}");
                                Console.WriteLine($"English: {reader["English"]}");
                                Console.WriteLine($"Tamil: {reader["Tamil"]}");
                                Console.WriteLine($"Maths: {reader["Maths"]}");
                                Console.WriteLine($"Science: {reader["Science"]}");
                                Console.WriteLine($"Social: {reader["Social"]}");
                                Console.WriteLine($"Total Marks: {reader["Total"]}");
                                Console.WriteLine($"GPA: {reader["GPA"]}");
                                Console.WriteLine("----------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No academic records found.");
                        }
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input format is incorrect: {ex.Message}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
        }


        static void DeleteStudentDetails()
        {
            Console.WriteLine("Enter the Student Roll Number to Delete ");
            try
            {
                int rollNumber = Convert.ToInt32(Console.ReadLine());
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        var deleteCommand = new SqlCommand("DELETE FROM StudentDetails WHERE RollNumber = @RollNumber", connection);

                        deleteCommand.Parameters.AddWithValue("@RollNumber", rollNumber);

                        connection.Open();

                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Student Details Deleted");
                        }
                        else
                        {
                            Console.WriteLine("Enter Correct Roll Number");
                        }
                    }

                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine($"Input format is incorrect: {ex.Message}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database error: {ex.Message}");
            }
        }
    }
}
