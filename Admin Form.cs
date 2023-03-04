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
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
            label3.Text = "Selamat Datang Admin " + ClassData.nama;
        }

        Function func = new Function();
        private Button currentButton;
        private Form activateForm;

        public void OpenChildForm(Form childForm, Panel panel, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }

            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    Color color = Color.FromArgb(51, 51, 76);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = func.ChangeColorBrightness(color, -0.3);
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    panelLogo.BackColor = Color.Transparent;
                }
            }
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            buttonClose.Visible = false;
            panelMenu.Visible = false;
            btnOpen.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            btnOpen.Visible = true;
            panelMenu.Visible = false;
            buttonClose.Visible = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnOpen.Visible = false;
            panelMenu.Visible = true;
            buttonClose.Visible = true;
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Karyawan_Form(), panelDesktop, sender);
        }

        private void btnKamar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Kamar_Form(), panelDesktop, sender);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            new Form_Login().Show();
            this.Close();

            func.Command("INSERT INTO `log` (`id_user`, `activity`, `date`) VALUES ('" + ClassData.id_user + "', 'Logout', CURRENT_DATE())");
        }
    }
}
