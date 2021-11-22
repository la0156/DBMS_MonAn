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
using DAL;
using System.Security.Cryptography;

namespace GUI_MonAn
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static string quyen;
        private void DangNhapLogin_btn_Click(object sender, EventArgs e)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes("@matkhau");
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach(byte item in hasData)
            {
                hasPass += item;
            }

            SqlConnection Conn = dbConnectionData.HamKetNoi();
            Conn.Open();
            SqlCommand cmd = new SqlCommand("USP_Login", Conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@taikhoan", DangNhap_txt.Text);
            cmd.Parameters.AddWithValue("@matkhau", MatKhau_txt.Text);
            var da = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(da);
            da.Dispose();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                quyen = dt.Rows[0][0].ToString().Trim();
                QuanLy f = new QuanLy();
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

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
