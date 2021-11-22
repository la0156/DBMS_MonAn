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
    public partial class MonAn : Form
    {
        public MonAn()
        {
            InitializeComponent();
        }

        private void MonAn_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MonAn_BUS.GetMonAn();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            IDMA_txt.Text = row.Cells[0].Value.ToString();
            IDLMA_txt.Text = row.Cells[1].Value.ToString();
            TenMonAn_txt.Text = row.Cells[2].Value.ToString();
            TenLoaiMonAn_txt.Text = row.Cells[3].Value.ToString();
            XuatSu_txt.Text = row.Cells[4].Value.ToString();
            ThoiGian.Text = row.Cells[5].Value.ToString();
            Gia_txt.Text = row.Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idmonan = int.Parse(IDMA_txt.Text);
                int idloaimonan = int.Parse(IDLMA_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                string tenloaimonan = TenLoaiMonAn_txt.Text;
                string xuatsu = XuatSu_txt.Text;
                DateTime ngaynhap = ThoiGian.Value;
                float gia = float.Parse(Gia_txt.Text);
                MonAn_DTO monan = new MonAn_DTO(idmonan, idloaimonan, tenmonan, tenloaimonan, xuatsu, ngaynhap, gia);
                MonAn_BUS.InsertMA(monan);
                MessageBox.Show("Bạn đã thêm thành công");
                dataGridView1.DataSource = MonAn_BUS.GetMonAn();
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
                int idmonan = int.Parse(IDMA_txt.Text);
                int idloaimonan = int.Parse(IDLMA_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                string tenloaimonan = TenLoaiMonAn_txt.Text;
                string xuatsu = XuatSu_txt.Text;
                DateTime ngaynhap = ThoiGian.Value;
                float gia = float.Parse(Gia_txt.Text);
                MonAn_DTO monan = new MonAn_DTO(idmonan, idloaimonan, tenmonan, tenloaimonan, xuatsu, ngaynhap, gia);
                MonAn_BUS.UpdateMA(monan);
                MessageBox.Show("Bạn đã sửa thành công");
                dataGridView1.DataSource = MonAn_BUS.GetMonAn();
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
                int idmonan = int.Parse(IDMA_txt.Text);
                int idloaimonan = int.Parse(IDLMA_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                string tenloaimonan = TenLoaiMonAn_txt.Text;
                string xuatsu = XuatSu_txt.Text;
                DateTime ngaynhap = ThoiGian.Value;
                float gia = float.Parse(Gia_txt.Text);
                MonAn_DTO monan = new MonAn_DTO(idmonan, idloaimonan, tenmonan, tenloaimonan, xuatsu, ngaynhap, gia);
                MonAn_BUS.DeleteMA(idmonan);
                MessageBox.Show("Bạn đã xoá thành công");
                dataGridView1.DataSource = MonAn_BUS.GetMonAn();
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
                SqlDataAdapter command = new SqlDataAdapter("TimKiemMonAn", Conn);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("@searchTen", TimKiemMA_txt.Text.Trim());
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

        private void TenNV_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
