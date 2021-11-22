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
using System.Data;
using DAL;

namespace GUI_MonAn
{
    public partial class QuanLy : Form
    {

        public QuanLy()
        {
            InitializeComponent();
            KiemTra();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        void KiemTra()
        {
            if(DangNhap.quyen == "nhanvien")
            {
                TaiKhoan_btn.Enabled = false;
                NhanVien_btn.Enabled = false;
                KhachHang_btn.Enabled = false;
            }
            else
            {
                TaiKhoan_btn.Enabled = true;
                NhanVien_btn.Enabled = true;
                KhachHang_btn.Enabled = true;
            }
        }

        private void TaiKhoan_btn_Click(object sender, EventArgs e)
        {
            TaiKhoan a = new TaiKhoan();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void KhachHang_btn_Click(object sender, EventArgs e)
        {
            KhachHang b = new KhachHang();
            this.Hide();
            b.ShowDialog();
            this.Show();
        }

        private void NhanVien_btn_Click(object sender, EventArgs e)
        {
            NhanVien c = new NhanVien();
            this.Hide();
            c.ShowDialog();
            this.Show();
        }

        private void NguyenLieu_btn_Click(object sender, EventArgs e)
        {
            NguyenLieu f = new NguyenLieu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void LoaiMonAn_btn_Click(object sender, EventArgs e)
        {
            LoaiNguyenLieu g = new LoaiNguyenLieu();
            this.Hide();
            g.ShowDialog();
            this.Show();
        }

        private void DanhGia_btn_Click(object sender, EventArgs e)
        {
            DanhGia m = new DanhGia();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            ThongKe h = new ThongKe();
            this.Hide();
            h.ShowDialog();
            this.Show();
        }

        private void MonAn_btn_Click(object sender, EventArgs e)
        {
            MonAn j = new MonAn();
            this.Hide();
            j.ShowDialog();
            this.Show();
        }

        private void CongThuc_btn_Click(object sender, EventArgs e)
        {
            CongThuc k = new CongThuc();
            this.Hide();
            k.ShowDialog();
            this.Show();
        }

        private void DatMon_btn_Click(object sender, EventArgs e)
        {
            DatMon l = new DatMon();
            this.Hide();
            l.ShowDialog();
            this.Show();
        }

        private void DiaDiem_btn_Click(object sender, EventArgs e)
        {
            DiaDiem m = new DiaDiem();
            this.Hide();
            m.ShowDialog();
            this.Show();
        }
    }
}
