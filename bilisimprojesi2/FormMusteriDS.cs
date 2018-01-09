using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilisimprojesi2
{
    public partial class FormMusteriDS : Form
    {
        public FormMusteriDS()
        {
            InitializeComponent();
        }
        vdEntities db = new vdEntities();
        private void FormMusteriDS_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            var musteriler = (from x in db.musterilers
                              select new { ID = x.m_id, AD = x.m_ad, SOYAD = x.m_soyad, TC_KNO = x.m_tc, TELEFON = x.m_telefon, CEP = x.m_ceptel }).ToList();
            dataGridView1.DataSource = musteriler;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            var secili = (from x in db.musterilers
                          where x.m_ad.Contains(textBox1.Text) || x.m_soyad.Contains(textBox1.Text)
                          select new { ID = x.m_id, AD = x.m_ad, SOYAD = x.m_soyad, TC_KNO = x.m_tc, TELEFON = x.m_telefon, CEP = x.m_ceptel }).ToList();
            dataGridView1.DataSource = secili;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var secili = (from x in db.musterilers
                          where x.m_id == id
                          select x).FirstOrDefault();
            txtAd.Text = secili.m_ad;
            txtSoyad.Text = secili.m_soyad;
            txtEmail.Text = secili.m_mail;
            txtCepTel.Text = secili.m_ceptel;
            txtAdres.Text = secili.m_adres;
            txtTcNo.Text = secili.m_tc;
            txtAciklama.Text = secili.m_aciklama;
            txtTelefon.Text = secili.m_telefon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            var secili = (from x in db.musterilers
                          where x.m_id == id
                          select x).FirstOrDefault();
            secili.m_ad = txtAd.Text;
            secili.m_soyad = txtSoyad.Text;
            secili.m_telefon = txtTelefon.Text;
            secili.m_ceptel = txtCepTel.Text;
            secili.m_mail = txtEmail.Text;
            secili.m_aciklama = txtAciklama.Text;
            secili.m_adres = txtAdres.Text;
            secili.m_tc = txtTcNo.Text;
            db.SaveChanges();
            MessageBox.Show("Müşteri başarılı bir şekilde güncellenmiştir.", "Müşteri Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            
            if (MessageBox.Show("Cari Hesap ve tüm verileri silinecektir. Bu işlemden emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //müşterinin işlemlerini siliyorum
                var islemler = (from x in db.cariharekets
                                where x.m_id == id
                                select x).ToList();
                foreach (var item in islemler)
                {
                    db.cariharekets.Remove(item);
                }
                db.SaveChanges();


                //müşteriyi siliyorum
                var secili = (from x in db.musterilers
                              where x.m_id == id
                              select x).FirstOrDefault();
                db.musterilers.Remove(secili);
                db.SaveChanges();
                MessageBox.Show("Cari Hesap başarılı bir şekilde silinmiştir.", "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
