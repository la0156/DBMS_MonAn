using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace GUI_MonAn
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TaiKhoan_BUS.GetTaiKhoan();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tkhoan= TaiKhoan_txt.Text;
                string matkhau = MatKhau_txt.Text;
                string hoten = HoTen_txt.Text;
                DateTime namsinh = ThoiGian.Value;
                string email = Email_txt.Text;
                string quyen = Quyen_txt.Text;
                TaiKhoan_DTO taikhoan = new TaiKhoan_DTO(tkhoan, matkhau, hoten, namsinh, email, quyen);
                TaiKhoan_BUS.InsertTK(taikhoan);
                MessageBox.Show("Bạn đã thêm thành công");
                dataGridView1.DataSource = TaiKhoan_BUS.GetTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string taikhoan = TaiKhoan_txt.Text;
                string matkhau = MatKhau_txt.Text;
                string hoten = HoTen_txt.Text;
                DateTime namsinh = ThoiGian.Value;
                string email = Email_txt.Text;
                string quyen = Quyen_txt.Text;
                TaiKhoan_DTO tk = new TaiKhoan_DTO(taikhoan, matkhau, hoten, namsinh, email, quyen);
                TaiKhoan_BUS.UpdateTK(tk);
                MessageBox.Show("Bạn đã sửa thành công");
                dataGridView1.DataSource = TaiKhoan_BUS.GetTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string tkhoan = TaiKhoan_txt.Text;
                string matkhau = MatKhau_txt.Text;
                string hoten = HoTen_txt.Text;
                DateTime namsinh = ThoiGian.Value;
                string email = Email_txt.Text;
                string quyen = Quyen_txt.Text;
                TaiKhoan_DTO taikhoan = new TaiKhoan_DTO(tkhoan, matkhau, hoten, namsinh, email, quyen);
                TaiKhoan_BUS.DeleteTK(tkhoan);
                MessageBox.Show("Bạn đã xoá thành công");
                dataGridView1.DataSource = TaiKhoan_BUS.GetTaiKhoan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            TaiKhoan_txt.Text = row.Cells[0].Value.ToString();
            MatKhau_txt.Text = row.Cells[1].Value.ToString();
            HoTen_txt.Text = row.Cells[2].Value.ToString();
            ThoiGian.Text = row.Cells[3].Value.ToString();
            Email_txt.Text = row.Cells[4].Value.ToString();
            Quyen_txt.Text = row.Cells[5].Value.ToString();
        }
    }
}
