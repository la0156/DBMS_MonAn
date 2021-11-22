using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongThuc_DTO
    {
        private int IDCongThuc;
        private String NguyenLieu;
        private String TenMonAn;
        private String CachCheBien;
        private String MucDo;
        private String ChuThich;

        public CongThuc_DTO(int iDCongThuc, string nguyenLieu, string tenMonAn, string cachCheBien, string mucDo, string chuThich)
        {
            IDCongThuc1 = iDCongThuc;
            NguyenLieu1 = nguyenLieu;
            TenMonAn1 = tenMonAn;
            CachCheBien1 = cachCheBien;
            MucDo1 = mucDo;
            ChuThich1 = chuThich;
        }

        public int IDCongThuc1 { get => IDCongThuc; set => IDCongThuc = value; }
        public string NguyenLieu1 { get => NguyenLieu; set => NguyenLieu = value; }
        public string TenMonAn1 { get => TenMonAn; set => TenMonAn = value; }
        public string CachCheBien1 { get => CachCheBien; set => CachCheBien = value; }
        public string MucDo1 { get => MucDo; set => MucDo = value; }
        public string ChuThich1 { get => ChuThich; set => ChuThich = value; }
    }
}
