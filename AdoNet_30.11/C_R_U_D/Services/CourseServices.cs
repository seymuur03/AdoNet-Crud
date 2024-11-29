using C_R_U_D.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_R_U_D.Services
{
    internal class CourseServices
    {
        public void CreateCourse(Course course)
        {
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "INSERT INTO Courses VALUES (@Name)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", course.Name);
            sqlCommand.ExecuteNonQuery();
        }

        public List<Course> GetAllCourse()
        {
            List<Course> courses = new List<Course>();
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "SELECT * FROM Courses";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string name = (string)reader.GetValue(1);
                    courses.Add(new() { Id = id, Name = name });
                }
                return courses;
            }
            return courses;
        }

    }
}
