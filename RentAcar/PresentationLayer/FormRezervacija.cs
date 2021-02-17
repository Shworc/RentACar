using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormRezervacija : Funkcije
    {
        DataTable dt = new DataTable();
        //private readonly RezervacijaBusiness rezervacijaBusiness;
        Boolean Postojeci = false;
        public FormRezervacija()
        {
            //this.rezervacijaBusiness = new RezervacijaBusiness();
            InitializeComponent();
        }
        private void FormRezervacija_Load(object sender, EventArgs e)
        {
            //GetAllRezervacije(); 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Konekcija();
            Query("select * From Automobili where [U upotrebi]=0");
            RefreshTabele(dt, dataGridView1);
            ComboLoad(cmbMarkaOdabir,"Marka","Marka", "select distinct Marka From Automobili");
            cmbModelOdabir.Text = "";
            cmbMarkaOdabir.Text = "";
            if (prosliKlijent == false)
            {
                btnProsliKlijent.Enabled = false;
            }
                
        }
        private void ComboMarka (object sender, EventArgs e){
            ComboLoad2(cmbModelOdabir, "Model", "Model", "select distinct Model From Automobili Where Marka='"+cmbMarkaOdabir.Text+"'"); 
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
            if (Postojeci == false) {
            iQuery("INSERT INTO Klijenti (Ime,Prezime,JMBG,Adresa,[Mobilni broj],Grad) VALUES('" + txtIme.Text + "','" + txtPrezime.Text + "','" + txtJMBG.Text + "','" + txtAdresa.Text + "','" + txtMobilni.Text + "','" + txtGrad.Text + "')"); 
            }
            idKlijent = idLoad("Select id FROM Klijenti WHERE JMBG='" + txtJMBG.Text + "'");
            Query("INSERT INTO Rezervacije ([Datum od],[Datum do],[Automobil ID],[Korisnik ID],[Klijent ID]) VALUES('"+DatumOd.Text+"','"+DatumDo.Text + "','" + drS(0) + "','1','"+ idKlijent + "')");
            prosliKlijent = true;
            Refresh();
            MessageBox.Show("Uspesna rezervacija");
        }
        private void Refresh()  //Cudan refresh forme jer ne radi Refresh ni Update za grid ni formu, ni DataSource=null
        {
            FormRezervacija a = new FormRezervacija();
            a.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            PorukaPotvrde(() => Application.Restart());
        }
        private void UnosSelektovanogUPolja (object sender, DataGridViewCellEventArgs e) {
            //cmbMarkaOdabir.Text = drS(0);
            //cmbModelOdabir.Text = drS(1);
            txtOdabranAuto.Text = drS(1) + " " +drS(2) + " (" + drS(4) + ")";
            txtRegistarskiBroj.Text = drS(5);
        }

        private void button2_Click(object sender, EventArgs e) //Pretrazi automobil
        {
            if (cmbModelOdabir.Text =="" && cmbMarkaOdabir.Text!="")
            {
                String txt = cmbMarkaOdabir.Text;
                Query("select * From Automobili Where Marka='" + txt + "' AND [U upotrebi]=0");
            }
            else if (cmbModelOdabir.Text != "")
            { 
            Query("select * From Automobili Where Marka='" + cmbMarkaOdabir.Text + "' AND Model='" + cmbModelOdabir.Text + "' AND [U upotrebi]=0");
            }
            else
            {
                Query("select * From Automobili where [U upotrebi]=0");
            }
            RefreshTabele(dt, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Isprazni();
        }

        private void btnNoviKlijent_Click(object sender, EventArgs e)
        {
            OtkrivanjeTxtBoxa(true);
            txtJMBG.Enabled = true;
            BojaTxtBoxa(Color.White);
            Postojeci = false;
            txtJMBG.Text = "";
            MessageBox.Show("Uneti podatke novog klijenta");
        }

        private void btnPostojeciKlijent_Click(object sender, EventArgs e)
        {
            OtkrivanjeTxtBoxa(false);
            txtJMBG.Enabled = true;
            BojaTxtBoxa(Color.Silver);
            Postojeci = true;
            txtJMBG.Text = "";
            MessageBox.Show("Uneti JMBG posotojeceg klijenta");
        }
        public void OtkrivanjeTxtBoxa(Boolean b)
        {
            txtIme.Enabled = txtPrezime.Enabled = txtAdresa.Enabled = txtGrad.Enabled = txtMobilni.Enabled = b;
        }
        public void BojaTxtBoxa(Color c)
        {
            txtIme.BackColor = txtPrezime.BackColor = txtAdresa.BackColor = txtGrad.BackColor = txtMobilni.BackColor = c;
            txtJMBG.BackColor = Color.White;
        }

        private void btnProsliKlijent_Click(object sender, EventArgs e)
        {
            OtkrivanjeTxtBoxa(false);
            txtJMBG.Enabled = false;
            txtJMBG.BackColor = Color.White;
            txtJMBG.Text = JMBGload("Select JMBG FROM Klijenti WHERE id='" + idKlijent + "'");
        }
    }
    }
