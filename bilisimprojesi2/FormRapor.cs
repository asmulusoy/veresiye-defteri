using DGVPrinterHelper;
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
    public partial class FormRapor : Form
    {
        public FormRapor()
        {
            InitializeComponent();
        }

        private void FormRapor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter yazdir = new DGVPrinter();
            yazdir.Title = label2.Text + " Hesap Raporu";
            yazdir.SubTitle = string.Format("Tarih: {0}", DateTime.Now.ToShortDateString());
            yazdir.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            yazdir.PageNumbers = true;
            yazdir.PageNumberInHeader = false;
            yazdir.PorportionalColumns = true;
            yazdir.HeaderCellAlignment = StringAlignment.Near;            
            yazdir.Footer = "Veresiye Defteri V.1";
            yazdir.FooterSpacing = 15;
            yazdir.PrintDataGridView(dataGridView1);




        }
        
       // private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
       // {
           
       // }

       // private void toolStripButton1_Click(object sender, EventArgs e)
        //{
          

        //}
    }
}
