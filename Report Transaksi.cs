using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hotel_App
{
    public partial class Report_Transaksi : Form
    {
        public Report_Transaksi()
        {
            InitializeComponent();
            dt_Tanggal.CustomFormat = "dd/MM/yyyy";
            dt_Tanggal2.CustomFormat = "dd/MM/yyyy";

            btn_Print.Click += new EventHandler(btn_Print_Click);
        }

        Function func = new Function();
        public static string con = "Server=localhost;Database=hotel;user=root;Pwd= ;SslMode=none";
        MySqlConnection koneksi = new MySqlConnection(con);

        private void Report_Transaksi_Load(object sender, EventArgs e)
        {
            func.ReadData("SELECT user.nama Kasir, tb_transaksi.nama_pelanggan Nama, detail_transaksi.checkin CheckIn, detail_transaksi.checkout CheckOut, tb_kamar.tipe_kamar Tipe, tb_kamar.harga_per_malam Harga, detail_transaksi.jumlah_kamar Jumlah_Kamar, detail_transaksi.harga Harga_Total, tb_transaksi.dibuat Tanggal FROM detail_transaksi JOIN tb_transaksi ON detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_kamar ON detail_transaksi.id_kamar = tb_kamar.id JOIN user ON tb_transaksi.id_user = user.id", dgv_Transaksi);
        }

        public string Harga()
        {
            int total = 0;
            for (int i = 0; i < dgv_Transaksi.Rows.Count; ++i)
            {
                total += Convert.ToInt32(dgv_Transaksi.Rows[i].Cells[6].Value);
            }
            return total.ToString();
        }


        void SearchTanggal()
        {
            string query = "SELECT user.nama Kasir,tb_transaksi.nama_pelanggan Nama, detail_transaksi.checkin CheckIn, detail_transaksi.checkout CheckOut, tb_kamar.tipe_kamar Tipe, tb_kamar.harga_per_malam Harga, detail_transaksi.jumlah_kamar Jumlah_Kamar, detail_transaksi.harga Harga_Total, tb_transaksi.dibuat Tanggal FROM detail_transaksi JOIN tb_transaksi ON detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_kamar ON detail_transaksi.id_kamar = tb_kamar.id JOIN user ON tb_transaksi.id_user = user.id WHERE tb_transaksi.dibuat BETWEEN @startDate AND @endDate";
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
            string query = "SELECT user.nama Kasir,tb_transaksi.nama_pelanggan Nama, detail_transaksi.checkin CheckIn, detail_transaksi.checkout CheckOut, tb_kamar.tipe_kamar Tipe, tb_kamar.harga_per_malam Harga, detail_transaksi.jumlah_kamar Jumlah_Kamar, detail_transaksi.harga Harga_Total, tb_transaksi.dibuat Tanggal FROM detail_transaksi JOIN tb_transaksi ON detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_kamar ON detail_transaksi.id_kamar = tb_kamar.id JOIN user ON tb_transaksi.id_user = user.id WHERE tb_transaksi.dibuat BETWEEN @startDate AND @endDate AND tb_transaksi.nama_pelanggan Like '" + txt_Search.Text + "%'";
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
            func.ReadData("SELECT user.nama Kasir, tb_transaksi.nama_pelanggan Nama, detail_transaksi.checkin CheckIn, detail_transaksi.checkout CheckOut, tb_kamar.tipe_kamar Tipe, tb_kamar.harga_per_malam Harga, detail_transaksi.jumlah_kamar Jumlah_Kamar, detail_transaksi.harga Harga_Total, tb_transaksi.dibuat Tanggal FROM detail_transaksi JOIN tb_transaksi ON detail_transaksi.id_transaksi = tb_transaksi.id JOIN tb_kamar ON detail_transaksi.id_kamar = tb_kamar.id JOIN user ON tb_transaksi.id_user = user.id", dgv_Transaksi);
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            // Membuat instance dari class Document iTextSharp
            Document doc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);

            iTextSharp.text.Font fontTitle = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);


            // Membuat objek paragraph dengan judul
            Paragraph title = new Paragraph("Laporan Transaksi", fontTitle);
            title.Alignment = Element.ALIGN_CENTER; // Mengatur perataan teks
            title.SpacingAfter = 40;
            title.SpacingBefore = 40;

            // Membuat objek Paragraph untuk menampung kalimat di bagian bawah tabel
            Paragraph p = new Paragraph("Total Pemasukan : Rp. " + Harga(), font);
            p.SpacingBefore = 30;

            // Menentukan lokasi penyimpanan file PDF
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF (*.pdf)|*.pdf";
            saveFileDialog1.FileName = "Data.pdf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Membuka file PDF
                PdfWriter.GetInstance(doc, new FileStream(saveFileDialog1.FileName, FileMode.Create));

                // Membuka dokumen
                doc.Open();

                // Membuat table dengan jumlah kolom sesuai dengan jumlah kolom di dalam DataGridView
                PdfPTable table = new PdfPTable(dgv_Transaksi.Columns.Count);

                // Menambahkan header ke dalam table
                for (int i = 0; i < dgv_Transaksi.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dgv_Transaksi.Columns[i].HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.Padding = 5;
                    cell.BorderWidth = 1;
                    table.AddCell(cell);
                }

                // Menambahkan data dari DataGridView ke dalam table
                for (int i = 0; i < dgv_Transaksi.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_Transaksi.Columns.Count; j++)
                    {
                        if (dgv_Transaksi[j, i].Value != null)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(dgv_Transaksi[j, i].Value.ToString()));
                            cell.Padding = 5;
                            cell.BorderWidth = 1;
                            table.AddCell(cell);
                        }
                    }
                }

                // Mengatur garis di sekitar tabel
                table.DefaultCell.BorderWidth = 0;
                table.DefaultCell.BorderColor = new iTextSharp.text.BaseColor(200, 200, 200);
                table.DefaultCell.Padding = 7;
                table.WidthPercentage = 100;

                // Menambahkan paragraph ke dokumen
                doc.Add(title);

                // Menambahkan table ke dalam dokumen
                doc.Add(table);

                // Menambahkan kalimat ke dokumen
                doc.Add(p);

                // Menutup dokumen dan writer
                doc.Close();
                MessageBox.Show("Data berhasil di-print ke dalam file PDF.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Membuka file PDF setelah disimpan
                Process.Start(saveFileDialog1.FileName);
            }
        }   
    }
}
