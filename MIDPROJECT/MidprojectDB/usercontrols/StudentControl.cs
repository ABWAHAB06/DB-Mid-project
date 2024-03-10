using MidprojectDB.BL;
using MidprojectDB.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidprojectDB.usercontrols
{
    public partial class StudentControl : UserControl
    {
        public StudentControl()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string firstname=FirstNametxt.Text.ToString();
            string lastName=LastNametxt.Text.ToString();
            string RegistrationNumber= Regestrationtxt.Text.ToString();
            string Email=Emailtxt.Text.ToString();
            string Contact=Contacttxt.Text.ToString();
            int status = 5;
            Student student=new Student(firstname,lastName, RegistrationNumber, Email, Contact, status);
            bool isTrue=insertdata(student);
          if(isTrue)
            {
                MessageBox.Show("Student Inserted");
            }
        }

        public bool insertdata(Student student)
        {


            using (SqlConnection connection = new SqlConnection(Configration.SqlConnectionString))
            {

               
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Student (FirstName, LastName, Email, RegistrationNumber, Contact, Status) " +
                              "VALUES (@FirstName, @LastName, @Email, @RegistrationNumber, @Contact, @Status)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@LastName", student.LastName);
                    command.Parameters.AddWithValue("@Email", student.Email);
                    command.Parameters.AddWithValue("@RegistrationNumber", student.RegistrationNumber);
                    command.Parameters.AddWithValue("@Contact", student.Contact);
                    command.Parameters.AddWithValue("@Status", student.Status);
                    command.ExecuteNonQuery();

                    return true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                return false;
            }

        }

        private void View_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource= loadData();
        }

        List<Student> loadData()
        {
            List<Student> list = new List<Student>();
           /* StudentDL.List.Clear();*/
            list.Clear();
            using (SqlConnection connection = new SqlConnection(Configration.SqlConnectionString))
            {
                connection.Open();

                try
                {
                    string query = "SELECT FirstName, LastName, Contact, Email, RegistrationNumber, Status FROM Student";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string FirstName = reader["FirstName"].ToString();
                        string LastName = reader["LastName"].ToString();
                        string Contact = reader["Contact"].ToString();
                        string Email = reader["Email"].ToString();
                        string RegistrationNumber = reader["RegistrationNumber"].ToString();
                        int Status = Convert.ToInt32(reader["Status"]);
                        Student student = new Student(FirstName, LastName, RegistrationNumber, Email, Contact, Status);
                        list.Add(student);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return list;
        }
    }

}
