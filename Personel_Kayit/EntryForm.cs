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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=root\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void EntryForm_Load(object sender, EventArgs e)
        {

           
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Admin where KullaniciAd=@k1 and Sifre=@k2", baglanti);
            cmd.Parameters.AddWithValue("@k1", txtkullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@k2", txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }
            baglanti.Close();
        }
    }
}
