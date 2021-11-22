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
    public class MonAn_BUS
    {
        public static DataTable GetMonAn()
        {
            return MonAn_DAL.GetMonAn();
        }

        public static void InsertMA(MonAn_DTO ma)
        {
            MonAn_DAL.InsertMA(ma);
        }

        public static void UpdateMA(MonAn_DTO ma)
        {
            MonAn_DAL.UpdateMA(ma);
        }

        public static void DeleteMA(int idmonan)
        {
            MonAn_DAL.DeleteMA(idmonan);
        }
    }
}
