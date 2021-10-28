using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private int IDNhanVien;
        private String TenNhanVien;
        private String GioiTinh;
        private DateTime NamSinh;
        private int SDT;
        private String DiaChi;
        private int CMND;
        private String Email;

        public NhanVien_DTO(int iDNhanVien, string tenNhanVien, string gioiTinh, DateTime namSinh, int sDT, string diaChi, int cMND, string email)
        {
            IDNhanVien1 = iDNhanVien;
            TenNhanVien1 = tenNhanVien;
            GioiTinh1 = gioiTinh;
            NamSinh1 = namSinh;
            SDT1 = sDT;
            DiaChi1 = diaChi;
            CMND1 = cMND;
            Email1 = email;
        }

        public int IDNhanVien1 { get => IDNhanVien; set => IDNhanVien = value; }
        public string TenNhanVien1 { get => TenNhanVien; set => TenNhanVien = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public DateTime NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public int SDT1 { get => SDT; set => SDT = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public int CMND1 { get => CMND; set => CMND = value; }
        public string Email1 { get => Email; set => Email = value; }
    }
}
