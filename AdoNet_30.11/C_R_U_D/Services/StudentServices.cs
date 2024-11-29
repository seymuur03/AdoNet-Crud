using C_R_U_D.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_R_U_D.Services
{
    internal class StudentServices
    {
        public void StudentCreate(Student student)
        {
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new(connectinStr);
            sqlConnection.Open();
            string query = "INSERT INTO Students VALUES(@Name,@Age,@Groupid)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", student.Name);
            sqlCommand.Parameters.AddWithValue("@Age", student.Age);
            sqlCommand.Parameters.AddWithValue("@Groupid", student.GroupId);
            sqlCommand.ExecuteNonQuery();
        }

        public List<Student> GetAllStudent()
        {
            List<Student> students = new List<Student>();
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "SELECT * FROM Students";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string name = (string)reader.GetValue(1);
                    int age = (int)reader.GetValue(2);
                    int groupId = (int)reader.GetValue(3);
                    students.Add(new() { Id = id, Name = name, Age = age, GroupId = groupId });
                }
                return students;
            }
            return students;
        }

        




    }
}
