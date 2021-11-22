using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguyenLieu_DTO
    {
        private int IDNguyenLieu;
        private int IDMonAn;
        private int IDCongThuc;
        private String TenMonAn;
        private String NguyenLieu;
        private String ChuThich;

        public NguyenLieu_DTO(int iDNguyenLieu, int iDMonAn, int iDCongThuc, string tenMonAn, string nguyenLieu, string chuThich)
        {
            IDNguyenLieu1 = iDNguyenLieu;
            IDMonAn1 = iDMonAn;
            IDCongThuc1 = iDCongThuc;
            TenMonAn1 = tenMonAn;
            NguyenLieu1 = nguyenLieu;
            ChuThich1 = chuThich;
        }

        public int IDNguyenLieu1 { get => IDNguyenLieu; set => IDNguyenLieu = value; }
        public int IDMonAn1 { get => IDMonAn; set => IDMonAn = value; }
        public int IDCongThuc1 { get => IDCongThuc; set => IDCongThuc = value; }
        public string TenMonAn1 { get => TenMonAn; set => TenMonAn = value; }
        public string NguyenLieu1 { get => NguyenLieu; set => NguyenLieu = value; }
        public string ChuThich1 { get => ChuThich; set => ChuThich = value; }
    }
}
