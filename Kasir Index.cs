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
            label1.Text = "Selamat Datang " + ClassData.nama;
        }
        Function func = new Function();

        private void Kasir_Index_Load(object sender, EventArgs e)
        {
            func.ReadData("SELECT id No, nama_pelanggan Nama, kode_transaksi Kode, jumlah_kamar_dipesan JumlahKamar, total_bayar Tagihan FROM tb_transaksi", dgv_transaksi);
            dgv_transaksi.Columns[0].Visible = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_Search.Text == string.Empty)
            {
                MessageBox.Show("Mohon masukan kunci pencatian terlebih dahulu");
            }
            else
            {
                func.ReadData("SELECT id No, nama_pelanggan Nama, kode_transaksi Kode, jumlah_kamar_dipesan JumlahKamar, total_bayar Tagihan FROM tb_transaksi WHERE nama_pelanggan LIKE '" + txt_Search.Text + "'", dgv_transaksi);
                dgv_transaksi.Columns[0].Visible = false;
            }
        }

        private void dgv_transaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_transaksi.Rows[e.RowIndex];
                txt_Id.Text = row.Cells[0].Value.ToString();
            }

            func.ReadData("SELECT tb_kamar.tipe_kamar TipeKamar, detail_transaksi.jumlah_kamar Jumlah, detail_transaksi.checkin CheckIn, detail_transaksi.checkout Checkout FROM detail_transaksi JOIN tb_kamar ON detail_transaksi.id_kamar = tb_kamar.id WHERE detail_transaksi.id_transaksi = '" + txt_Id.Text + "'", dgv_Detail);
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            func.ReadData("SELECT id No, nama_pelanggan Nama, kode_transaksi Kode, jumlah_kamar_dipesan JumlahKamar, total_bayar Tagihan FROM tb_transaksi", dgv_transaksi);
            dgv_transaksi.Columns[0].Visible = false;
            dgv_Detail.DataSource = null;
            txt_Search.Text = string.Empty;
            txt_Id.Text = string.Empty;
        }
    }
}
