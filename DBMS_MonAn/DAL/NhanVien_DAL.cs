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
    public class NhanVien_DAL
    {
        public static DataTable GetTable()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("LayNhanVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertNV(NhanVien_DTO nv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("ThemNhanvien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDNhanVien", SqlDbType.Int);
            command.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NamSinh", SqlDbType.Date);
            command.Parameters.Add("@SDT", SqlDbType.Int);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@CMND", SqlDbType.Int);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters["@IDNhanVien"].Value = nv.IDNhanVien1;
            command.Parameters["@TenNhanVien"].Value = nv.TenNhanVien1;
            command.Parameters["@GioiTinh"].Value = nv.GioiTinh1;
            command.Parameters["@NamSinh"].Value = nv.NamSinh1;
            command.Parameters["@SDT"].Value = nv.SDT1;
            command.Parameters["@DiaChi"].Value = nv.DiaChi1;
            command.Parameters["@CMND"].Value = nv.CMND1;
            command.Parameters["@Email"].Value = nv.Email1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateNV(NhanVien_DTO nv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("SuaNhanvien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDNhanVien", SqlDbType.Int);
            command.Parameters.Add("@TenNhanVien", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NamSinh", SqlDbType.Date);
            command.Parameters.Add("@SDT", SqlDbType.Int);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@CMND", SqlDbType.Int);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters["@IDNhanVien"].Value = nv.IDNhanVien1;
            command.Parameters["@TenNhanVien"].Value = nv.TenNhanVien1;
            command.Parameters["@GioiTinh"].Value = nv.GioiTinh1;
            command.Parameters["@NamSinh"].Value = nv.NamSinh1;
            command.Parameters["@SDT"].Value = nv.SDT1;
            command.Parameters["@DiaChi"].Value = nv.DiaChi1;
            command.Parameters["@CMND"].Value = nv.CMND1;
            command.Parameters["@Email"].Value = nv.Email1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteNV(int manv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("XoaNhanvien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDNhanVien", SqlDbType.Int);
            command.Parameters["@IDNhanVien"].Value = manv;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
