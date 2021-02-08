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
            //Query("INSERT INTO Rezervacije (Marka, Model,[Registarski broj], [Broj sasije],Godiste,Tip,Boja) VALUES('"+txtIme.Text+"','"+txtModel.Text+"','"+txtReg.Text + "','" + txtSasija.Text + "','" + txtGodiste.Text + "','"+ txtTip.Text+ "','" + txtBoja.Text+"')");
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
    }
    }
