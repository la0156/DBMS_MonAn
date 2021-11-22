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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void Huy_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        int number = 0;
        private void loadCaptchaImage()
        {
            Random r1 = new Random();
            number = r1.Next(100, 1000);
            var image = new Bitmap(this.pictureBox2.Width, this.pictureBox2.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(number.ToString(), font, Brushes.Green, new Point(0, 0));
            pictureBox2.Image = image;
        }

        private void XacNhan_btn_Click(object sender, EventArgs e)
        {
            if (captra_txt.Text == number.ToString())
            {
                MessageBox.Show("Mã xác nhận đúng");
                SqlConnection Conn = dbConnectionData.HamKetNoi();
                SqlDataAdapter da = new SqlDataAdapter("select count (*) from TKhoan where TaiKhoan = N'" + TaiKhoanCP_txt.Text + "' and MatKhau = N'" + MatKhauCu_txt.Text + "'", Conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                errorProvider1.Clear();
                if (dt.Rows[0][0].ToString() == "1")
                {
                    if (MatKhauMoi_txt.Text == NhapLaiMatKhauCP_txt.Text)
                    {
                        if (MatKhauMoi_txt.Text.Length > 6)
                        {
                            SqlConnection Conn1 = dbConnectionData.HamKetNoi();
                            SqlCommand cmd = new SqlCommand("ChangePassword", Conn1);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@taikhoan", TaiKhoanCP_txt.Text.Trim());
                            cmd.Parameters.AddWithValue("@matkhaucu", MatKhauCu_txt.Text.Trim());
                            cmd.Parameters.AddWithValue("@matkhaumoi", MatKhauMoi_txt.Text.Trim());
                            Conn1.Open();
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                            Conn1.Close();
                            MessageBox.Show("Đồi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            errorProvider1.SetError(MatKhauMoi_txt, "Độ dài không đúng");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(MatKhauCu_txt, "Bạn chưa nhập mật khẩu");
                        errorProvider1.SetError(MatKhauMoi_txt, "Mật khẩu mới nhập chưa đúng");
                    }
                }
                else
                {
                    errorProvider1.SetError(TaiKhoanCP_txt, "Tên tài khoản không đúng");
                    errorProvider1.SetError(MatKhauCu_txt, "Mật khẩu cũ không đúng");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng captra");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadCaptchaImage();
        }
    }
}
