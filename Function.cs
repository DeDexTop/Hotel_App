using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace Hotel_App
{
    internal class Function
    { 
        public static string con = "Server=localhost;Database=hotel;user=root;Pwd= ;SslMode=none";

        MySqlConnection koneksi = new MySqlConnection(con);
        private Form activateForm;

        public object ShowData(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }

        public DataRowCollection GetData(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows;
        }

        public void Command(string query)
        {
            try
            {
                koneksi.Open();
                MySqlCommand com = new MySqlCommand(query, koneksi);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }
        public void ReadData(string query, DataGridView dgv)
        {
            try
            {
                if (koneksi.State == ConnectionState.Closed) koneksi.Open();
                MySqlCommand command = new MySqlCommand(query, koneksi);
                MySqlDataAdapter sda = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }

        }

        public void OpenChildForm(Form childForm, Panel panel, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        public Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
