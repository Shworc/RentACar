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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public List<Zakupac> GetZakupacById()

        {

            List<Zakupac> results1 = new List<Zakupac>();
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Zakupac");

            while (sqlDataReader.Read())
            {
                Zakupac r1 = new Zakupac();
                r1.ID = sqlDataReader.GetInt32(0);
                //r1.Ime = sqlDataReader.GetString(1);
                //r1.Password = sqlDataReader.GetString(2);

                results1.Add(r1);
            }

            DBConnection.CloseConnection();

            return results1;
        }

        public List<Zakupac> GetZakupacId(String textBoxUsername)
        {
            return this.GetZakupacById().Where(r1 => r1.Ime == textBoxUsername).ToList();
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(textBoxUsername.Text == string.Empty))
                {
                    if (!(textBoxPassword.Text == string.Empty))
                    {
                        //String str = "server=(localdb)\\ProjectsV13;database=RentacarDB;UID=True;Password=True";
                        String str = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=RentacarDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                        String query = "select * from Zakupac where Ime = '" + this.textBoxUsername.Text + "'and Password = '" + this.textBoxPassword.Text + "'";
                        SqlConnection con = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader dbr;
                        con.Open();
                        dbr = cmd.ExecuteReader();
                        int count = 0;

                        while (dbr.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            this.Hide();
                            Form1 f1 = new Form1(); //this is the change, code for redirect  
                            f1.ShowDialog();
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show(" username and password incorrect", "login page");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" password empty", "login page");
                    }
                }
                else
                {
                    MessageBox.Show(" username empty", "login page");
                }
                // con.Close();  
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegistration f3 = new FormRegistration(); //redirect na registraciju korisnika
            f3.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
