using BusinessLayer;
using DataLayer.Models;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public partial class Form1 : Funkcije
    {
        private readonly RezervacijaBusiness rezervacijaBusiness;
        private readonly KorisnikBusiness korisnikBusiness;
        private readonly AutoBusiness autoBusiness;
        private readonly object textBoxUsername;
        public FormLogin formLogin;
        public FormRezervacija formRezervacija;
        DataRow dr2;
        DataRowBuilder ParmUnos;
        DataSet ds2 = new DataSet();
        DataTable dt2 = new DataTable();
        SqlDataReader dbr2;
        DataTable dt = new DataTable();
        public Form1()
        {
           //this.rezervacijaBusiness = new RezervacijaBusiness();
            //this.KorisnikBusiness = new KorisnikBusiness();
           // this.autoBusiness = new AutoBusiness();
            InitializeComponent();
        }
        public Form1(TextBox _textBoxUsername)
        {
            textBoxUsername = _textBoxUsername;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Konekcija();
            Query("select * From Rezervacije");
            RefreshTabele(dt, dataGridView2);
        }
      

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            PorukaPotvrde(() => Application.Exit());
        }
        private void buttonReserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRezervacija f3 = new FormRezervacija(); //redirect na formu rezervacija
            f3.ShowDialog();
        }

        private void buttonSaveRez_Click(object sender, EventArgs e) //Rezervacija dugme klik metoda
        {
            this.Hide();
            FormRezervacija f3 = new FormRezervacija(); //redirect na formu rezervacija
            f3.ShowDialog();
        }
            
       
        private void comboBoxAutoID_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuto f6 = new FormAuto();//redirect na registraciju auta
            f6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
         
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            PorukaPotvrde(() => Application.Restart());
        }
    }
}
