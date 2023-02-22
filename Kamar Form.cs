﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_App
{
    public partial class Kamar_Form : Form
    {
        public Kamar_Form()
        {
            InitializeComponent();
        }

        Function func = new Function();
        string newName;

        new void Refresh()
        {
            txt_Tipe.Text = string.Empty;
            txt_Harga.Text = string.Empty;
            pb_Kamar.Image = null;
            Show();
        }

        new void Show()
        {
            func.ReadData("SELECT id No, tipe_kamar Tipe, harga_per_malam Harga, gambar Gambar FROM tb_kamar", dgv_Kamar);
        }

        private void Kamar_Form_Load(object sender, EventArgs e)
        {
            Show();
            dgv_Kamar.Columns[3].Visible = false;
        }


        private void btn_SearchImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {

                //inserting image to a folder
                string newlocation = Path.GetDirectoryName(Application.ExecutablePath) + "\\assets\\" + txt_Tipe.Text + ".png";
                string filename = opf.FileName;
                if (File.Exists(newlocation))
                {
                    pb_Kamar.Image.Dispose();
                }
                pb_Kamar.Image = Image.FromFile(opf.FileName);

                if (File.Exists(newlocation))
                {
                    File.Delete(newlocation);
                    File.Copy(filename, newlocation);
                }
                else
                {
                    File.Copy(filename, newlocation);
                }

                newName = txt_Tipe.Text + ".png";
                label_gambar.Text = newName;
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (txt_Tipe.Text == string.Empty || txt_Harga.Text == string.Empty)
            {
                MessageBox.Show("Semua Kolom Harus di Isi!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah data yang di masukan sudah benar?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    func.Command("INSERT INTO `tb_kamar` (`tipe_kamar`, `harga_per_malam`, `gambar`) VALUES ('" + txt_Tipe.Text + "', '" + txt_Harga.Text + "', '" + label_gambar.Text + "')");
                    func.Command("INSERT INTO `log` (`id_user`, `activity`) VALUES ('" + ClassData.id_user + "', 'input data kamar')");
                    MessageBox.Show("Data Berhasil Ditambahkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Refresh();
                }
            }
        }

        private void dgv_Kamar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Kamar.Rows[e.RowIndex];
                label_id.Text = row.Cells[0].Value.ToString();
                txt_Tipe.Text = row.Cells[1].Value.ToString();
                txt_Harga.Text = row.Cells[2].Value.ToString();
                label_gambar.Text = row.Cells[3].Value.ToString();

                //taking image from the folder using its path
                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                Image image = Image.FromFile(dir + "\\assets\\" + label_gambar.Text);
                pb_Kamar.Image = image;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Tipe.Text == string.Empty || txt_Harga.Text == string.Empty)
            {
                MessageBox.Show("Semua Kolom Harus di Isi!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah data yang di ubah sudah benar?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    func.Command("UPDATE tb_kamar SET tipe_kamar = '" + txt_Tipe.Text + "', harga_per_malam = '" + txt_Harga.Text + "', gambar = '" + label_gambar.Text + "' WHERE id = '" + Convert.ToInt32(label_id.Text) + "'");
                    func.Command("INSERT INTO `log` ('id_user', 'activity') VALUES ('" + ClassData.id_user + "', 'mengubah data kamar')");
                    MessageBox.Show("Data Berhasil Diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Refresh();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                func.Command("DELET FROM tb_kamar WHERE id = '" + Convert.ToInt32(label_id.Text) + "'");
                func.Command("INSERT INTO `log` (`id_user`, `activity`) VALUES ('" + ClassData.id_user + "', 'menghapus data kamar')");

                //deleting image from folder
                string newlocation = Path.GetDirectoryName(Application.ExecutablePath) + "\\assetes\\" + label_gambar.Text + ".png";
                pb_Kamar.Image.Dispose();
                File.Delete(newlocation);
                MessageBox.Show("Data Berhasil Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Refresh();
            }
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
