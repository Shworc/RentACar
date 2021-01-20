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
    public partial class Form1 : Form
    {
        private readonly RezervacijaBusiness rezervacijaBusiness;
        private readonly ZakupacBusiness zakupacBusiness;
        private readonly AutoBusiness autoBusiness;
        private readonly object textBoxUsername;
        public FormLogin formLogin;
        public FormRezervacija formRezervacija;

        public Form1()
        {
            this.rezervacijaBusiness = new RezervacijaBusiness();
            this.zakupacBusiness = new ZakupacBusiness();
            this.autoBusiness = new AutoBusiness();
            InitializeComponent();
        }
        public Form1(TextBox _textBoxUsername)
        {
            textBoxUsername = _textBoxUsername;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllRezervacije();
        }

        private void GetAllRezervacije() 
        {

            List<Rezervacija> reserve = this.rezervacijaBusiness.GetAllRezervations();
            listBoxReserve.Items.Clear();
            
                foreach (Rezervacija r in reserve)
                {
                    listBoxReserve.Items.Add(r.DatumOd + " - " + r.DatumDo + " -> " + r.ZakupacID + " " + r.AutomobilID);
                }
        }

        private void GetAllZakupci()
        {

            List<Zakupac> reserve = this.zakupacBusiness.GetAllZakupci();
            //listBoxReserve.Items.Clear();

            foreach (Zakupac r in reserve)
            {
                comboBoxZakupacID.Items.Add(r.Ime);
                comboBoxZakupacID.Items.AddRange(reserve.ToArray());
            }
        }

        /* 
         * SELECT Ime, Marka, Naziv, DatumOd, DatumDo FROM Rezervacija
            JOIN Zakupac 
            ON Rezervacija.ZakupacID = Zakupac.Id
            JOIN Automobil
            ON Rezervacija.AutomobilID = Automobil.Id
            WHERE ZakupacID = '1'
        */



        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f2 = new FormLogin(); //redirect na registraciju korisnika
            f2.ShowDialog();
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRezervacija f3 = new FormRezervacija(); //redirect na formu rezervacija
            f3.ShowDialog();
        }

        private void buttonSaveRez_Click(object sender, EventArgs e)
        {
            Rezervacija r = new Rezervacija();
            r.ZakupacID = int.Parse(comboBoxZakupacID.Text);
            r.AutomobilID = int.Parse(comboBoxAutoID.Text);
            r.DatumOd = DateTime.Parse(dateTimePicker1.Text);
            r.DatumDo = DateTime.Parse(dateTimePicker2.Text);

            bool result = this.rezervacijaBusiness.InsertRezervacija(r);

            if (this.rezervacijaBusiness.InsertRezervacija(r))
            {
                GetAllRezervacije();
                comboBoxZakupacID.Text = "";
                comboBoxAutoID.Text = "";

            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }

        private void comboBoxZakupacID_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Zakupac> reserve = this.zakupacBusiness.GetAllZakupci();
            listBoxReserve.Items.Clear();

            

                DataTable table = new DataTable();
            foreach (Zakupac r in reserve)
            {
                table.Columns.Add("Ime");
                table.Rows.Add();
                comboBoxZakupacID.DataSource = table;
                comboBoxZakupacID.DisplayMember = "Ime";
            }

            
        }
        public void comboBoxZakupacID_SelectedIndexChanged_Load(object sender, EventArgs e)
        {
            List<Zakupac> reserve = this.zakupacBusiness.GetAllZakupci();
            listBoxReserve.Items.Clear();

            DataTable table = new DataTable();
            foreach (Zakupac r in reserve)
            {
                table.Columns.Add("Ime");
                table.Rows.Add();
                comboBoxZakupacID.DataSource = table;
                comboBoxZakupacID.DisplayMember = "Ime";
            }


        }

        private void comboBoxAutoID_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
