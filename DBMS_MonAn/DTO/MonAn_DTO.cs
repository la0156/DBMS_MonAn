using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonAn_DTO
    {
        private int IDMonAn;
        private int IDLoaiMonAn;
        private String TenMonAn;
        private String TenLoaiMonAn;
        private String XuatSu;
        private DateTime NgayNhap;
        private float Gia;

        public MonAn_DTO(int iDMonAn, int iDLoaiMonAn, string tenMonAn, string tenLoaiMonAn, string xuatSu, DateTime ngayNhap, float gia)
        {
            IDMonAn1 = iDMonAn;
            IDLoaiMonAn1 = iDLoaiMonAn;
            TenMonAn1 = tenMonAn;
            TenLoaiMonAn1 = tenLoaiMonAn;
            XuatSu1 = xuatSu;
            NgayNhap1 = ngayNhap;
            Gia1 = gia;
        }

        public int IDMonAn1 { get => IDMonAn; set => IDMonAn = value; }
        public int IDLoaiMonAn1 { get => IDLoaiMonAn; set => IDLoaiMonAn = value; }
        public string TenMonAn1 { get => TenMonAn; set => TenMonAn = value; }
        public string TenLoaiMonAn1 { get => TenLoaiMonAn; set => TenLoaiMonAn = value; }
        public string XuatSu1 { get => XuatSu; set => XuatSu = value; }
        public DateTime NgayNhap1 { get => NgayNhap; set => NgayNhap = value; }
        public float Gia1 { get => Gia; set => Gia = value; }
    }
}
