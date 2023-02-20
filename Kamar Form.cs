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

        new void Refresh()
        {
            txt_Tipe.Text = string.Empty;
            txt_Harga.Text = string.Empty;
            pb_Kamar.Image = null;
        }

        private void Kamar_Form_Load(object sender, EventArgs e)
        {
            func.ReadData("SELECT id No, tipe_kamar Tipe, harga_per_malam Harga, gambar Gambar FROM tb_kamar", dgv_Kamar);
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

                string newName = txt_Tipe.Text + ".png";
                txt_Gambar.Text = newName;
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
                    func.Command("INSERT INTO tb_kamar ('tipe_kamar', 'harga_per_malam', gambar) VALUES ('" + txt_Tipe.Text + "', '" + txt_Harga.Text + "', '" + txt_Gambar.Text + "')");
                    MessageBox.Show("DataBerhasil Ditambahkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Refresh();
                }
            }
        }

        private void dgv_Kamar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Kamar.Rows[e.RowIndex];
                txt_Id.Text = row.Cells[0].Value.ToString();
                txt_Tipe.Text = row.Cells[1].Value.ToString();
                txt_Harga.Text = row.Cells[2].Value.ToString();
                txt_Gambar.Text = row.Cells[3].Value.ToString();

                //taking image from the folder using its path
                string dir = Path.GetDirectoryName(Application.ExecutablePath);
                Image image = Image.FromFile(dir + "\\assets\\" + txt_Gambar.Text);
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
                    func.Command("UPDATE tb_kamar SET tipe_kamar = '" + txt_Tipe.Text + "', harga_per_malam = '" + txt_Harga.Text + "', gambar = '" + txt_Gambar.Text + "' WHERE id = '" + txt_Id.Text + "'");
                    MessageBox.Show("DataBerhasil Diubah", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Refresh();
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                func.Command("DELET FROM tb_kamar WHERE id = '" + txt_Id.Text + "'");
                
                //deleting image from folder
                string newlocation = Path.GetDirectoryName(Application.ExecutablePath) + "\\assetes\\" + txt_Gambar.Text + ".png";
                pb_Kamar.Image.Dispose();
                File.Delete(newlocation);
                MessageBox.Show("DataBerhasil Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Refresh();
            }
        }
    }
}
