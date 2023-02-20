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

        private void Karyawan_Form_Load(object sender, EventArgs e)
        {
            func.ReadData("SELECT nama Nama, username Username, role Peran, password Password FROM user", dgv_Karyawan);
        }

        private void dgv_Karyawan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Karyawan.Rows[e.RowIndex];
                txt_Nama.Text = row.Cells[0].Value.ToString();
                txt_Username.Text = row.Cells[1].Value.ToString();
                txt_Password.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
