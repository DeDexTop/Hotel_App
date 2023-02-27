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
    public partial class Report_Transaksi : Form
    {
        public Report_Transaksi()
        {
            InitializeComponent();
        }

        Function func = new Function();

        private void Report_Transaksi_Load(object sender, EventArgs e)
        {
            func.ReadData("SELECT dibuat Tanggal, nama_pelanggan Nama, kode_transaksi ID, jumlah_kamar_dipesan Jumlah_Kamar, total_bayar Total FROM tb_transaksi", dgv_Transaksi);
        }
    }
}
