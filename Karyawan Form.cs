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
    public partial class Karyawan_Form : Form
    {
        public Karyawan_Form()
        {
            InitializeComponent();
        }

        Function func = new Function();

        new void Refresh()
        {
            txt_Nama.Clear();
            txt_Username.Clear();
            txt_Password.Clear();
            cbx_Role.Text= string.Empty;
            Show();
        }

        new void Show()
        {
            func.ReadData("SELECT id No, nama Nama, username Username, password Password, role Peran FROM user", dgv_Karyawan);
        }

        private void Karyawan_Form_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void dgv_Karyawan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Karyawan.Rows[e.RowIndex];
                label_Id.Text = row.Cells[0].Value.ToString();
                txt_Nama.Text = row.Cells[1].Value.ToString();
                txt_Username.Text = row.Cells[2].Value.ToString();
                txt_Password.Text = row.Cells[3].Value.ToString();
                cbx_Role.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if(txt_Nama.Text == string.Empty || txt_Username.Text == string.Empty || txt_Password.Text == string.Empty || cbx_Role.Text == string.Empty)
            {
                MessageBox.Show("Semua kolom data harus di isi");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah data yang di masukan sudah benar?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes) 
                {
                    func.Command("INSERT INTO user ('nama', 'username', 'password', 'role') VALUES ('" + txt_Nama.Text + "', '" + txt_Username.Text + "', '" + txt_Password.Text + "', '" + cbx_Role.Text + "')");
                    func.Command("INSERT INTO log ('id_user', 'activity') VALUES ('" + ClassData.id_user + "', 'input data karyawan')");

                    MessageBox.Show("Data Berhasil Ditambahkan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Refresh();
                }
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_Nama.Text == string.Empty || txt_Username.Text == string.Empty || txt_Password.Text == string.Empty || cbx_Role.Text == string.Empty)
            {
                MessageBox.Show("Semua kolom data harus di isi");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Apakah data yang di ubah sudah benar?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    func.Command("UPDATE user SET nama = '" + txt_Nama.Text + "', username = '" + txt_Username.Text + "', password = '" + txt_Password.Text + "', role = '" + cbx_Role.Text + "' WHERE id = '" + Convert.ToInt32(label_Id.Text) + "'");
                    func.Command("INSERT INTO log ('id_user', 'activity') VALUES ('" + ClassData.id_user + "', 'mengubah data karyawan')");

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
                func.Command("DELET FROM user WHERE id = '" + Convert.ToInt32(label_Id.Text) + "'");
                func.Command("INSERT INTO log ('id_user', 'activity') VALUES ('" + ClassData.id_user + "', 'menghapus data karyawan')");

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
