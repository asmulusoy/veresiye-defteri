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
    public partial class FormMusteriListele : Form
    {
        public FormMusteriListele()
        {
            InitializeComponent();
        }
        vdEntities db = new vdEntities();
        private void FormMusteriListele_Load(object sender, EventArgs e)
        {
            var musteriler = (from x in db.musterilers
                              select new {ID= x.m_id,AD=x.m_ad,SOYAD=x.m_soyad,TELEFON=x.m_ceptel,MAİL=x.m_mail,KİMLİKNO=x.m_tc,ADRES=x.m_adres,ACIKLAMA=x.m_aciklama }).ToList();

            dataGridView1.DataSource = musteriler;
            dataGridView1.Columns[0].Width = 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            musteriler musteri = (from x in db.musterilers
                                  where x.m_id == id
                                  select x).FirstOrDefault();
            decimal toplam = (decimal)musteri.cariharekets.Sum(x => x.ch_tutar);
            
            if (toplam<0)
            {
                label1.Text = "Müşterinin " + -1*toplam + " miktarında alacağı vardır.";
            }
            else
            {
                label1.Text = "Müşterinin " + toplam + " miktarında borcu vardır.";
            }
            

        }
    }
}
