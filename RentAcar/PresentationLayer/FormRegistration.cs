using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int InsertZakupac(Zakupac z)
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
            }
        }

        
    }
}
