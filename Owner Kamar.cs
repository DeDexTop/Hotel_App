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
    public partial class Owner_Kamar : Form
    {
        public Owner_Kamar()
        {
            InitializeComponent();
        }

        Function func = new Function();

        private void Owner_Kamar_Load(object sender, EventArgs e)
        {
            func.ReadData("SELECT tipe_kamar Tipe, harga_per_malam Harga, dibuat Tanggal_Pembuatan FROM tb_kamar", dgv_Kamar);
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            func.ReadData("SELECT tipe_kamar Tipe, harga_per_malam Harga, dibuat Tanggal_Pembuatan FROM tb_kamar", dgv_Kamar);
            txt_TIpe.Text = string.Empty;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            func.ReadData("SELECT tipe_kamar Tipe, harga_per_malam Harga, dibuat Tanggal_Pembuatan FROM tb_kamar WHERE tipe_kamar = '" + txt_TIpe.Text + "'", dgv_Kamar);
        }
    }
}
