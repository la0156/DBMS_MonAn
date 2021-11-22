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
    public partial class LoaiNguyenLieu : Form
    {
        public LoaiNguyenLieu()
        {
            InitializeComponent();
        }

        private void LoaiNguyenLieu_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoaiMonAn_BUS.GetLoaiMonAn();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            IDLMA_txt.Text = row.Cells[0].Value.ToString();
            TenLoaiMonAn_txt.Text = row.Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idloaimonan = int.Parse(IDLMA_txt.Text);
                string tenloaimonan = TenLoaiMonAn_txt.Text;
                LoaiMonAn_DTO loaimonan = new LoaiMonAn_DTO(idloaimonan, tenloaimonan);
                LoaiMonAn_BUS.InsertLMA(loaimonan);
                MessageBox.Show("Bạn đã thêm thành công");
                dataGridView1.DataSource = LoaiMonAn_BUS.GetLoaiMonAn();
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
                int idloaimonan = int.Parse(IDLMA_txt.Text);
                string tenloaimonan = TenLoaiMonAn_txt.Text;
                LoaiMonAn_DTO loaimonan = new LoaiMonAn_DTO(idloaimonan, tenloaimonan);
                LoaiMonAn_BUS.UpdateLMA(loaimonan);
                MessageBox.Show("Bạn đã sửa thành công");
                dataGridView1.DataSource = LoaiMonAn_BUS.GetLoaiMonAn();
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
                int idloaimonan = int.Parse(IDLMA_txt.Text);
                string tenloaimonan = TenLoaiMonAn_txt.Text;
                LoaiMonAn_DTO loaimonan = new LoaiMonAn_DTO(idloaimonan, tenloaimonan);
                LoaiMonAn_BUS.DeleteLMA(idloaimonan);
                MessageBox.Show("Bạn đã xoá thành công");
                dataGridView1.DataSource = LoaiMonAn_BUS.GetLoaiMonAn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
