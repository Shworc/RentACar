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
using System.Data.SqlClient;
using DataLayer;
using System.Runtime.InteropServices;
namespace PresentationLayer
{
    
    public partial class FormAuto : Funkcije
    {
        
        DataTable dt = new DataTable();
        public FormAuto()
        {
            //this.autoBusiness = new AutoBusiness();
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); //Zaobljen prozor
          
        }
       private void FormAuto_Load(object sender, EventArgs e) //Cita formu
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Konekcija();
            Query("select * From Automobili");
            RefreshTabele(dt, dataGridView1);
            ComboLoad(cmbMarka, "Marka", "Marka", "select distinct Marka From Automobili");
            cmbMarka.Text = "";
        }
        private void LogOut_Click(object sender, EventArgs e) //Logout
        {
            PorukaPotvrde(() => Application.Restart()); 
        }

        private void buttonExit_Click_1(object sender, EventArgs e) //Izlaz iz aplikacije
        {
            PorukaPotvrde(() => Application.Exit()); 
        }
        
        private void buttonRevBack_Click(object sender, EventArgs e) //Nazad na formu rezervacije
        {
           this.Hide();
           Form1 f1 = new Form1();
           f1.ShowDialog();
        }

        private void Isprazni_Click(object sender, EventArgs e) //Prazni polja
        {
            Isprazni();
        }

        private void button1_Click(object sender, EventArgs e) //Obrisi  red u bazi (klik na dugme Obrisi)
        {
            PorukaPotvrde(() => brisanjeAuta());
        }
        private void brisanjeAuta() // Brise selektovan auto
        {
            Query("Delete FROM Automobili Where id=" + drS(0));
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e) //Unesi podatak u bazu (klik na dugme Unesi)
        {
            Query("INSERT INTO Automobili (Marka, Model,[Registarski broj], [Broj sasije],Godiste,Tip,Boja) VALUES('"+cmbMarka.Text+"','"+txtModel.Text+"','"+txtReg.Text + "','" + txtSasija.Text + "','" + txtGodiste.Text + "','"+ txtTip.Text+ "','" + txtBoja.Text+"')");
            Refresh();
        }
        private void Refresh()  //Cudan refresh forme jer ne radi Refresh ni Update za grid ni formu, ni DataSource=null
        {
            FormAuto a = new FormAuto();
            a.Show();
            this.Hide();
        }
        private void button3_Click(object sender, DataGridViewCellEventArgs e) //Unos selektovane kolone u polja
        {
            txtSelektovanid.Text = drS(0);
            cmbMarka.Text= drS(1);
            txtModel.Text = drS(2);
            txtBoja.Text = drS(3);
            txtTip.Text = drS(4);
            txtGodiste.Text = drS(5);
            txtReg.Text = drS(6);
            txtSasija.Text = drS(7);
            txtNapomena.Text = drS(8);
        }
        private void button3_Click(object sender, DataGridViewCellMouseEventArgs e) //Header Klik Refresh id (mora zbog greske pri sortiranju)
        {
            txtSelektovanid.Text = drS(0);
        }
        private void button2_Click(object sender, EventArgs e) //Izmena napomene
        {
            Query("UPDATE Automobili SET Napomena='"+txtNapomena.Text+"' WHERE id="+drS(0));
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e) //Dugme pretrage
        { 
            if (cmbMarka.Text.Length==0) {
                Query("SELECT * FROM Automobili");
                RefreshTabele(dt, dataGridView1);
            }
  
            else
            {
                Query("SELECT * FROM Automobili WHERE Marka='" + cmbMarka.Text + "'");
                RefreshTabele(dt, dataGridView1);
                Isprazni();
            }
        }
    }
}
