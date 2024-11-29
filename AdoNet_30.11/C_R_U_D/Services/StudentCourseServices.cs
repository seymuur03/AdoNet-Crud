using C_R_U_D.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_R_U_D.Services
{
    internal class StudentCourseServices
    {
        public void CreateStudentCourse(StudentCourse studentCourse)
        {
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "INSERT INTO StudentCourses VALUES (@studentId,@courseId)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@studentId", studentCourse.StudentId);
            sqlCommand.Parameters.AddWithValue("@courseId", studentCourse.CourseId);
            sqlCommand.ExecuteNonQuery();
        }

        public List<StudentCourse> GetAllStuCourse()
        {
            List<StudentCourse> stuCourses = new List<StudentCourse>();
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "SELECT * FROM StudentCourses";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    int stuId = (int)reader.GetValue(1);
                    int courseId = (int)reader.GetValue(2);
                    stuCourses.Add(new() { Id = id, StudentId = stuId, CourseId = courseId });
                }
                return stuCourses;
            }
            return stuCourses;
        }
    }
}
