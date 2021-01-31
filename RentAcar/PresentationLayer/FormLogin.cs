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

    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }
        public List<Zakupac> GetZakupacById()

        {

            List<Zakupac> results1 = new List<Zakupac>();
            SqlDataReader sqlDataReader = DBConnection.GetData("SELECT * FROM Zakupac");

            while (sqlDataReader.Read())
            {
                Zakupac r1 = new Zakupac();
                r1.ID = sqlDataReader.GetInt32(0);
                r1.Korisnik = sqlDataReader.GetString(1);
                r1.Sifra = sqlDataReader.GetString(2);
                results1.Add(r1);
            }

            DBConnection.CloseConnection();

            return results1;
        }

        public List<Zakupac> GetZakupacId(String textBoxUsername)
        {
            return this.GetZakupacById().Where(r1 => r1.Korisnik == textBoxUsername).ToList();
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

        private void uloguj_se_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(textBoxUsername.Text == string.Empty))
                {
                    if (!(textBoxPassword.Text == string.Empty))
                    {
                        //String str = "server=(localdb)\\ProjectsV13;database=RentacarDB;UID=True;Password=True";
                        String str = "Data Source=DESKTOP-NDCIMUS;Initial Catalog=RentAcar;Integrated Security=True";
                        String query = "select * from Zakupac where Korisnik = '" + this.textBoxUsername.Text + "'and Sifra = '" + this.textBoxPassword.Text + "'";
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
                            //Form1 f1 = new Form1(textBoxUsername); //this is the change, code for redirect  
                            Form1 f2 = new Form1();
                            //f1.formLogin = this;
                            //f1.ShowDialog();
                            f2.formLogin = this;
                            f2.ShowDialog();
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplikat sifre i korisnickog imena", "login page");
                        }
                        else
                        {
                            MessageBox.Show(" Lozinka ili korisnicko ime ne tacni", "login page");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Prazno polje za lozinku", "login page");
                    }
                }
                else
                {
                    MessageBox.Show(" Prazno polje za korisnicko ime", "login page");
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
            this.Hide();
            FormRegistration f3 = new FormRegistration(); //redirect na registraciju korisnika
            f3.ShowDialog();
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
