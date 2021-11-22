using System;
using System.Collections.Generic;
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
    public partial class CongThuc : Form
    {
        public CongThuc()
        {
            InitializeComponent();
        }

        private void CongThuc_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = CongThuc_DAL.GetCongThuc();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            IDCT_txt.Text = row.Cells[0].Value.ToString();
            TenMonAn_txt.Text = row.Cells[1].Value.ToString();
            NguyenLieu_txt.Text = row.Cells[2].Value.ToString();
            MucDo_txt.Text = row.Cells[3].Value.ToString();
            CongThuc_txt.Text = row.Cells[4].Value.ToString();
            ChuThich_txt.Text = row.Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idcongthuc = int.Parse(IDCT_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                string nguyenlieu = NguyenLieu_txt.Text;
                string mucdo = MucDo_txt.Text;
                string congthuc = CongThuc_txt.Text;
                string chuthich = ChuThich_txt.Text;
                CongThuc_DTO congthucmon = new CongThuc_DTO(idcongthuc, tenmonan, nguyenlieu, mucdo, congthuc, chuthich);
                CongThuc_BUS.InsertCT(congthucmon);
                MessageBox.Show("Bạn đã thêm thành công");
                dataGridView1.DataSource = CongThuc_BUS.GetCongThuc();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int idcongthuc = int.Parse(IDCT_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                string nguyenlieu = NguyenLieu_txt.Text;
                string mucdo = MucDo_txt.Text;
                string congthuc = CongThuc_txt.Text;
                string chuthich = ChuThich_txt.Text;
                CongThuc_DTO congthucmon = new CongThuc_DTO(idcongthuc, tenmonan, nguyenlieu, mucdo, congthuc, chuthich);
                CongThuc_BUS.UpdateCT(congthucmon);
                MessageBox.Show("Bạn đã sửa thành công");
                dataGridView1.DataSource = CongThuc_BUS.GetCongThuc();
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
                int idcongthuc = int.Parse(IDCT_txt.Text);
                string tenmonan = TenMonAn_txt.Text;
                string nguyenlieu = NguyenLieu_txt.Text;
                string mucdo = MucDo_txt.Text;
                string congthuc = CongThuc_txt.Text;
                string chuthich = ChuThich_txt.Text;
                CongThuc_DTO congthucmon = new CongThuc_DTO(idcongthuc, tenmonan, nguyenlieu, mucdo, congthuc, chuthich);
                CongThuc_BUS.DeleteCT(idcongthuc);
                MessageBox.Show("Bạn đã xoá thành công");
                dataGridView1.DataSource = CongThuc_BUS.GetCongThuc();
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
                SqlDataAdapter command = new SqlDataAdapter("TimKiemCongThuc", Conn);
                command.SelectCommand.CommandType = CommandType.StoredProcedure;
                command.SelectCommand.Parameters.AddWithValue("@searchTen", TimKiemCT_txt.Text.Trim());
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
