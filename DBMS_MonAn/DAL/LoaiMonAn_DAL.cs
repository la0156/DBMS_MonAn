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
    public class LoaiMonAn_DAL
    {
        public static DataTable GetLoaiMonAn()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("LayLoaiMonAn", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertLMA(LoaiMonAn_DTO lma)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("ThemLoaiMonAn", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDLoaiMonAn", SqlDbType.Int);
            command.Parameters.Add("@TenLoaiMonAn", SqlDbType.NVarChar, 50);
            command.Parameters["@IDLoaiMonAn"].Value = lma.IDLoaiMonAn1;
            command.Parameters["@TenLoaiMonAn"].Value = lma.TenLoaiMonAn1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateLMA(LoaiMonAn_DTO lma)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("SuaLoaiMonAn", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDLoaiMonAn", SqlDbType.Int);
            command.Parameters.Add("@TenLoaiMonAn", SqlDbType.NVarChar, 50);
            command.Parameters["@IDLoaiMonAn"].Value = lma.IDLoaiMonAn1;
            command.Parameters["@TenLoaiMonAn"].Value = lma.TenLoaiMonAn1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteMA(int loaimonan)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("XoaLoaiMonAn", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDLoaiMonAn", SqlDbType.Int);
            command.Parameters["@IDLoaiMonAn"].Value = loaimonan;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

    }
}
