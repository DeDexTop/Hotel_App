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

        MySqlConnection koneksi = new MySqlConnection("Server=localhost;Database=hotel;user=root;Pwd= ;SslMode=none");
        MySqlCommand cmd;

        new void Refresh()
        {
            txt_Nama.Text = string.Empty;
            txt_Jumlah.Text = string.Empty;
            txt_Hari.Text = string.Empty;
            txt_Uang.Text = string.Empty;
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
            foreach(DataRow dr in col)
            {
                cbx_Tipe.Items.Add(dr["tipe_kamar"]);
            }
        }

        private void cbx_Tipe_TextChanged(object sender, EventArgs e)
        {
            string Query = "SELECT gambar FROM tb_kamar WHERE tipe_kamar = '" + cbx_Tipe.Text + "'";
            int count = func.GetData(Query).Count;

            if(count > 0)
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

            DataRowCollection col = func.GetData("SELECT harga_per_malam, id FROM tb_kamar WHERE tipe_kamar = '" + cbx_Tipe.Text + "'");
            foreach (DataRow dr in col)
            {
                harga = Convert.ToInt32(dr["harga_per_malam"]);
                id_kamar = Convert.ToInt32(dr["id"]);
            }

            total = harga * Convert.ToInt32(txt_Jumlah.Text) * Convert.ToInt32(txt_Hari.Text);

            if (cbx_Tipe.Text == string.Empty || txt_Jumlah.Text == string.Empty || txt_Hari.Text == string.Empty)
            {
                MessageBox.Show("Pilih tipe kamar, jumlah kamar, dan jumlah hari terlebih dahulu!");
            }
            else
            {
                bool found = false;
                if (dgv_Kamar.Rows.Count >= 0)
                {
                    foreach (DataGridViewRow row in dgv_Kamar.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == cbx_Tipe.Text)
                        {
                            row.Cells[3].Value = Convert.ToString(Convert.ToInt32(txt_Jumlah.Text) + Convert.ToInt32(row.Cells[3].Value));
                            row.Cells[5].Value = Convert.ToString(Convert.ToInt32(row.Cells[5].Value) + Convert.ToInt32(txt_Hari.Text));
                            row.Cells[6].Value = Convert.ToString(Convert.ToInt32(row.Cells[6].Value) + total);
                            found = true;
                        }
                    }
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
            }
        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            string id = generateId();


            if(txt_Nama.Text == string.Empty)
            {
                MessageBox.Show("Harap semua kolom telah di isi!");
            }
            else
            {
                func.Command("INSERT INTO `tb_transaksi` (`id_user`, `nama_pelanggan`, `kode_transaksi`, `jumlah_kamar_dipesan`, `total_bayar`) VALUES ('" + ClassData.id_user + "', '" + txt_Nama.Text + "', '" + id + "', '" + Jumlah() + "', '" + Harga() + "')");


                DataRowCollection col = func.GetData("SELECT id FROM tb_transaksi WHERE nama_pelanggan = '" + txt_Nama.Text + "'");
                foreach(DataRow dr in col)
                {
                    id_transaksi = dr["id"].ToString();
                }

                var date = dt_Checkin.Value;

                for (int i = 0; i < dgv_Kamar.Rows.Count-1; i++)
                {
                    koneksi.Open();
                    cmd = new MySqlCommand("INSERT INTO `detail_transaksi` (`id_transaksi`, `id_kamar`, `jumlah_kamar`, `checkin`, `checkout`, `harga`) VALUES (@id_transaksi, @id_kamar, @jumlah, @date1, @date2, @harga)", koneksi);
                    cmd.Parameters.Add("@date1", MySqlDbType.Date).Value = date;
                    cmd.Parameters.Add("@date2", MySqlDbType.Date).Value = date.AddDays(Convert.ToInt64(dgv_Kamar.Rows[i].Cells[5].Value));
                    cmd.Parameters.AddWithValue("@id_transaksi", id_transaksi);
                    cmd.Parameters.AddWithValue("@id_kamar", id_kamar);
                    cmd.Parameters.AddWithValue("@jumlah", dgv_Kamar.Rows[i].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@harga", dgv_Kamar.Rows[i].Cells[6].Value);

                    cmd.ExecuteNonQuery();
                }

                func.Command("INSERT INTO `log`(`id_user`, `activity`) VALUES ('" + ClassData.id_user + "', 'input data transaksi')");

                MessageBox.Show("Transaksi berhasil di simpan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Refresh();
            }
        }

        private void cbx_Tipe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
