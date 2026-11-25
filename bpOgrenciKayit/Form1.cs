using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bpOgrenciKayit
{
    public partial class Form1 : Form
    {
        string baglantiMetni = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OgrenciKayitDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VeritabaniVeTabloyuHazirla();
            KayitlariListele();
        }

        private void KayitlariListele()
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiMetni))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Ad, Soyad, Bolum FROM OgrencilerX", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOgrenciler.DataSource = dt;
            }
        }

        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            cmbBolum.SelectedIndex = -1;
            cmbBolum.Text = "";
        }

        private void butEkle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text == "" || txtSoyadi.Text == "" || cmbBolum.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            SqlConnection baglanti = new SqlConnection(baglantiMetni);
            SqlCommand komut = new SqlCommand("INSERT INTO OgrencilerX (Ad, Soyad, Bolum) VALUES (@ad, @soyad, @bolum)", baglanti);
            komut.Parameters.AddWithValue("@ad", txtAdi.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            komut.Parameters.AddWithValue("@bolum", cmbBolum.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt eklendi!");
            KayitlariListele();
            Temizle();
        }

        private void butGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek bir kayıt seçin!");
                return;
            }

            if (txtAdi.Text == "" || txtSoyadi.Text == "" || cmbBolum.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            int seciliId = Convert.ToInt32(dgvOgrenciler.CurrentRow.Cells["Id"].Value);

            SqlConnection baglanti = new SqlConnection(baglantiMetni);
            SqlCommand komut = new SqlCommand("UPDATE OgrencilerX SET Ad = @ad, Soyad = @soyad, Bolum = @bolum WHERE Id = @id", baglanti);
            komut.Parameters.AddWithValue("@ad", txtAdi.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            komut.Parameters.AddWithValue("@bolum", cmbBolum.Text);
            komut.Parameters.AddWithValue("@id", seciliId);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt güncellendi!");
            KayitlariListele();
            Temizle();
        }

        private void butSil_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silinecek bir kayıt seçin!");
                return;
            }

            int seciliId = Convert.ToInt32(dgvOgrenciler.CurrentRow.Cells["Id"].Value);

            SqlConnection baglanti = new SqlConnection(baglantiMetni);
            SqlCommand komut = new SqlCommand("DELETE FROM OgrencilerX WHERE Id = @id", baglanti);
            komut.Parameters.AddWithValue("@id", seciliId);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kayıt silindi!");
            KayitlariListele();
            Temizle();
        }

        private void dgvOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOgrenciler.CurrentRow != null)
            {
                txtAdi.Text = dgvOgrenciler.CurrentRow.Cells["Ad"].Value?.ToString();
                txtSoyadi.Text = dgvOgrenciler.CurrentRow.Cells["Soyad"].Value?.ToString();
                cmbBolum.Text = dgvOgrenciler.CurrentRow.Cells["Bolum"].Value?.ToString();
            }
        }

        private void VeritabaniVeTabloyuHazirla()
        {
            string masterBaglanti = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(masterBaglanti))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'OgrenciKayitDB') CREATE DATABASE OgrenciKayitDB;", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }

            using (SqlConnection conn = new SqlConnection(baglantiMetni))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(
                    @"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'OgrencilerX')
                      CREATE TABLE dbo.OgrencilerX (
                          Id INT IDENTITY(1,1) PRIMARY KEY,
                          Ad NVARCHAR(50) NOT NULL,
                          Soyad NVARCHAR(50) NOT NULL,
                          Bolum NVARCHAR(100) NOT NULL
                      );", conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
