using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_App
{
    public partial class Kasir_Form : Form
    {
        public Kasir_Form()
        {
            InitializeComponent();
        }

        Function func = new Function();

        private void Kasir_Form_Load(object sender, EventArgs e)
        {
            func.OpenChildForm(new Kasir_Index(), panel_Desktop, sender);
        }

        private void btn_Tambah_Click(object sender, EventArgs e)
        {
            func.OpenChildForm(new Form_Transaksi(), panel_Desktop, sender);
            btn_Kembali.Visible = true;
        }

        private void btn_Kembali_Click(object sender, EventArgs e)
        {
            func.OpenChildForm(new Kasir_Index(), panel_Desktop, sender);
            btn_Tambah.Visible = true;
        }
    }
}
