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
    public partial class Log_Form : Form
    {
        Function func = new Function();
        public Log_Form()
        {
            InitializeComponent();
        }

        private void Log_Form_Load(object sender, EventArgs e)
        { 
            func.ReadData("SELECT log.id No, user.nama Nama, log.activity Aktifitas, log.date Tanggal FROM user JOIN log ON log.id_user = user.id ORDER by log.id DESC", dgv_Log);
            dgv_Log.Columns[0].Visible = false;
        }
    }
}
