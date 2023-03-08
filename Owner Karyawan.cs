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
    public partial class Owner_Karyawan : Form
    {
        public Owner_Karyawan()
        {
            InitializeComponent();
        }

        Function func = new Function();

        private void Owner_Karyawan_Load(object sender, EventArgs e)
        {
            func.ReadData("SELECT nama Nama, username Username, password Password, role Peran, dibuat Tanggal_Pembuatan FROM user", dgv_Karyawan);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            func.ReadData("SELECT nama Nama, username Username, password Password, role Peran, dibuat Tanggal_Pembuatan FROM user WHERE nama = '" + txt_Nama.Text + "'", dgv_Karyawan);
        }

        private void btn_Batal_Click(object sender, EventArgs e)
        {
            func.ReadData("SELECT nama Nama, username Username, password Password, role Peran, dibuat Tanggal_Pembuatan FROM user", dgv_Karyawan);
            txt_Nama.Text = string.Empty;
        }
    }
}
