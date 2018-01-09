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
    public partial class FormMusteriEkle : Form
    {
       
        public FormMusteriEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text !="" && txtSoyad.Text !="")
            {
                vdEntities db = new vdEntities();
                musteriler yeni = new musteriler();
                yeni.m_ad = txtAd.Text;
                yeni.m_soyad = txtSoyad.Text;
                yeni.m_telefon = txtTelefon.Text;
                yeni.m_ceptel = txtCepTel.Text;
                yeni.m_mail = txtEmail.Text;
                yeni.m_aciklama = txtAciklama.Text;
                yeni.m_adres = txtAdres.Text;
                yeni.m_tc = txtTcNo.Text;
                db.musterilers.Add(yeni);
                db.SaveChanges();
                MessageBox.Show("Müşteri başarılı bir şekilde eklenmiştir.", "Müşteri Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen (*) ile belirtilmiş zorunlu alanları doldurunuz.", "Uyarı");
            }



           

        }

        private void FormMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
