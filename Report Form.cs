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
    public partial class Report_Form : Form
    {
        public Report_Form()
        {
            InitializeComponent();
        }

        Function func = new Function();

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            string query = "SELECT SUM(`total_bayar`) AS `Total`, `dibuat` FROM tb_transaksi GROUP BY DATE_FORMAT(`dibuat`,'%M') ORDER BY FIELD( DATE_FORMAT(`dibuat`, '%M'), 'January', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December');";
            int count = func.GetData(query).Count;

            if (count > 0)
            {
                foreach (DataRow dr in func.GetData(query))
                {
                    chart_Report.Series[0].Points.AddXY(DateTime.Parse(dr["dibuat"].ToString()).ToString("MMM"), dr["Total"].ToString());
                }
            }

        }
    }
}
