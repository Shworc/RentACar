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

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly RezervacijaBusiness rezervacijaBusiness;


        public Form1()
        {
            this.rezervacijaBusiness = new RezervacijaBusiness();
            
            InitializeComponent();
        }

        public Form1(String Id)
        {
            InitializeComponent();
            //this.listBoxReserve.Text = Id;
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            GetAllRezervations();
        }

        private void GetAllRezervations() 
        {

            List<Rezervacija> reserve = this.rezervacijaBusiness.GetAllRezervations();
            listBoxReserve.Items.Clear();
            
                foreach (Rezervacija r in reserve)
                {
                    listBoxReserve.Items.Add(r.DatumOd + " - " + r.DatumDo + " -> " + r.ZakupacID + " " + r.AutomobilID);
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

        }
    }
}
