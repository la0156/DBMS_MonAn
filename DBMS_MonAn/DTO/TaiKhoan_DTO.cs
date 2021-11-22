using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private String TaiKhoan;
        private String MatKhau;
        private String HoTen;
        private DateTime NamSinh;
        private String Email;
        private String quyen;

        public TaiKhoan_DTO(string taiKhoan, string matKhau, string hoTen, DateTime namSinh, string email, string quyen)
        {
            TaiKhoan1 = taiKhoan;
            MatKhau1 = matKhau;
            HoTen1 = hoTen;
            NamSinh1 = namSinh;
            Email1 = email;
            this.Quyen = quyen;
        }

        public string TaiKhoan1 { get => TaiKhoan; set => TaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public DateTime NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Quyen { get => quyen; set => quyen = value; }
    }
}
