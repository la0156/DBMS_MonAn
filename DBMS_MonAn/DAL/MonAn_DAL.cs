using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class MonAn_DAL
    {
        public static DataTable GetMonAn()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("LayMonAn", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertMA(MonAn_DTO ma)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("ThemMonAn", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDMonAn", SqlDbType.Int);
            command.Parameters.Add("@IDLoaiMonAn", SqlDbType.Int);
            command.Parameters.Add("@TenMonAn", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenLoaiMonAn", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@XuatSu", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgayNhap", SqlDbType.DateTime);
            command.Parameters.Add("@Gia", SqlDbType.Money);
            command.Parameters["@IDMonAn"].Value = ma.IDMonAn1;
            command.Parameters["@IDLoaiMonAn"].Value = ma.IDLoaiMonAn1;
            command.Parameters["@TenMonAn"].Value = ma.TenMonAn1;
            command.Parameters["@TenLoaiMonAn"].Value = ma.TenLoaiMonAn1;
            command.Parameters["@XuatSu"].Value = ma.XuatSu1;
            command.Parameters["@NgayNhap"].Value = ma.NgayNhap1;
            command.Parameters["@Gia"].Value = ma.Gia1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }


        public static void UpdateMA(MonAn_DTO ma)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("SuaMonAn", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDMonAn", SqlDbType.Int);
            command.Parameters.Add("@IDLoaiMonAn", SqlDbType.Int);
            command.Parameters.Add("@TenMonAn", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenLoaiMonAn", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@XuatSu", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NgayNhap", SqlDbType.DateTime);
            command.Parameters.Add("@Gia", SqlDbType.Money);
            command.Parameters["@IDMonAn"].Value = ma.IDMonAn1;
            command.Parameters["@IDLoaiMonAn"].Value = ma.IDLoaiMonAn1;
            command.Parameters["@TenMonAn"].Value = ma.TenMonAn1;
            command.Parameters["@TenLoaiMonAn"].Value = ma.TenLoaiMonAn1;
            command.Parameters["@XuatSu"].Value = ma.XuatSu1;
            command.Parameters["@NgayNhap"].Value = ma.NgayNhap1;
            command.Parameters["@Gia"].Value = ma.Gia1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteMA(int idmonan)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("XoaMonAn", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDMonAn", SqlDbType.Int);
            command.Parameters["@IDMonAn"].Value = idmonan;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
