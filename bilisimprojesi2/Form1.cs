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
    public partial class Form1 : Form
    {
        vdEntities db = new vdEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cariEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteriEkle frm = new FormMusteriEkle();
            frm.ShowDialog();
        }

        private void cariDüzenleSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteriDS frm = new FormMusteriDS();
            frm.ShowDialog();
        }

        private void cariListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteriListele frm = new FormMusteriListele();
            frm.ShowDialog();
        }

        private void kapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAyarlar frm = new FormAyarlar();
            frm.ShowDialog();
        }
        bool saatgosterimi;
        private void Form1_Load(object sender, EventArgs e)
        {
            string isletmeadi = (from x in db.ayarlars
                                 select x.isletme_adi).FirstOrDefault();
            this.Text = isletmeadi + this.Text;
            saatgosterimi = (bool)(from x in db.ayarlars
                             select x.tarihsaatgosterimi).FirstOrDefault();
            if (saatgosterimi)
            {
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                timer1.Enabled = false;
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
            }
            sonislemgriddoldur();
        }
        public void sonislemgriddoldur()
        {
            var islem = (from x in db.cariharekets
                            join y in db.musterilers on x.m_id equals y.m_id
                            orderby x.ch_tarih descending
                            select new { NO = x.ch_id, MUSTERİ = y.m_ad + " " + y.m_soyad, TARİH = x.ch_tarih, TUTAR =Math.Round((double)x.ch_tutar,2),İSLEMÜRÜN=x.ch_urun}).ToList();
            
            dataGridView1.DataSource = islem;

            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[4].Width = 60;

        }

       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnBorcEkle.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                button1.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMusteriEkle frm = new FormMusteriEkle();
            frm.ShowDialog();
        }

        private void btnBorcEkle_Click(object sender, EventArgs e)
        {
            FormVeresiye frm = new FormVeresiye();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTahsilat frm = new FormTahsilat();
            frm.ShowDialog();
        }

        private void borçluListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortTimeString();
            label4.Text = DateTime.Now.ToShortDateString();
        }

        private void borçEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVeresiye asm = new FormVeresiye();
            asm.ShowDialog();
        }

        private void tahsilatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTahsilat asm = new FormTahsilat();
            asm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            sonislemgriddoldur();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                decimal tutar = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                FormIslemDuzenle asm = new FormIslemDuzenle();
                asm.lblmusteriad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                asm.txtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                asm.lblislemid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                asm.txtTutar.Text = Math.Round(tutar,2).ToString();
                asm.dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                asm.Show();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRaporSec a = new FormRaporSec();
            a.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
