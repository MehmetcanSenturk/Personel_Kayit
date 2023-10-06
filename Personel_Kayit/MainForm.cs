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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Personel_Kayit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=root\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        void Temizle()
        {
            txtid.Text =string.Empty;
            txtpersonelAd.Text = string.Empty;
            txtSoyad.Text = string.Empty;
            cmbSehir.Text = string.Empty;
            mskdmaas.Text = string.Empty;
            txtMeslek.Text = string.Empty;
            label1.Text = string.Empty;
            txtpersonelAd.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void grPersonelKayit_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtpersonelAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskdmaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
            MessageBox.Show("Personel Eklendi");
        }

        private void rdbutevli_CheckedChanged(object sender, EventArgs e)
        {
          if(rdbutevli.Checked == true) 
            {
                label1.Text = "True";
            }
        }

        private void rdbutbekar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbutbekar.Checked == true)
            {
                label1.Text = "False";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex; 
            txtid.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            txtpersonelAd.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            mskdmaas.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            label1.Text = dataGridView1.Rows[secilendeger].Cells[5].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilendeger].Cells[6].Value.ToString();


        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if(label1.Text == "True")
            {
                rdbutevli.Checked = true;
            }
            if (label1.Text == "False")
            {
                rdbutbekar.Checked = true;
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmtsil = new SqlCommand("Delete From Tbl_Personel Where Perid=@d1",baglanti);
            kmtsil.Parameters.AddWithValue("@d1",txtid.Text);
            kmtsil.ExecuteNonQuery();
            baglanti.Close();
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
            MessageBox.Show("Kayıt Silindi");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmtGuncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@U1,PerSoyad=@U2,PerSehir=@U3,PerMaas=@U4,PerDurum=@U5,PerMeslek=@U6 where Perid=@U7", baglanti);
            kmtGuncelle.Parameters.AddWithValue("@U1", txtpersonelAd.Text);
            kmtGuncelle.Parameters.AddWithValue("@U2", txtSoyad.Text);
            kmtGuncelle.Parameters.AddWithValue("@U3", cmbSehir.Text);
            kmtGuncelle.Parameters.AddWithValue("@U4", mskdmaas.Text);
            kmtGuncelle.Parameters.AddWithValue("@U5", label1.Text);
            kmtGuncelle.Parameters.AddWithValue("@U6", txtMeslek.Text);
            kmtGuncelle.Parameters.AddWithValue("@U7", txtid.Text);
            kmtGuncelle.ExecuteNonQuery();
            baglanti.Close();
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
            MessageBox.Show("Personel Bilgisi Güncellendi");
        }

        private void btnistatistik_Click(object sender, EventArgs e)
        {
            StatsForm form_ = new StatsForm();
            form_.Show();
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            ChartsForm charts_ = new ChartsForm();
            charts_.Show();

        }

        private void grislemler_Enter(object sender, EventArgs e)
        {

        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            ReportsForm reports_ = new ReportsForm();
            reports_.Show();
        }
    }
}
