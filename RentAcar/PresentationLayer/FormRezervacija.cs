using BusinessLayer;
using DataLayer.Models;
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
    public partial class FormRezervacija : Form
    {
        private readonly RezervacijaBusiness rezervacijaBusiness;
        public FormRezervacija()
        {
            this.rezervacijaBusiness = new RezervacijaBusiness();
            InitializeComponent();
        }

        private void FormRezervacija_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRevBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f8 = new Form1();
            f8.ShowDialog();
        }

        /*private void GetRezervacijaById(String s)
        {
            List<Rezervacija> reserve = this.rezervacijaBusiness.GetRezervacijaById(s);
            listBoxRezervacija.Items.Clear();

            foreach (Rezervacija r in reserve)
            {
                listBoxRezervacija.Items.Add(r.DatumOd + " - " + r.DatumDo + " " + r.ZakupacID + " " + r.AutomobilID);
            }
        }*/
    }
    
}
