using BusinessLayer;
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
        private readonly ZakupacBusiness zakupacBusiness; //kacenje na zakupac biznis

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            GetAllZakupci();
        }
        public FormRegistration()
        {
            
            this.zakupacBusiness = new ZakupacBusiness();
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Zakupac z = new Zakupac();
            z.Ime = textBoxName.Text;
            z.Password = textBoxPassword.Text;

            zakupacBusiness.InsertZakupac(z); //boool mozemo da testiramo
            

            /*int InsertZakupac(Zakupac z)
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
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f2 = new FormLogin(); //redirect na registraciju korisnika
            f2.ShowDialog();
        }

        private void GetAllZakupci()
        {
            List<Zakupac> zakupac = this.zakupacBusiness.GetAllZakupci();
            listBoxZakupci.Items.Clear();

            foreach (Zakupac z in zakupac)
            {
                listBoxZakupci.Items.Add(z.ID + " - " + z.Ime + " - " + z.Password);
            }
        }

        private void FormRegistration_Load_1(object sender, EventArgs e)
        {

              GetAllZakupci();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Zakupac z = new Zakupac();
            z.Ime = textBoxName.Text;
            z.Password = textBoxPassword.Text;

            z.ID = int.Parse(listBoxZakupci.SelectedItem.ToString().Split('-')[0]);

            bool result = this.zakupacBusiness.UpdateZakupac(z);
        }
    }
}
