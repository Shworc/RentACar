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
    
    public partial class FormAuto : Form
    {
        DataRow dr;
        DataRowBuilder ParmUnos;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlDataReader dbr;
        private readonly AutoBusiness autoBusiness;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public FormAuto()
        {
           /// this.autoBusiness = new AutoBusiness();
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FormAuto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentACar200311DataSet.Automobili' table. You can move, or remove it, as needed.
            //this.automobiliTableAdapter.Fill(this.rentACar200311DataSet.Automobili);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            String str = "Data Source=DESKTOP-NDCIMUS;Initial Catalog=RentACar2003111SQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            String query = "select * From Automobili";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;   
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            dbr = cmd.ExecuteReader();
            dt.Load(dbr);
            dataGridView1.DataSource = dt;




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

        private void GetAllAutos()
        {
          /*  List<Automobile> auto = this.autoBusiness.GetAllAutos();
            listBoxAuto.Items.Clear();

            foreach (Automobile a in auto)
            {
                listBoxAuto.Items.Add(a.ID + "." + a.Marka + " - " + a.Model);
            }*/
        }

        private void buttonAutoSave_Click(object sender, EventArgs e)
        {
            Automobile a = new Automobile();
            a.Marka = txtMarka.Text;
            a.Model = txtModel.Text;

            if (this.autoBusiness.InsertAutos(a))
            {
                GetAllAutos();
                txtMarka.Text = "";
                txtModel.Text = "";
            }
            else
            {
                MessageBox.Show("Greska!");
            }
        }

        private void buttonAutoUpdate_Click(object sender, EventArgs e)
        {
            Automobile a = new Automobile();
            a.Marka = txtMarka.Text;
            a.Model = txtModel.Text;

            a.ID = int.Parse(listBoxAuto.SelectedItem.ToString().Split('.')[0]);

            bool result = this.autoBusiness.UpdateAutos(a);

            if (this.autoBusiness.UpdateAutos(a))
            {
                GetAllAutos();
                txtMarka.Text = "";
                txtModel.Text = "";
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
                a.Marka = txtMarka.Text;
                a.Model = txtModel.Text;
                a.ID = int.Parse(listBoxAuto.SelectedItem.ToString().Split('.')[0]);
                


                if (this.autoBusiness.DeleteAutos(a))
                {
                    GetAllAutos();
                    txtMarka.Text = "";
                    txtModel.Text = "";
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

        

      
        private void listBoxAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMarka.Text = listBoxAuto.SelectedItem.ToString().Split('.', '-')[1].Trim();
            txtModel.Text = listBoxAuto.SelectedItem.ToString().Split('-')[1].Trim();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRevBack_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form1 f1 = new Form1();
           f1.ShowDialog();
        }

        private void Isprazni_Click(object sender, EventArgs e)
        {
            txtGodiste.Text = "" ;
            txtMarka.Text = "";
            txtModel.Text = "";
            txtReg.Text = "";
            txtSasija.Text = "";
            txtBoja.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
