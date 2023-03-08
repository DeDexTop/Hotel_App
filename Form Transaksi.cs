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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Xml.Linq;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Utilities.Collections;
using MySql.Data.MySqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hotel_App
{
    public partial class Form_Transaksi : Form
    {
        public Form_Transaksi()
        {
            InitializeComponent();
            dt_Checkin.CustomFormat = "yyyy-MM-dd";
        }
        Function func = new Function();
        public string query;
        public string gambar;
        public int id;
        public int harga;
        public int total;
        public string id_transaksi;
        public int id_kamar;
        public DateTime date;
        public int kembali;
        public string kode;
        public bool checkBtn1 = false;
        public bool checkBtn2 = false;

        MySqlConnection koneksi = new MySqlConnection("Server=localhost;Database=hotel;user=root;Pwd= ;SslMode=none");
        MySqlCommand cmd;

        new void Refresh()
        {
            txt_Nama.Text = string.Empty;
            txt_Jumlah.Text = string.Empty;
            txt_Hari.Text = string.Empty;
            pb_Gambar.Image = null;
            cbx_Tipe.Text = string.Empty;
            dgv_Kamar.Rows.Clear();
            label_Total.Text = "Total:";
            label_Kembalian.Text = "Kembalian:";
        }

        public string Incrementid()
        {
            DataRowCollection col = func.GetData("SELECT id FROM tb_transaksi");
            return col.Count.ToString("D4");
        }

        string generateId()
        {
            string date = DateTime.Now.ToString("yyyyMMdd" + Incrementid());
            return date;
        }

        void LabelHarga()
        {
            int total = 0;
            for (int i = 0; i < dgv_Kamar.Rows.Count; ++i)
            {
                total += Convert.ToInt32(dgv_Kamar.Rows[i].Cells[6].Value);
                label_Total.Text = "Total: " + total.ToString();
            }
        }

        public string Harga()
        {
            int total = 0;
            for (int i = 0; i < dgv_Kamar.Rows.Count; ++i)
            {
                total += Convert.ToInt32(dgv_Kamar.Rows[i].Cells[6].Value);
            }
            return total.ToString();
        }

        public string Jumlah()
        {
            int jumlah = 0;
            for (int i = 0; i < dgv_Kamar.Rows.Count; ++i)
            {
                jumlah += Convert.ToInt32(dgv_Kamar.Rows[i].Cells[3].Value);
            }
            return jumlah.ToString();
        }

        private void Form_Transaksi_Load(object sender, EventArgs e)
        {
            DataRowCollection col = func.GetData("SELECT * FROM tb_kamar");
            foreach (DataRow dr in col)
            {
                cbx_Tipe.Items.Add(dr["tipe_kamar"]);
            }
        }

        private void cbx_Tipe_TextChanged(object sender, EventArgs e)
        {
            string Query = "SELECT gambar FROM tb_kamar WHERE tipe_kamar = '" + cbx_Tipe.Text + "'";
            int count = func.GetData(Query).Count;

            if (count > 0)
            {
                DataRowCollection col = func.GetData(Query);
                foreach (DataRow dr in col)
                {
                    gambar = dr["gambar"].ToString();
                }

                Console.WriteLine(gambar);

                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                Image image = Image.FromFile(dir + "\\assets\\" + gambar);
                pb_Gambar.Image = image;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (cbx_Tipe.Text == string.Empty || txt_Jumlah.Text == string.Empty || txt_Hari.Text == string.Empty)
            {
                MessageBox.Show("Pilih tipe kamar, jumlah kamar, dan jumlah hari terlebih dahulu!");
            }


            else
            {
                DataRowCollection col = func.GetData("SELECT harga_per_malam, id FROM tb_kamar WHERE tipe_kamar = '" + cbx_Tipe.Text + "'");
                foreach (DataRow dr in col)
                {
                    harga = Convert.ToInt32(dr["harga_per_malam"]);
                    id_kamar = Convert.ToInt32(dr["id"]);
                }

                total = harga * Convert.ToInt32(txt_Jumlah.Text) * Convert.ToInt32(txt_Hari.Text);

                bool found = false;
                if (dgv_Kamar.Rows.Count >= 0)
                {
                    if (!found)
                    {
                        dgv_Kamar.Rows.Add(id_kamar, cbx_Tipe.Text, harga.ToString(), txt_Jumlah.Text, dt_Checkin.Value.ToString(), txt_Hari.Text, total);

                        LabelHarga();
                    }
                }
                else
                {
                    dgv_Kamar.Rows.Add(id_kamar, cbx_Tipe.Text, harga.ToString(), txt_Jumlah.Text, dt_Checkin.Value.ToString(), txt_Hari.Text, total);

                    LabelHarga();
                }

                txt_Hari.Text = string.Empty;
                txt_Jumlah.Text = string.Empty;
                cbx_Tipe.SelectedItem = null;
                pb_Gambar.Image = null;
            }

        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            if(checkBtn1 == false)
            {
                MessageBox.Show("Mohon selesaikan pembayaran terlabih dahulu");
            }
            else
            {
                kode = generateId();


                if (txt_Nama.Text == string.Empty)
                {
                    MessageBox.Show("Harap semua kolom telah di isi!");
                }
                else
                {
                    func.Command("INSERT INTO `tb_transaksi` (`id_user`, `nama_pelanggan`, `kode_transaksi`, `jumlah_kamar_dipesan`, `total_bayar`, `dibuat`) VALUES ('" + ClassData.id_user + "', '" + txt_Nama.Text + "', '" + kode + "', '" + Jumlah() + "', '" + Harga() + "', CURRENT_DATE())");


                    DataRowCollection col = func.GetData("SELECT id FROM tb_transaksi WHERE nama_pelanggan = '" + txt_Nama.Text + "'");
                    foreach (DataRow dr in col)
                    {
                        id_transaksi = dr["id"].ToString();
                    }

                    var date = dt_Checkin.Value;

                    for (int i = 0; i < dgv_Kamar.Rows.Count - 1; i++)
                    {
                        if (koneksi.State == ConnectionState.Closed) koneksi.Open();
                        cmd = new MySqlCommand("INSERT INTO `detail_transaksi` (`id_transaksi`, `id_kamar`, `jumlah_kamar`, `checkin`, `checkout`, `harga`, `dibuat`) VALUES (@id_transaksi, @id_kamar, @jumlah, @date1, @date2, @harga, CURRENT_DATE())", koneksi);
                        cmd.Parameters.Add("@date1", MySqlDbType.Date).Value = date;
                        cmd.Parameters.Add("@date2", MySqlDbType.Date).Value = date.AddDays(Convert.ToInt64(dgv_Kamar.Rows[i].Cells[5].Value));
                        cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi);
                        cmd.Parameters.AddWithValue("@id_kamar", dgv_Kamar.Rows[i].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@jumlah", dgv_Kamar.Rows[i].Cells[3].Value);
                        cmd.Parameters.AddWithValue("@harga", dgv_Kamar.Rows[i].Cells[6].Value);

                        cmd.ExecuteNonQuery();
                    }

                    func.Command("INSERT INTO `log`(`id_user`, `activity`, `date`) VALUES ('" + ClassData.id_user + "', 'input data transaksi', CURRENT_DATE())");

                    MessageBox.Show("Transaksi berhasil di simpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Refresh();

                    checkBtn2 = true;
                }
            }
        }

        private void btn_Bayar_Click(object sender, EventArgs e)
        {
            if (txt_Uang.Text == string.Empty)
            {
                MessageBox.Show("Kolom data tida boleh kosong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int uang = Convert.ToInt32(txt_Uang.Text);
                int total = Convert.ToInt32(Harga());
                if (uang < total)
                {
                    MessageBox.Show("Uang yang di masukan kurang");
                }
                else
                {
                    kembali = uang - total;
                }

                label_Kembalian.Text = "Kembalian: " + kembali.ToString();
                checkBtn1 = true;
            }
        }

        private void btn_Buang_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Kamar.SelectedRows)
            {
                dgv_Kamar.Rows.RemoveAt(row.Index);

                LabelHarga();
            }
        }

        private void txt_Uang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int uang = Convert.ToInt32(txt_Uang.Text);
                int total = Convert.ToInt32(Harga());

                if (txt_Uang.Text == string.Empty)
                {
                    MessageBox.Show("Kolom data tida boleh kosong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (uang < total)
                    {
                        MessageBox.Show("Uang yang di masukan kurang");
                    }
                    else
                    {
                        kembali = uang - total;
                    }

                    label_Kembalian.Text = "Kembalian: " + kembali.ToString();
                    
                    checkBtn1 = true;
                }
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            if(checkBtn2 == false)
            {
                MessageBox.Show("Mohon simpan data terlebih dahulu");
            }

            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                //printDocument1.PrinterSettings.DefaultPageSettings.Landscape = false;
                //printDocument1.Print();
            }
        }

        public string nama;
        public string total_harga;
        public string ID;
        public string[] tipe_kamar;
        public string[] harga_per_malam;
        public string[] jumlah_kamar;
        public string[] checkin;
        public string[] checkout;
        public string[] harga_bayar;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var font = new Font("Khmer UI", 12);
            var heading = new Font("khmer UI", 20, FontStyle.Bold);
            string query1 = "SELECT id, nama_pelanggan, jumlah_kamar_dipesan, total_bayar FROM tb_transaksi WHERE kode_transaksi = '" + kode + "'";
            string query2 = "SELECT tb_kamar.tipe_kamar, tb_kamar.harga_per_malam, detail_transaksi.jumlah_kamar, detail_transaksi.checkin, detail_transaksi.checkout, detail_transaksi.harga FROM tb_kamar JOIN detail_transaksi ON detail_transaksi.id_kamar = tb_kamar.id WHERE detail_transaksi.id_transaksi = '" + id_transaksi + "'";

            int count = func.GetData(query2).Count;


            foreach (DataRow item in func.GetData(query1))
            {
                nama = item["nama_pelanggan"].ToString();
                total_harga = item["total_bayar"].ToString();
                ID = item["id"].ToString();
            }
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            List<string> list4 = new List<string>();
            List<string> list5 = new List<string>();
            List<string> list6 = new List<string>();
            for (int i = 0; i < count; i++)
            {
                foreach (DataRow dr in func.GetData(query2))
                { 
                    list1.Add(dr["tipe_kamar"].ToString());
                    list2.Add(dr["harga_per_malam"].ToString());
                    list3.Add(dr["jumlah_kamar"].ToString());
                    list4.Add(dr["checkin"].ToString());
                    list5.Add(dr["checkout"].ToString());
                    list6.Add(dr["harga"].ToString());
                }
            }

            tipe_kamar = list1.ToArray();
            harga_per_malam = list2.ToArray();
            jumlah_kamar = list3.ToArray();
            checkin = list4.ToArray();
            checkout = list5.ToArray();
            harga_bayar = list6.ToArray();

            e.Graphics.DrawString(" Hotel Nesas ", heading, Brushes.Black, 350, 10);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", font, Brushes.Black, 130, 30);
            e.Graphics.DrawString("Pelanggan      : \t" + nama + " ", font, Brushes.Black, 130, 80);
            e.Graphics.DrawString("Tanggal        : \t" + DateTime.Now.ToShortDateString() + "", font, Brushes.Black, 130, 110);
            e.Graphics.DrawString("Kode Transaksi : \t" + kode + " ", font, Brushes.Black, 130,  140);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", font, Brushes.Black, 130, 180);
            int x = 0;
            int x1 = 210;
            int x2 = 240;
            int x3 = 270;
            for (int i = 0; i < count; i ++)
            {

                x = x3;
                e.Graphics.DrawString("Tipe Kamar : " + tipe_kamar[i] + "  |  Harga / Malam: " + harga_per_malam[i] + "", font, Brushes.Black, 130, x1);
                e.Graphics.DrawString("" + harga_per_malam[i] + " x " + jumlah_kamar[i] + " \t =  Rp. " + harga_bayar[i] + "", font, Brushes.Black, 130, x2);
                e.Graphics.DrawString("Check In : " + checkin[i] + "   |   Check Out : " + checkout[i] + "", font, Brushes.Black, 130, x3);
                x1 = x3 + 30;
                x2 = x1 + 30;
                x3 = x2 + 30;
            }
           
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", font, Brushes.Black, 130, x + 30);
            e.Graphics.DrawString("Uang Masuk   : \t Rp. " + txt_Uang.Text + "", font, Brushes.Black, 130, x + 60);
            e.Graphics.DrawString("Total Harga  : \t Rp. " + total_harga + "", font, Brushes.Black, 130, x + 90);
            e.Graphics.DrawString("__________________________________ -", font, Brushes.Black, 130, x + 120);
            e.Graphics.DrawString("Kembalian    : \t Rp. " + kembali + " ", font, Brushes.Black, 130, x + 150);
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", font, Brushes.Black, 130, x + 180);
            e.Graphics.DrawString("Terima Kasih Atas Kunjungan Anda", font, Brushes.Black, 320, x + 220);

            id_transaksi = string.Empty;
            txt_Uang.Text = string.Empty;
        }

        private void txt_Jumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Hari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Uang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
