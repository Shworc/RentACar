﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ZakupacRepository
    {
       /* public int InsertZakupac(Zakupac z)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Zakupac VALUES ('{0}','{1}')",
                    z.Ime, z.Password);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }*/

        
          
            public int InsertZakupac(Zakupac z)
            {
                var result = DBConnection.EditData(string.Format("INSERT INTO Zakupac VALUES ('{0}', '{1}')",
                        z.Ime, z.Password));
                DBConnection.CloseConnection();

                return result;
            }
         
    }
}
