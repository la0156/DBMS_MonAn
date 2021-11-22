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
    public class NguyenLieu_BUS
    {
        public static DataTable GetNguyenLieu()
        {
            return NguyenLieu_DAL.GetTable();
        }

        public static void InsertNL(NguyenLieu_DTO nl)
        {
            NguyenLieu_DAL.InsertNL(nl);
        }

        public static void UpdateNL(NguyenLieu_DTO nl)
        {
            NguyenLieu_DAL.UpdateNL(nl);
        }

        public static void DeleteNL(int manl)
        {
            NguyenLieu_DAL.DeleteNL(manl);
        }
    }
}
