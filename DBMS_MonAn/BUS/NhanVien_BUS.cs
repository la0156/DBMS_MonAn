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
    public class NhanVien_BUS
    {
        public static DataTable GetNhanVien()
        {
            return NhanVien_DAL.GetTable();
        }

        public static void InsertNV(NhanVien_DTO nv)
        {
            NhanVien_DAL.InsertNV(nv);
        }

        public static void UpdateNV(NhanVien_DTO nv)
        {
            NhanVien_DAL.UpdateNV(nv);
        }

        public static void DeleteNV(int manv)
        {
            NhanVien_DAL.DeleteNV(manv);
        }     
    }
}
