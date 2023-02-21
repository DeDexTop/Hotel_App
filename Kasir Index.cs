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
    public partial class Kasir_Index : Form
    {
        public Kasir_Index()
        {
            InitializeComponent();
            label2.Text = "SElamat Datang " + ClassData.nama;
        }
        Function func = new Function();

        private void Kasir_Index_Load(object sender, EventArgs e)
        {
            func.ReadData("SELECT id No, nama_pelanggan Nama, kode_transaksi Kode, jumlah_kamar_dipesan, JumlahKamar, total_nayar Tagihan FROM tb_transaksi", dgv_transaksi);
        }
    }
}
