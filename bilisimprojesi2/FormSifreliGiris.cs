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
    public partial class FormSifreliGiris : Form
    {
        public FormSifreliGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vdEntities db = new vdEntities();
            var bilgiler = (from x in db.ayarlars
                            select x).FirstOrDefault();
            string kadi = bilgiler.k_adi;
            string sifre = bilgiler.sifre;

            if (textBox1.Text == kadi)
            {
                if (textBox2.Text == sifre)
                {
                    this.Hide();
                    Form1 a = new Form1();
                    a.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen şifreyi kontrol ediniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adını kontrol ediniz.");
            }

        }

        private void FormSifreliGiris_Load(object sender, EventArgs e)
        {
            
        }
    }
}
