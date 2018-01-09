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
    public partial class FormIslemDuzenle : Form
    {
        public FormIslemDuzenle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblislemid.Text);
            vdEntities db = new vdEntities();
            var secili = (from x in db.cariharekets
                          where x.ch_id == id
                          select x).FirstOrDefault();

            secili.ch_tarih = dateTimePicker1.Value;
            secili.ch_tutar = Convert.ToDecimal(txtTutar.Text);
            secili.ch_urun = txtUrunAdi.Text;
            db.SaveChanges();
            MessageBox.Show("İşlem başarı ile güncellenmiştir.");
            this.Close();
            
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
        }

        private void FormIslemDuzenle_Load(object sender, EventArgs e)
        {

        }
    }
}
