﻿using C_R_U_D.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_R_U_D.Services
{
    internal class GroupServices
    {
        public void CreateGroup(Group Group)
        {
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "INSERT INTO Groups VALUES (@Name)";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", Group.Name);
            sqlCommand.ExecuteNonQuery();
        }

        public List<Group> GetAllGroup()
        {
            List<Group> groups = new List<Group>();
            string connectinStr = "Server = DESKTOP-Q4CUAVA\\SQLEXPRESS ; Database = HomeWork_AdoNet ; Trusted_Connection = true ;";
            using SqlConnection sqlConnection = new SqlConnection(connectinStr);
            sqlConnection.Open();
            string query = "SELECT * FROM Groups";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string name = (string)reader.GetValue(1);
                    groups.Add(new Group { Id = id, Name = name });
                }
                return groups;
            }
            return groups;
        }
    }
}
