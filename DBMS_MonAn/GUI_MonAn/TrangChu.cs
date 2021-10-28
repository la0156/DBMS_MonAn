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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Thoat_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_btn_Click(object sender, EventArgs e)
        {            
            DangNhap a = new DangNhap();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void DangKi_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void DoiMK_btn_Click(object sender, EventArgs e)
        {
            DoiMatKhau c = new DoiMatKhau();
            this.Hide();
            c.ShowDialog();
            this.Show();
        }
    }
}
