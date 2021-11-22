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
    public class TaiKhoan_BUS
    {
        public static DataTable GetTaiKhoan()
        {
            return TaiKhoan_DAL.GetTaiKhoan();
        }

        public static void InsertTK(TaiKhoan_DTO tk)
        {
            TaiKhoan_DAL.InsertTK(tk);
        }

        public static void UpdateTK(TaiKhoan_DTO tk)
        {
            TaiKhoan_DAL.UpdateTK(tk);
        }

        public static void DeleteTK(string taikhoan)
        {
            TaiKhoan_DAL.DeleteTK(taikhoan);
        }
    }
}
