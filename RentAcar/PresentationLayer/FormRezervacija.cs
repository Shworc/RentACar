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
            GetAllRezervacije(); 
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

        private void GetAllRezervacije()
        {
            List<Rezervacija> reserve = this.rezervacijaBusiness.GetAllRezervations();
            listBoxRezervacija.Items.Clear();

            foreach (Rezervacija r in reserve)
            {
                listBoxRezervacija.Items.Add(r.Id + "." + r.ZakupacID + " - " + r.AutomobilID + " " + r.DatumOd + " " + r.DatumDo);
                //comboBoxZakupacID.Items.AddRange(reserve.ToArray()); //vrati ovo
                //comboBoxAutoID.Items.AddRange(reserve.ToArray()); //vratiovo
            }

        }
        /*komande za snimanje, 
         * editovanje i 
         * brisanje rezervacije
        */
        private void buttonSaveReserve_Click(object sender, EventArgs e) //vrati ove funkcije kad napravis unos preko JMBGa
        {
            /*   Rezervacija r = new Rezervacija();
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
               List<Rezervacija> reserve = this.rezervacijaBusiness.GetAllRezervations();
               listBoxRezervacija.Items.Clear();

               foreach (Rezervacija r in reserve)
               {
                   //listBoxRezervacija.Items.Add(r.Id + "." + r.ZakupacID + " - " + r.AutomobilID + " " + r.DatumOd + " " + r.DatumDo);
                   comboBoxZakupacID.Items.AddRange(reserve.ToArray());
                   comboBoxZakupacID.Items.Add(r.ZakupacID);

                   //comboBoxAutoID.Items.AddRange(reserve.ToArray());
               }
           }
            */
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
    }
