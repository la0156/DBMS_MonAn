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
    public class KhachHang_DAL
    {
        public static DataTable GetTable()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("LayKhachHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertKH(KhachHang_DTO nv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("ThemKhachHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDKhachHang", SqlDbType.Int);
            command.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@SDT", SqlDbType.Int);
            command.Parameters.Add("@CMND", SqlDbType.Int);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters["@IDKhachHang"].Value = nv.IDKhachHang1;
            command.Parameters["@TenKhachHang"].Value = nv.TenKhachHang1;
            command.Parameters["@SDT"].Value = nv.SDT1;
            command.Parameters["@CMND"].Value = nv.CMND1;
            command.Parameters["@Email"].Value = nv.Email1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateKH(KhachHang_DTO nv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("SuaKhachHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDKhachHang", SqlDbType.Int);
            command.Parameters.Add("@TenKhachHang", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@SDT", SqlDbType.Int);
            command.Parameters.Add("@CMND", SqlDbType.Int);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters["@IDKhachHang"].Value = nv.IDKhachHang1;
            command.Parameters["@TenKhachHang"].Value = nv.TenKhachHang1;
            command.Parameters["@SDT"].Value = nv.SDT1;
            command.Parameters["@CMND"].Value = nv.CMND1;
            command.Parameters["@Email"].Value = nv.Email1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteKH(int makh)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("XoaKhachHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDKhachHang", SqlDbType.Int);
            command.Parameters["@IDKhachHang"].Value = makh;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
