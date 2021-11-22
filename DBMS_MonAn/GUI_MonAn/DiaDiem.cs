using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MonAn
{
    public partial class DiaDiem : Form
    {
        public DiaDiem()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void Duong_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiaDiem_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string street = Duong_txt.Text;
            string quan = Quan_txt.Text;
            string city = ThanhPho_txt.Text;
            string monan = DiaDiem_txt.Text;
            try
            {
                StringBuilder query = new StringBuilder();
                query.Append("https://www.google.com/maps?q=");
                if (street != string.Empty)
                {
                    query.Append(street + "," + "+");
                }
                if (quan != string.Empty)
                {
                    query.Append(quan + "," + "+");
                }
                if (city != string.Empty)
                {
                    query.Append(city + "," + "+");
                }
                if (monan != string.Empty)
                {
                    query.Append(monan + "," + "+");
                }
                webBrowser1.ScriptErrorsSuppressed = true;
                webBrowser1.Navigate(query.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Lỗi");
            }
        }
    }
}
