using C_R_U_D.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_R_U_D.Services
{
    internal class OneToOneRelationServices
    {
        public void GetAllStudentWithDetails()
        {
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "SELECT * FROM StudentWithDetails";
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
                    string adress = (string)reader.GetValue(4);
                    string phoneNumber = (string)reader.GetValue(5);

                    Console.WriteLine(id + " " + name + " " + age + " " + groupId + " " + adress + " " + phoneNumber);
                }
            }
        }

        public void Update(int age , int x)
        {
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "UPDATE StudentWithDetails SET Age = @age WHERE Age > @x";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@age",age);
            sqlCommand.Parameters.AddWithValue("@x", x);
            sqlCommand.ExecuteNonQuery();
        }
    }
}
