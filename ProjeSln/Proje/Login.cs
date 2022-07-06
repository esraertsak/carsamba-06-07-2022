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
using System.Data.Sql;




namespace Proje
{
    public partial class Login : Form
    {
        SqlConnection baglanti;
        SqlDataReader dr;
        SqlCommand komut;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            baglanti = new SqlConnection(@"Data Source=DESKTOP-ASFN1BE;Initial Catalog=PCB;Integrated Security=True");
            komut = new SqlCommand("SELECT * FROM roles", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbRol.Properties.Items.Add(dr["role"]);
            }
            baglanti.Close();
        }

        private void btngiris_Click_1(object sender, EventArgs e)
        {
            string user = txtMail.Text;
            string password = txtPassword.Text;

            baglanti = new SqlConnection(@"Data Source=DESKTOP-ASFN1BE;Initial Catalog=PCB;Integrated Security=True");
            komut = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
           

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM users WHERE userName='" + txtMail.Text + "'AND Password='" + txtPassword.Text + "'  ";
            sda.Fill(dt);
            dr = komut.ExecuteReader();

            baglanti.Close();

            //
            DataTable dt1= new DataTable();

            baglanti.Open();
            komut.CommandText = "SELECT * FROM roles ";
            sda.Fill(dt1);
            dr = komut.ExecuteReader();

            //
            string cmbItemValue = cmbRol.SelectedItem.ToString();
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (dt1.Rows[i]["role"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("You're login as   " + dt1.Rows[i][1]);
                        MainPage gecis = new MainPage();
                        gecis.Show();
                        this.Hide();
                    }
                }


            }
            else
            {
                MessageBox.Show("hatalı");
            }
            baglanti.Close();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış yapmak mı istiyorsunuz?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                
            }
        }

        private void txtMail_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

