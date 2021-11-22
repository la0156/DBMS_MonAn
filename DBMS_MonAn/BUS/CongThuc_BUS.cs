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
    public class CongThuc_BUS
    {
        public static DataTable GetCongThuc()
        {
            return CongThuc_DAL.GetCongThuc();
        }

        public static void InsertCT(CongThuc_DTO ct)
        {
            CongThuc_DAL.InsertCT(ct);
        }

        public static void UpdateCT(CongThuc_DTO ct)
        {
            CongThuc_DAL.UpdateCT(ct);
        }

        public static void DeleteCT(int idcongthuc)
        {
            CongThuc_DAL.DeleteCT(idcongthuc);
        }
    }
}
