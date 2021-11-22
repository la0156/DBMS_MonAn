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
    public class DatMon_BUS
    {
        public static DataTable GetDatMon()
        {
            return DatMon_DAL.GetDatMon();
        }

        public static void InsertDM(DatMon_DTO dm)
        {
            DatMon_DAL.InsertDM(dm);
        }

        public static void UpdateDM(DatMon_DTO dm)
        {
            DatMon_DAL.UpdateDM(dm);
        }

        public static void DeleteDM(int iddatmon)
        {
            DatMon_DAL.DeleteDM(iddatmon);
        }
    }
}
