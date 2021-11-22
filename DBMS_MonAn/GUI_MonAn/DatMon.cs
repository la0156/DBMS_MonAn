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
    public partial class DatMon : Form
    {
        public DatMon()
        {
            InitializeComponent();
        }     

        private void DatMon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatMon_BUS.GetDatMon();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int iddatmon = int.Parse(IDDM_txt.Text);
                int idkhachhang = int.Parse(IDKhachHang_txt.Text);
                int idnhanvien = int.Parse(IDNhanVien_txt.Text);
                int idmonan = int.Parse(IDMonAn_txt.Text);
                string tenkhachhang = TenKhachHang_txt.Text;
                int sdt = int.Parse(SDT_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                int soluong = int.Parse(SoLuong_txt.Text);
                float gia = float.Parse(Gia_txt.Text);
                float giamgia = float.Parse(GiamGia_txt.Text);
                ThanhToan_txt.Text = (gia * soluong - (gia * soluong * giamgia)).ToString();
                DatMon_DTO datmon = new DatMon_DTO(iddatmon, idkhachhang, idnhanvien, idmonan, tenkhachhang, sdt, tenmonan, soluong, gia, giamgia);
                DatMon_BUS.InsertDM(datmon);
                MessageBox.Show("Bạn đã thêm thành công");
                dataGridView1.DataSource = DatMon_BUS.GetDatMon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            IDDM_txt.Text = row.Cells[0].Value.ToString();
            IDKhachHang_txt.Text = row.Cells[1].Value.ToString();
            IDNhanVien_txt.Text = row.Cells[2].Value.ToString();
            IDMonAn_txt.Text = row.Cells[3].Value.ToString();
            TenKhachHang_txt.Text = row.Cells[4].Value.ToString();
            SDT_txt.Text = row.Cells[5].Value.ToString();
            TenMonAn_txt.Text = row.Cells[6].Value.ToString();
            SoLuong_txt.Text = row.Cells[7].Value.ToString();
            Gia_txt.Text = row.Cells[8].Value.ToString();
            GiamGia_txt.Text = row.Cells[9].Value.ToString();
            ThanhToan_txt.Text = row.Cells[10].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int iddatmon = int.Parse(IDDM_txt.Text);
                int idkhachhang = int.Parse(IDKhachHang_txt.Text);
                int idnhanvien = int.Parse(IDNhanVien_txt.Text);
                int idmonan = int.Parse(IDMonAn_txt.Text);
                string tenkhachhang = TenKhachHang_txt.Text;
                int sdt = int.Parse(SDT_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                int soluong = int.Parse(SoLuong_txt.Text);
                float gia = float.Parse(Gia_txt.Text);
                float giamgia = float.Parse(GiamGia_txt.Text);
                ThanhToan_txt.Text = (gia * soluong - (gia * soluong * giamgia)).ToString();
                DatMon_DTO datmon = new DatMon_DTO(iddatmon, idkhachhang, idnhanvien, idmonan, tenkhachhang, sdt, tenmonan, soluong, gia, giamgia);
                DatMon_BUS.UpdateDM(datmon);
                MessageBox.Show("Bạn đã sửa thành công");
                dataGridView1.DataSource = DatMon_BUS.GetDatMon();
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
                int iddatmon = int.Parse(IDDM_txt.Text);
                int idkhachhang = int.Parse(IDKhachHang_txt.Text);
                int idnhanvien = int.Parse(IDNhanVien_txt.Text);
                int idmonan = int.Parse(IDMonAn_txt.Text);
                string tenkhachhang = TenKhachHang_txt.Text;
                int sdt = int.Parse(SDT_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                int soluong = int.Parse(SoLuong_txt.Text);
                float gia = float.Parse(Gia_txt.Text);
                float giamgia = float.Parse(GiamGia_txt.Text);
                ThanhToan_txt.Text = (gia * soluong - (gia * soluong * giamgia)).ToString();
                DatMon_DTO datmon = new DatMon_DTO(iddatmon, idkhachhang, idnhanvien, idmonan, tenkhachhang, sdt, tenmonan, soluong, gia, giamgia);
                DatMon_BUS.DeleteDM(iddatmon);
                MessageBox.Show("Bạn đã xoá thành công");
                dataGridView1.DataSource = DatMon_BUS.GetDatMon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bill m = new Bill();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }
    }
}
