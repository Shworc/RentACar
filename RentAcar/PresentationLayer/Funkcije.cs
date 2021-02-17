using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using DataLayer.Models;
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
    public class Funkcije : Form
    {
        public SqlDataAdapter da;
        public SqlDataAdapter da2;
        public SqlDataAdapter da3;
        public SqlDataAdapter da4;
        public SqlDataAdapter da5;
        public DataSet ds = new DataSet();
        public DataSet ds2 = new DataSet();
        public DataSet ds3 = new DataSet();
        public DataSet ds4 = new DataSet();
        public DataSet ds5 = new DataSet();
        DataTable dt = new DataTable();
        DataTable dtc = new DataTable();
        DataGridView dataGridView1;
        public SqlDataReader dbr;
        public SqlDataReader dbr2;
        public SqlConnection con;
        public SqlCommand cmd;
        public SqlCommand cmd2;
        public String str;
        public String query;
        public String query2;
        public String query3;
        public String query4;
        public String query5;
        public String cmbquery;
        public static int cena;
        public static String idKlijent;
        public static Boolean prosliKlijent;
        public void Query(String query) //Upit
        {
            cmd.CommandText = query;
            dbr = cmd.ExecuteReader();
        }
      
    
        public void Konekcija() //Konekcija
        {
            str = "unesi string";
            con = new SqlConnection(str);
            con.Open();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
        }
        public void RefreshTabele(DataTable dt, DataGridView dataGridView2)  //Cudan refresh tabele 
        {
            dt.Clear();
            dt.Load(dbr);
            dataGridView1 = dataGridView2; //samo potrebno kada se ubacuje preko funkcije neposredno
            dataGridView1.DataSource = dt;
        }
        public String drS(int row) //Vraca vrednost zadate kolone po redu
        {
            return dataGridView1.SelectedRows[0].Cells[row].Value.ToString();
        }
        public void ComboLoad(ComboBox combobox,String ID, String Name, String cmbquery)
        {
            da = new SqlDataAdapter(cmbquery, con);
            da.Fill(ds);
            combobox.ValueMember = ID;
            combobox.DisplayMember = Name;
            combobox.DataSource = ds.Tables[0];
        }
        public void ComboLoad2(ComboBox combobox, String ID, String Name, String cmbquery2) //Comboload sa clear funkcijom
        {
            ds2.Clear();
            da2 = new SqlDataAdapter(cmbquery2, con);
            da2.Fill(ds2);
            combobox.Text = "";
            combobox.ValueMember = ID;
            combobox.DisplayMember = Name;
            combobox.DataSource = ds2.Tables[0];
        }
        public String idLoad(String cmbquery3) //Comboload sa clear funkcijom
        {
            ds3.Clear();
            da3 = new SqlDataAdapter(cmbquery3, con);
            da3.Fill(ds3);
            return ds3.Tables[0].Rows[0][0].ToString();
        }
        public String JMBGload(String cmbquery5) //Comboload sa clear funkcijom
        {
            ds5.Clear();
            da5 = new SqlDataAdapter(cmbquery5, con);
            da5.Fill(ds5);
            return ds5.Tables[0].Rows[0][0].ToString();
        }
        public void iQuery(String cmbquery4) //Comboload sa clear funkcijom
        {
            ds4.Clear();
            da4 = new SqlDataAdapter(cmbquery4, con);
            da4.Fill(ds4);
        }
        protected override void WndProc(ref Message m) //Omogucava pomeranje prozora
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
        public void PorukaPotvrde(Action Metoda) //Poruka potvrde
        { 
            var confirmResult = MessageBox.Show("Da li sigurni?", "Potvrda", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Metoda();
            }
            else { }
        }
        public void Isprazni() //Prazni sve TextBoxove
        {
            var t = this.Controls.OfType<TextBox>().AsEnumerable<TextBox>(); //Uzeto sa neta zbog manjeg koda
            var c = this.Controls.OfType<ComboBox>().AsEnumerable<ComboBox>();
            foreach (TextBox item in t)
            {
                item.Text = "";
            }
            foreach (ComboBox item in c)
            {
                item.Text = "";
            }
        }
        /*...............Za zaobljene ivice prozora................*/
        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );*/
        /*..........................................................*/


        /*private String drS(int row) //Vraca vrednost zadate kolone po redu
        {
            return dataGridView1.SelectedRows[0].Cells[row].Value.ToString();
        }*/
    }
}
