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
    
    public partial class FormAuto : Form
    {
        private readonly AutoBusiness autoBusiness;
        public FormAuto()
        {
            this.autoBusiness = new AutoBusiness();
            InitializeComponent();
        }

        private void FormAuto_Load(object sender, EventArgs e)
        {
            GetAllAutos();
        }


        private void GetAllAutos()
        {
            List<Automobile> auto = this.autoBusiness.GetAllAutos();
            listBoxAuto.Items.Clear();

            foreach (Automobile a in auto)
            {
                listBoxAuto.Items.Add(a.ID + "." + a.Marka + " - " + a.Naziv);
            }
        }

        private void buttonAutoSave_Click(object sender, EventArgs e)
        {
            Automobile a = new Automobile();
            a.Marka = textBoxAutoMarka.Text;
            a.Naziv = textBoxAutoNaziv.Text;

            if (this.autoBusiness.InsertAutos(a))
            {
                GetAllAutos();
                textBoxAutoMarka.Text = "";
                textBoxAutoNaziv.Text = "";
            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }

        private void buttonAutoUpdate_Click(object sender, EventArgs e)
        {
            Automobile a = new Automobile();
            a.Marka = textBoxAutoMarka.Text;
            a.Naziv = textBoxAutoNaziv.Text;

            a.ID = int.Parse(listBoxAuto.SelectedItem.ToString().Split('.')[0]);

            bool result = this.autoBusiness.UpdateAutos(a);

            if (this.autoBusiness.UpdateAutos(a))
            {
                GetAllAutos();
                textBoxAutoMarka.Text = "";
                textBoxAutoNaziv.Text = "";
            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }

        private void buttonAutoDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Jeste li sigurni?",
                                        "Potvrda",
                                        MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Automobile a = new Automobile();
                a.Marka = textBoxAutoMarka.Text;
                a.Naziv = textBoxAutoNaziv.Text;
                a.ID = int.Parse(listBoxAuto.SelectedItem.ToString().Split('.')[0]);

                if (this.autoBusiness.DeleteAutos(a))
                {
                    GetAllAutos();
                    textBoxAutoMarka.Text = "";
                    textBoxAutoNaziv.Text = "";
                }
                else
                {
                    MessageBox.Show("Greska!");
                }

                bool result = this.autoBusiness.DeleteAutos(a);
            }
            else
            {

            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBackAuto_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f7 = new FormLogin();
            f7.ShowDialog();
        }

        private void listBoxAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAutoMarka.Text = listBoxAuto.SelectedItem.ToString().Split('.', '-')[1].Trim();
            textBoxAutoNaziv.Text = listBoxAuto.SelectedItem.ToString().Split('-')[1].Trim();
        }
    }
}
