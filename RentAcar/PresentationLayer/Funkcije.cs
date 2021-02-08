﻿using BusinessLayer;
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
        public DataSet ds = new DataSet();
        public DataSet ds2 = new DataSet();
        DataTable dt = new DataTable();
        DataTable dtc = new DataTable();
        DataGridView dataGridView1;
        public SqlDataReader dbr;
        public SqlConnection con;
        public SqlCommand cmd;
        public String str;
        public String query;
        public String cmbquery;
        public static int cena;
        public void Query(String query) //Upit
        {
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            dbr = cmd.ExecuteReader();
        }
        public void Konekcija() //Konekcija
        {
            str = "Data Source=DESKTOP-NDCIMUS;Initial Catalog=RentACar2003111SQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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