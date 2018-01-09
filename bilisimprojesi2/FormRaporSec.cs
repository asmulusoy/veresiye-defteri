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
    public partial class FormRaporSec : Form
    {
        public FormRaporSec()
        {
            InitializeComponent();
        }
        vdEntities db = new vdEntities();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var secili = (from x in db.musterilers
                          where x.m_ad.Contains(textBox1.Text) || x.m_soyad.Contains(textBox1.Text)
                          select new { ID = x.m_id, AD = x.m_ad, SOYAD = x.m_soyad, TC_KNO = x.m_tc, TELEFON = x.m_telefon, CEP = x.m_ceptel }).ToList();
            dataGridView1.DataSource = secili;
        }

        private void FormRaporSec_Load(object sender, EventArgs e)
        {
            var musteriler = (from x in db.musterilers
                              select new { ID = x.m_id, AD = x.m_ad, SOYAD = x.m_soyad, CEP = x.m_ceptel }).ToList();
            dataGridView1.DataSource = musteriler;
            dataGridView1.Rows[0].Selected = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mid = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            FormRapor a = new FormRapor();
            var liste = (from x in db.cariharekets
                         where x.m_id == mid
                         select new { URUN = x.ch_urun,TUTAR = Math.Round((double)x.ch_tutar, 2), TARİH = x.ch_tarih, ACIKLAMA = x.ch_aciklama }).ToList();
            var musteri = (from x in db.musterilers
                           where x.m_id == mid
                           select new { x.m_ad, x.m_soyad }).FirstOrDefault();
            a.dataGridView1.DataSource = liste;
            a.label2.Text = musteri.m_ad + " " + musteri.m_soyad;
            a.dataGridView1.Columns[0].Width = 150;
            a.dataGridView1.Columns[1].Width = 80;
            a.dataGridView1.Columns[2].Width = 100;
            a.dataGridView1.Columns[3].Width = 300;
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRapor a = new FormRapor();
            var musteriler = (from x in db.musterilers
                           select x).ToList();
            a.dataGridView1.Columns.Add("id", "ID");
            a.dataGridView1.Columns.Add("ad", "AD");
            a.dataGridView1.Columns.Add("soyad", "SOYAD");
            a.dataGridView1.Columns.Add("cep", "TELEFON");
            a.dataGridView1.Columns.Add("adres", "ADRES");
            a.dataGridView1.Columns.Add("hesap", "HESAP");
            for (int i = 0; i < musteriler.Count; i++)
            {
                musteriler b = musteriler[i];
                decimal toplam = (decimal)b.cariharekets.Sum(x => x.ch_tutar);
                a.dataGridView1.Rows.Add(b.m_id.ToString(), b.m_ad, b.m_soyad, b.m_ceptel, b.m_adres,Math.Round(toplam,2));
            }
            a.label1.Hide();
            a.label2.Hide();
            a.dataGridView1.Columns[0].Width = 50;
            a.dataGridView1.Columns[1].Width = 80;
            a.dataGridView1.Columns[2].Width = 100;
            a.dataGridView1.Columns[3].Width = 100;
            a.dataGridView1.Columns[4].Width = 200;
            a.dataGridView1.Columns[5].Width = 100;
            a.ShowDialog();
        }
    }
}
