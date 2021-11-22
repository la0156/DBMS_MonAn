using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private int IDKhachHang;
        private String TenKhachHang;
        private int SDT;
        private int CMND;
        private String Email;

        public KhachHang_DTO(int iDKhachHang, string tenKhachHang, int sDT, int cMND, string email)
        {
            IDKhachHang1 = iDKhachHang;
            TenKhachHang1 = tenKhachHang;
            SDT1 = sDT;
            CMND1 = cMND;
            Email1 = email;
        }

        public int IDKhachHang1 { get => IDKhachHang; set => IDKhachHang = value; }
        public string TenKhachHang1 { get => TenKhachHang; set => TenKhachHang = value; }
        public int SDT1 { get => SDT; set => SDT = value; }
        public int CMND1 { get => CMND; set => CMND = value; }
        public string Email1 { get => Email; set => Email = value; }
    }
}
