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
            func.ReadData("SELECT id No, dibuat Tanggal, nama_pelanggan Nama, kode_transaksi ID, jumlah_kamar_dipesan Jumlah_Kamar, total_bayar Total FROM tb_transaksi", dgv_Transaksi);
            dgv_Transaksi.Columns[0].Visible = false;
        }

        private void dgv_Detail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Transaksi.Rows[e.RowIndex];
                txt_Id.Text = row.Cells[0].Value.ToString();
            }
        }

        void Search()
        {
            func.ReadData("SELECT tb_kamar.tipe_kamar TipeKamar, detail_transaksi.jumlah_kamar Jumlah, detail_transaksi.checkin CheckIn, detail_transaksi.checkout Checkout FROM detail_transaksi JOIN tb_kamar ON detail_transaksi.id_kamar = tb_kamar.id WHERE detail_transaksi.id_transaksi = '" + txt_Id.Text + "'", dgv_Transaksi);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_Search.Text == string.Empty)
            {
                MessageBox.Show("Mohon masukan kunci pencarian terlebih dahulu");
            }
            else
            {
                Search();
            }
        }
    }
}
