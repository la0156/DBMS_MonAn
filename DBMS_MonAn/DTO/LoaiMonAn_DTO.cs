using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiMonAn_DTO
    {
        private int IDLoaiMonAn;
        private String TenLoaiMonAn;

        public LoaiMonAn_DTO(int iDLoaiMonAn, string tenLoaiMonAn)
        {
            IDLoaiMonAn1 = iDLoaiMonAn;
            TenLoaiMonAn1 = tenLoaiMonAn;
        }

        public int IDLoaiMonAn1 { get => IDLoaiMonAn; set => IDLoaiMonAn = value; }
        public string TenLoaiMonAn1 { get => TenLoaiMonAn; set => TenLoaiMonAn = value; }
    }
}
