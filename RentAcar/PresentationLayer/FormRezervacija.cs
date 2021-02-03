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
    public partial class FormRezervacija : Funkcije
    {
        private readonly RezervacijaBusiness rezervacijaBusiness;
        public FormRezervacija()
        {
            //this.rezervacijaBusiness = new RezervacijaBusiness();
            InitializeComponent();
        }

        private void FormRezervacija_Load(object sender, EventArgs e)
        {
            //GetAllRezervacije(); 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            PorukaPotvrde(() => Application.Exit()); 
        }

        private void buttonRevBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f8 = new Form1();
            f8.ShowDialog();
        }

        private void buttonSaveReserve_Click(object sender, EventArgs e) //vrati ove funkcije kad napravis unos preko JMBGa
        {
         
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            PorukaPotvrde(() => Application.Restart());
        }
    }
    }
