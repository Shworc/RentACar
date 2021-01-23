using BusinessLayer;
using DataLayer.Models;
using System;
using System.Windows.Forms;
namespace PresentationLayer
{

    public partial class FormRegistration : Form
    {
        private readonly ZakupacBusiness zakupacBusiness; //kacenje na zakupac biznis

        private void FormRegistration_Load(object sender, EventArgs e)
        {
            
        }
        public FormRegistration()
        {
            this.zakupacBusiness = new ZakupacBusiness();
            InitializeComponent();
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
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Zakupac z = new Zakupac();
            z.Ime = textBoxName.Text;
            z.Password = textBoxPassword.Text;

            if (this.zakupacBusiness.InsertZakupac(z))
            {
                MessageBox.Show("Uspesno dodato");
            }
            else
            {
                MessageBox.Show("Greska!");
            }
            

            /*int InsertZakupac(Zakupac z)
            {
                using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = string.Format("INSERT INTO Zakupac VALUES ('{0}','{1}')",
                        z.Ime, z.Password);

                    sqlConnection.Open();

                    return sqlCommand.ExecuteNonQuery();
                }
            }*/
        }

       

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f2 = new FormLogin(); //redirect na registraciju korisnika
            f2.ShowDialog();
        }


        private void FormRegistration_Load_1(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Jeste li sigurni?",
                                     "Potvrda",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
              
            }
            
        }
    }
}
