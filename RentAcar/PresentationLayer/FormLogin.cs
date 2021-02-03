using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace PresentationLayer
{

    public partial class FormLogin : Funkcije
    {

        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    
        public List<Korisnik> GetKorisnikById()

        {

            List<Korisnik> results1 = new List<Korisnik>();
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Korisnici");

            while (sqlDataReader.Read())
            {
                Korisnik r1 = new Korisnik();
                r1.ID = sqlDataReader.GetInt32(0);
                r1.Korisnicko = sqlDataReader.GetString(1);
                r1.Sifra = sqlDataReader.GetString(2);
                results1.Add(r1);
            }

            DBConnection.CloseConnection();

            return results1;
        }

        public List<Korisnik> GetKorisnikId(String textBoxUsername)
        {
            return this.GetKorisnikById().Where(r1 => r1.Korisnicko == textBoxUsername).ToList();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FormRegistration f3 = new FormRegistration(); //redirect na registraciju korisnika
            //f3.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonA_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormAuto f6 = new FormAuto();//redirect na registraciju auta
            f6.ShowDialog();
        }

        private void groupBoxLogin_Enter(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        public void uloguj_se_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(textBoxUsername.Text == string.Empty))
                {
                    if (!(textBoxPassword.Text == string.Empty))
                    {
                        Konekcija();
                        Query("select * from Korisnici where Korisnicko = '" + this.textBoxUsername.Text + "'and Sifra = '" + this.textBoxPassword.Text + "'");
                        int count = 0;
                        while (dbr.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            MessageBox.Show("Uspesan login", "Login");
                            this.Hide();
                            Form1 f = new Form1();
                            f.formLogin = this;
                            f.ShowDialog();
                            
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplikat sifre i korisnickog imena", "Login");
                        }
                        else
                        {
                            MessageBox.Show(" Lozinka ili korisnicko ime ne tacni", "Login");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Prazno polje za lozinku", "Login");
                    }
                }
                else
                {
                    MessageBox.Show(" Prazno polje za korisnicko ime", "Login");
                }
                // con.Close();  
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //FormRegistration f3 = new FormRegistration(); //redirect na registraciju korisnika
            //f3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            //f1.formLogin = this;
            //f1.ShowDialog();
            f2.formLogin = this;
            f2.ShowDialog();
        }
    }
}
