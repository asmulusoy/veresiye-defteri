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
    public partial class FormVeresiye : Form
    {
        public FormVeresiye()
        {
            InitializeComponent();
        }
        vdEntities db = new vdEntities();
        private void FormVeresiye_Load(object sender, EventArgs e)
        {
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
            lblmusteriad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTutar.Text == "")
            {
                MessageBox.Show("Lütfen veresiye tutarını giriniz.", "Uyarı");
            }
            else { 

         //hareket tipi veresiye ise true tahsilat ise false  
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            carihareket yeni = new carihareket();
            yeni.ch_tarih = dateTimePicker1.Value;
            yeni.ch_aciklama = txtAciklama.Text;
            yeni.ch_tutar = Convert.ToDecimal(txtTutar.Text);
            yeni.ch_urun = "VERESİYE-"+txtUrunAdi.Text;
            yeni.m_id = id;
            yeni.ch_harekettipi = true;
            db.cariharekets.Add(yeni);
            db.SaveChanges();
            MessageBox.Show(lblmusteriad.Text + " hesabına " + txtTutar.Text +" TL eklenmiştir.", "Borç Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();

              
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                lblmusteriad.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
        }
    }
}
