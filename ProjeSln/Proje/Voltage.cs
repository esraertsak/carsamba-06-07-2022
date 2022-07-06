using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Proje
{
    public partial class Voltage : Form
    {
        public Voltage()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ASFN1BE;Initial Catalog=PCB;Integrated Security=True");
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Serial_Number gecis = new Serial_Number();
            gecis.Show();
            this.Hide();
        }

        private void Voltage_Load(object sender, EventArgs e)
        {

        }



        //private void Voltage_Load(object sender, EventArgs e)
        //{
        //    SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-ASFN1BE;Initial Catalog=PCB;Integrated Security=True");
        //    SqlCommand komut = new SqlCommand(komut, baglanti);
        //    baglanti.Open();
        //    SqlDataReader dr = komut.ExecuteReader();
        //    if (dr.Read())
        //    {
        //        textBox.Text = dr.GetValue(0).ToString();
        //    }
        //    baglanti.Close();

        //}
    }
}
