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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        private void bunifuGroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idkhachhang = int.Parse(IdKH_txt.Text);
                string tenkh = TenKH_txt.Text;
                int sdt = int.Parse(SDTKH_txt.Text);
                int cmnd = int.Parse(CMNDKH_txt.Text);
                string email = EmailKH_txt.Text;
                KhachHang_DTO khachhang = new KhachHang_DTO(idkhachhang, tenkh, sdt, cmnd, email);
                KhachHang_BUS.UpdateKH(khachhang);
                MessageBox.Show("Bạn đã sửa thành công");
                dataGridView1.DataSource = KhachHang_BUS.GetKhachHang();
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
                int idkhachhang = int.Parse(IdKH_txt.Text);
                string tenkh = TenKH_txt.Text;
                int sdt = int.Parse(SDTKH_txt.Text);
                int cmnd = int.Parse(CMNDKH_txt.Text);
                string email = EmailKH_txt.Text;
                KhachHang_DTO khachhang = new KhachHang_DTO(idkhachhang, tenkh, sdt, cmnd, email);
                KhachHang_BUS.DeleteKH(idkhachhang);
                MessageBox.Show("Bạn đã xoá thành công");
                dataGridView1.DataSource = KhachHang_BUS.GetKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Conn = dbConnectionData.HamKetNoi();
                Conn.Open();
                SqlDataAdapter command = new SqlDataAdapter("TimKiemKhachHang", Conn);
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KhachHang_BUS.GetKhachHang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            IdKH_txt.Text = row.Cells[0].Value.ToString();
            TenKH_txt.Text = row.Cells[1].Value.ToString();            
            SDTKH_txt.Text = row.Cells[2].Value.ToString();
            CMNDKH_txt.Text = row.Cells[3].Value.ToString();
            EmailKH_txt.Text = row.Cells[4].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idkhachhang = int.Parse(IdKH_txt.Text);
                string tenkh = TenKH_txt.Text;
                int sdt = int.Parse(SDTKH_txt.Text);
                int cmnd = int.Parse(CMNDKH_txt.Text);
                string email = EmailKH_txt.Text;
                KhachHang_DTO khachhang = new KhachHang_DTO(idkhachhang, tenkh, sdt, cmnd, email);
                KhachHang_BUS.InsertKH(khachhang);
                MessageBox.Show("Bạn đã thêm thành công");
                dataGridView1.DataSource = KhachHang_BUS.GetKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
