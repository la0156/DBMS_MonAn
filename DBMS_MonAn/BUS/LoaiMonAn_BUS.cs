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
    public class LoaiMonAn_BUS
    {
        public static DataTable GetLoaiMonAn()
        {
            return LoaiMonAn_DAL.GetLoaiMonAn();
        }

        public static void InsertLMA(LoaiMonAn_DTO lma)
        {
            LoaiMonAn_DAL.InsertLMA(lma);
        }

        public static void UpdateLMA(LoaiMonAn_DTO lma)
        {
            LoaiMonAn_DAL.UpdateLMA(lma);
        }

        public static void DeleteLMA(int malma)
        {
            LoaiMonAn_DAL.DeleteMA(malma);
        }
    }
}
