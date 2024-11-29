using C_R_U_D.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_R_U_D.Services
{
    internal class StudentDetailServices
    {
        public void StuDetailsCreate(StudentDetail studetail)
        {
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "INSERT INTO StudentDetails VALUES (@adress,@phoneNumber,@studentId)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@adress", studetail.Adress);
            sqlCommand.Parameters.AddWithValue("@phoneNumber", studetail.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@studentId", studetail.StudentId);
            sqlCommand.ExecuteNonQuery();
        }

        public List<StudentDetail> GetAllStuDetail(Student student)
        {
            List<StudentDetail> stuDetails = new List<StudentDetail>();
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "SELECT * FROM StudentDetails";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string adress = (string)reader.GetValue(1);
                    string phoneNumber = (string)reader.GetValue(2);
                    int StuId = (int)reader.GetValue(3);
                    stuDetails.Add(new() { Id = id, Adress = adress, PhoneNumber = phoneNumber, StudentId = StuId });
                }
                return stuDetails;
            }
            return stuDetails;
        }

        




    }
}
