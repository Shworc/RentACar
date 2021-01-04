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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(usertxt.Text == string.Empty))
                {
                    if (!(passtxt.Text == string.Empty))
                    {
                        String str = "server=MUNESH-PC;database=windowapp;UID=sa;password=123";
                        String query = "select * from data where username = '" + usertxt.Text + "'and password = '" + this.passtxt.Text + "'";
                        SqlConnection con = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader dbr;
                        con.Open();
                        dbr = cmd.ExecuteReader();
                        int count = 0;
                        while (dbr.Read())
                        {
                            count = count + 1;
                        }
                        if (count == 1)
                        {
                            this.hide();
                            Form2 f2 = new form2(); //this is the change, code for redirect  
                            f2.ShowDialog();
                        }
                        else if (count > 1)
                        {
                            MessageBox.Show("Duplicate username and password", "login page");
                        }
                        else
                        {
                            MessageBox.Show(" username and password incorrect", "login page");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" password empty", "login page");
                    }
                }
                else
                {
                    MessageBox.Show(" username empty", "login page");
                }
                // con.Close();  
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        
    }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
