using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using BUS;


namespace GUI_MonAn
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhapLogin_btn_Click(object sender, EventArgs e)
        {
            string userName = DangNhap_txt.Text;
            string passWord = MatKhau_txt.Text;
            if (DangNhap_BUS.Login(userName, passWord))
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhanVien f = new NhanVien();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }       

        private void Huy_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_txt_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
