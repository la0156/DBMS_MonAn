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
using DAL;


namespace GUI_MonAn
{
    public partial class DanhGia : Form
    {
        public DanhGia()
        {
            InitializeComponent();
        }

        private void KetQua_btn_Click_1(object sender, EventArgs e)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            string s = "select dbo.GiaMonAn(@tenmonan)";
            SqlCommand cmd = new SqlCommand(s, Conn);
            cmd.Parameters.AddWithValue("@tenmonan", TenMonAn_txt.Text.Trim());
            cmd.CommandType = CommandType.Text;
            Conn.Open();
            Gia_txt.Text = cmd.ExecuteScalar().ToString();

            SqlConnection Conn1 = dbConnectionData.HamKetNoi();
            string s1 = "select dbo.MaxDiem(@tendanhgia)";
            SqlCommand cmd1 = new SqlCommand(s1, Conn1);
            cmd1.Parameters.AddWithValue("@tendanhgia", NguoiDanhGia_txt.Text.Trim());
            cmd1.CommandType = CommandType.Text;
            Conn1.Open();
            Diem_txt.Text = cmd1.ExecuteScalar().ToString();

            SqlConnection Conn2 = dbConnectionData.HamKetNoi();
            string s3 = "select dbo.TongTienKhach(@tenkhachhang)";
            SqlCommand cmd2 = new SqlCommand(s3, Conn2);
            cmd2.Parameters.AddWithValue("@tenkhachhang", TenKhachHang_txt.Text.Trim());
            cmd2.CommandType = CommandType.Text;
            Conn2.Open();
            ThanhTien_txt.Text = cmd2.ExecuteScalar().ToString();

            try
            {
                SqlConnection Conn3 = dbConnectionData.HamKetNoi();
                Conn3.Open();
                SqlDataAdapter command = new SqlDataAdapter("SELECT * FROM dbo.NhanVienCham(@idnhanvien)", Conn3);
                command.SelectCommand.Parameters.AddWithValue("@idnhanvien", NhanVienCham_txt.Text.Trim());
                DataTable dt = new DataTable();
                command.Fill(dt);
                bunifuDataGridView1.DataSource = dt;
                Conn3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                SqlConnection Conn4 = dbConnectionData.HamKetNoi();
                Conn4.Open();
                SqlDataAdapter command1 = new SqlDataAdapter("SELECT * FROM dbo.XemCongThucMonAn(@idcongthuc)", Conn4);
                command1.SelectCommand.Parameters.AddWithValue("@idcongthuc", CongThucMonAn_txt.Text.Trim());
                DataTable dt1 = new DataTable();
                command1.Fill(dt1);
                bunifuDataGridView2.DataSource = dt1;
                Conn4.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                SqlConnection Conn5 = dbConnectionData.HamKetNoi();
                Conn5.Open();
                SqlDataAdapter command2 = new SqlDataAdapter("SELECT * FROM dbo.XuatSuMonAn(@idmonan)", Conn5);
                command2.SelectCommand.Parameters.AddWithValue("@idmonan", XuatSu_txt.Text.Trim());
                DataTable dt2 = new DataTable();
                command2.Fill(dt2);
                bunifuDataGridView3.DataSource = dt2;
                Conn5.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
