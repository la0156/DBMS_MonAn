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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NhanVien_BUS.GetNhanVien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idnhanvien = int.Parse(IdNV_txt.Text);
                string tennv = TenNV_txt.Text;
                string gioitinh = GioiTinh_txt.Text;
                DateTime namsinh = ThoiGian.Value;
                int sdt = int.Parse(SDT_txt.Text);
                string diachi = DiaChi_txt.Text;
                int cmnd = int.Parse(CMND_txt.Text);
                string email = Email_txt.Text;
                NhanVien_DTO nhanvien = new NhanVien_DTO(idnhanvien, tennv, gioitinh, namsinh, sdt, diachi, cmnd, email);
                NhanVien_BUS.InsertNV(nhanvien);
                MessageBox.Show("Bạn đã thêm thành công");
                dataGridView1.DataSource = NhanVien_BUS.GetNhanVien();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            IdNV_txt.Text = row.Cells[0].Value.ToString();
            TenNV_txt.Text = row.Cells[1].Value.ToString();
            GioiTinh_txt.Text = row.Cells[2].Value.ToString();
            ThoiGian.Text = row.Cells[3].Value.ToString();
            SDT_txt.Text = row.Cells[4].Value.ToString();
            DiaChi_txt.Text = row.Cells[5].Value.ToString();
            CMND_txt.Text = row.Cells[6].Value.ToString();
            Email_txt.Text = row.Cells[7].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idnhanvien = int.Parse(IdNV_txt.Text);
                string tennv = TenNV_txt.Text;
                string gioitinh = GioiTinh_txt.Text;
                DateTime namsinh = ThoiGian.Value;
                int sdt = int.Parse(SDT_txt.Text);
                string diachi = DiaChi_txt.Text;
                int cmnd = int.Parse(CMND_txt.Text);
                string email = Email_txt.Text;
                NhanVien_DTO nhanvien = new NhanVien_DTO(idnhanvien, tennv, gioitinh, namsinh, sdt, diachi, cmnd, email);
                NhanVien_BUS.UpdateNV(nhanvien);
                MessageBox.Show("Bạn đã sửa thành công");
                dataGridView1.DataSource = NhanVien_BUS.GetNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idnhanvien = int.Parse(IdNV_txt.Text);
                string tennv = TenNV_txt.Text;
                string gioitinh = GioiTinh_txt.Text;
                DateTime namsinh = ThoiGian.Value;
                int sdt = int.Parse(SDT_txt.Text);
                string diachi = DiaChi_txt.Text;
                int cmnd = int.Parse(CMND_txt.Text);
                string email = Email_txt.Text;
                NhanVien_DTO nhanvien = new NhanVien_DTO(idnhanvien, tennv, gioitinh, namsinh, sdt, diachi, cmnd, email);
                NhanVien_BUS.DeleteNV(idnhanvien);
                MessageBox.Show("Bạn đã xoá thành công");
                dataGridView1.DataSource = NhanVien_BUS.GetNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conn = dbConnectionData.HamKetNoi();
                Conn.Open();
                SqlDataAdapter command = new SqlDataAdapter("TimKiemNhanvien", Conn);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("@searchTen", TimKiemNV_txt.Text.Trim());            
                DataTable dt = new DataTable();
                command.Fill(dt);
                dataGridView1.DataSource = dt;
                Conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TimKiemNV_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conn = dbConnectionData.HamKetNoi();
                Conn.Open();
                SqlDataAdapter command = new SqlDataAdapter("TimKiemNhanvien", Conn);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("@searchTen", TimKiemNV_txt.Text.Trim());
                DataTable dt = new DataTable();
                command.Fill(dt);
                dataGridView1.DataSource = dt;
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
