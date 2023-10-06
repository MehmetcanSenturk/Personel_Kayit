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

namespace Personel_Kayit
{
    public partial class ChartsForm : Form
    {
        public ChartsForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=root\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void ChartsForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("Select PerSehir,Count(*) from Tbl_Personel Group By PerSehir", baglanti);
            SqlDataReader dr = cmd1.ExecuteReader();
            while(dr.Read()) 
            {
                chart1.Series["Sehirler"].Points.AddXY(dr[0], dr[1]);

            }
            baglanti.Close();
            /*
             * 
             */
            baglanti.Open ();
            SqlCommand cmd2 = new SqlCommand("Select PerMeslek,Avg(PerMaas) From Tbl_Personel Group By PerMeslek", baglanti);
            SqlDataReader dr1 = cmd2.ExecuteReader();
            while (dr1.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr1[0], dr1[1]);
            }

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
