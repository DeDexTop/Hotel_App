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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        Function func = new Function();

        void login()
        {
            string query = "SELECT id, nama, role FROM user WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";

            int count = func.GetData(query).Count;

            try
            {
                if (count > 0)
                {
                    foreach (DataRow dr in func.GetData(query))
                    {
                        ClassData.id_user = Convert.ToInt32(dr["id"]);
                        ClassData.nama = dr["nama"].ToString();

                        if (dr["role"].ToString().Equals("admin"))
                        {
                            new Admin_Form().Show();
                            this.Hide();
                            func.Command("INSERT INTO log (`id_user`, `activity`) VALUES ('" + ClassData.id_user + "','Login')");
                        }
                        else if (dr["role"].ToString().Equals("owner"))
                        {
                            new Owner_Form().Show();
                            this.Hide();
                            func.Command("INSERT INTO log (`id_user`, `activity`) VALUES ('" + ClassData.id_user + "','Login')");
                        }
                        else if (dr["role"].ToString().Equals("kasir"))
                        {
                            new Kasir_Form().Show();
                            this.Hide();
                            func.Command("INSERT INTO log (`id_user`, `activity`) VALUES ('" + ClassData.id_user + "','Login')");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Maaf Data Tidak Valid");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Show.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == string.Empty || txtUsername.Text == string.Empty)
            {
                MessageBox.Show("Semua kolom harap di isi");
            }
            else
            {
                login();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
                {
                    MessageBox.Show("Kolom data tida boleh kosong", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    login();
                }
            }
        }
    }
}
