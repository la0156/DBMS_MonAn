using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatMon_DTO
    {
        private int IDDatMon;
        private int IDKhachHang;
        private int IDNhanVien;
        private int IDMonAn;
        private String TenKhachHang;
        private int SDT;
        private String TenMonAn;
        private int SoLuong;
        private float Gia;
        private float GiamGia;

        public DatMon_DTO(int iDDatMon, int iDKhachHang, int iDNhanVien, int iDMonAn, string tenKhachHang, int sDT, string tenMonAn, int soLuong, float gia, float giamGia)
        {
            IDDatMon1 = iDDatMon;
            IDKhachHang1 = iDKhachHang;
            IDNhanVien1 = iDNhanVien;
            IDMonAn1 = iDMonAn;
            TenKhachHang1 = tenKhachHang;
            SDT1 = sDT;
            TenMonAn1 = tenMonAn;
            SoLuong1 = soLuong;
            Gia1 = gia;
            GiamGia1 = giamGia;
        }

        public int IDDatMon1 { get => IDDatMon; set => IDDatMon = value; }
        public int IDKhachHang1 { get => IDKhachHang; set => IDKhachHang = value; }
        public int IDNhanVien1 { get => IDNhanVien; set => IDNhanVien = value; }
        public int IDMonAn1 { get => IDMonAn; set => IDMonAn = value; }
        public string TenKhachHang1 { get => TenKhachHang; set => TenKhachHang = value; }
        public int SDT1 { get => SDT; set => SDT = value; }
        public string TenMonAn1 { get => TenMonAn; set => TenMonAn = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public float Gia1 { get => Gia; set => Gia = value; }
        public float GiamGia1 { get => GiamGia; set => GiamGia = value; }
    }
}
