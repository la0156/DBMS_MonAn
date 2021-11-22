using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
using DTO;

namespace BUS
{

    public class KhachHang_BUS
    {
        public static DataTable GetKhachHang()
        {
            return KhachHang_DAL.GetTable();
        }

        public static void InsertKH(KhachHang_DTO kh)
        {
            KhachHang_DAL.InsertKH(kh);
        }

        public static void UpdateKH(KhachHang_DTO kh)
        {
            KhachHang_DAL.UpdateKH(kh);
        }

        public static void DeleteKH(int makh)
        {
            KhachHang_DAL.DeleteKH(makh);
        }
    }
}
