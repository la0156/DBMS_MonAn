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
    public partial class NguyenLieu : Form
    {
        public NguyenLieu()
        {
            InitializeComponent();
        }

        private void NguyenLieu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NguyenLieu_BUS.GetNguyenLieu();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idnguyenlieu = int.Parse(IDNL_txt.Text);
                int idmonan = int.Parse(IDMonAn_txt.Text);
                int idcongthuc = int.Parse(IDCongThuc_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                string nguyenlieu = NguyenLieu_txt.Text;
                string chuthich = ChuThich_txt.Text;
                NguyenLieu_DTO nguyenlieumon = new NguyenLieu_DTO(idnguyenlieu, idmonan, idcongthuc, tenmonan, nguyenlieu, chuthich);
                NguyenLieu_BUS.InsertNL(nguyenlieumon);
                MessageBox.Show("Bạn đã thêm thành công");
                dataGridView1.DataSource = NguyenLieu_BUS.GetNguyenLieu();
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
            IDNL_txt.Text = row.Cells[0].Value.ToString();
            IDMonAn_txt.Text = row.Cells[1].Value.ToString();
            IDCongThuc_txt.Text = row.Cells[2].Value.ToString();
            TenMonAn_txt.Text = row.Cells[3].Value.ToString();
            NguyenLieu_txt.Text = row.Cells[4].Value.ToString();
            ChuThich_txt.Text = row.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idnguyenlieu = int.Parse(IDNL_txt.Text);
                int idmonan = int.Parse(IDMonAn_txt.Text);
                int idcongthuc = int.Parse(IDCongThuc_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                string nguyenlieu = NguyenLieu_txt.Text;
                string chuthich = ChuThich_txt.Text;
                NguyenLieu_DTO nguyenlieumon = new NguyenLieu_DTO(idnguyenlieu, idmonan, idcongthuc, tenmonan, nguyenlieu, chuthich);
                NguyenLieu_BUS.UpdateNL(nguyenlieumon);
                MessageBox.Show("Bạn đã sửa thành công");
                dataGridView1.DataSource = NguyenLieu_BUS.GetNguyenLieu();
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
                int idnguyenlieu = int.Parse(IDNL_txt.Text);
                int idmonan = int.Parse(IDMonAn_txt.Text);
                int idcongthuc = int.Parse(IDCongThuc_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                string nguyenlieu = NguyenLieu_txt.Text;
                string chuthich = ChuThich_txt.Text;
                NguyenLieu_DTO nguyenlieumon = new NguyenLieu_DTO(idnguyenlieu, idmonan, idcongthuc, tenmonan, nguyenlieu, chuthich);
                NguyenLieu_BUS.DeleteNL(idnguyenlieu);
                MessageBox.Show("Bạn đã xoá thành công");
                dataGridView1.DataSource = NguyenLieu_BUS.GetNguyenLieu();
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
                SqlDataAdapter command = new SqlDataAdapter("TimKiemNguyenLieu", Conn);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("@searchTen", TimKiemNL_txt.Text.Trim());
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
    }
}
