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
    public partial class FormAyarlar : Form
    {
        public FormAyarlar()
        {
            InitializeComponent();
        }
        vdEntities db = new vdEntities();
        private void FormAyarlar_Load(object sender, EventArgs e)
        {
            
            var ayar = (from x in db.ayarlars
                        select x).FirstOrDefault();
            if (ayar.tarihsaatgosterimi == true)
            {
                chctarihsaat.Checked = true;
            }

            
                txtkullaniciadi.Text = ayar.k_adi;
                txtsifre.Text = ayar.sifre;
            
            textBox1.Text = ayar.isletme_adi;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ayar = (from x in db.ayarlars
                        select x).FirstOrDefault();
            ayar.isletme_adi = textBox1.Text;
            if (chctarihsaat.Checked)
            {
                ayar.tarihsaatgosterimi = true;
            }
            else
            {
                ayar.tarihsaatgosterimi = false;
            }
            
           
                if ((txtkullaniciadi.Text!="")&&(txtsifre.Text!=""))
                {
                    if (txtsifre.Text == txtsifreonay.Text)
                         {
                        ayar.k_adi = txtkullaniciadi.Text;
                        ayar.sifre = txtsifre.Text;
                        db.SaveChanges();

                    }
                    else
                    {
                        MessageBox.Show("Şifreler birbiri ile uyumsuz!", "Ayarlar Güncellenemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir kullanıcı adı ve şifre giriniz!", "Ayarlar Güncellenemedi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
            db.SaveChanges();
            MessageBox.Show("Ayarlar güncellendi. Program tekrar başlatıldığında ayarlar aktif olacaktır.","Başarılı!");
            this.Close();


        }

        private void chcgiris_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
