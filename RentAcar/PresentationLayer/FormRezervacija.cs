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
