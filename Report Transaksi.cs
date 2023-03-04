using MySql.Data.MySqlClient;
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
            dt_Tanggal.CustomFormat = "dd/MM/yyyy";
            dt_Tanggal2.CustomFormat = "dd/MM/yyyy";
        }

        Function func = new Function();
        public static string con = "Server=localhost;Database=hotel;user=root;Pwd= ;SslMode=none";
        MySqlConnection koneksi = new MySqlConnection(con);

        private void Report_Transaksi_Load(object sender, EventArgs e)
        {
            func.ReadData("SELECT tb_transaksi.nama_pelanggan Nama, detail_transaksi.checkin CheckIn, detail_transaksi.checkout CheckOut, tb_kamar.tipe_kamar Tipe, tb_kamar.harga_per_malam Harga, detail_transaksi.jumlah_kamar Jumlah_Kamar, detail_transaksi.harga Harga_Total, tb_transaksi.dibuat Tanggal FROM detail_transaksi JOIN tb_transaksi ON detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_kamar ON detail_transaksi.id_kamar = tb_kamar.id", dgv_Transaksi);
        }
 

        void SearchTanggal()
        {
            string query = "SELECT tb_transaksi.nama_pelanggan Nama, detail_transaksi.checkin CheckIn, detail_transaksi.checkout CheckOut, tb_kamar.tipe_kamar Tipe, tb_kamar.harga_per_malam Harga, detail_transaksi.jumlah_kamar Jumlah_Kamar, detail_transaksi.harga Harga_Total, tb_transaksi.dibuat Tanggal FROM detail_transaksi JOIN tb_transaksi ON detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_kamar ON detail_transaksi.id_kamar = tb_kamar.id WHERE tb_transaksi.dibuat BETWEEN @startDate AND @endDate";
            MySqlCommand command = new MySqlCommand(query, koneksi);
            command.Parameters.AddWithValue("@startDate", dt_Tanggal.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@endDate", dt_Tanggal2.Value.ToString("yyyy-MM-dd"));
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            dgv_Transaksi.DataSource = dataset.Tables[0];
        }
        void Search()
        {
            string query = "SELECT tb_transaksi.nama_pelanggan Nama, detail_transaksi.checkin CheckIn, detail_transaksi.checkout CheckOut, tb_kamar.tipe_kamar Tipe, tb_kamar.harga_per_malam Harga, detail_transaksi.jumlah_kamar Jumlah_Kamar, detail_transaksi.harga Harga_Total, tb_transaksi.dibuat Tanggal FROM detail_transaksi JOIN tb_transaksi ON detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_kamar ON detail_transaksi.id_kamar = tb_kamar.id WHERE tb_transaksi.dibuat BETWEEN @startDate AND @endDate AND tb_transaksi.nama_pelanggan Like '" + txt_Search.Text + "%'";
            MySqlCommand command = new MySqlCommand(query, koneksi);
            command.Parameters.AddWithValue("@startDate", dt_Tanggal.Value.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@endDate", dt_Tanggal2.Value.ToString("yyyy-MM-dd"));
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            dgv_Transaksi.DataSource = dataset.Tables[0];
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_Search.Text == string.Empty)
            {
                SearchTanggal();
            }
            else
            {
                Search();
            }
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        { 
            txt_Search.Text = string.Empty;
            func.ReadData("SELECT tb_transaksi.nama_pelanggan Nama, detail_transaksi.checkin CheckIn, detail_transaksi.checkout CheckOut, tb_kamar.tipe_kamar Tipe, tb_kamar.harga_per_malam Harga, detail_transaksi.jumlah_kamar Jumlah_Kamar, detail_transaksi.harga Harga_Total, tb_transaksi.dibuat Tanggal FROM detail_transaksi JOIN tb_transaksi ON detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_kamar ON detail_transaksi.id_kamar = tb_kamar.id", dgv_Transaksi);
        }
    }
}
