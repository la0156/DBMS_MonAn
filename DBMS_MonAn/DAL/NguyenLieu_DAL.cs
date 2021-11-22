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
    public class NguyenLieu_DAL
    {
        public static DataTable GetTable()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("LayNguyenLieu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertNL(NguyenLieu_DTO nl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("ThemNguyenLieu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDNguyenLieu", SqlDbType.Int);
            command.Parameters.Add("@IDMonAn", SqlDbType.Int);
            command.Parameters.Add("@IDCongThuc", SqlDbType.Int);
            command.Parameters.Add("@TenMonAn", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NguyenLieuMon", SqlDbType.NVarChar, 4000);
            command.Parameters.Add("@ChuThich", SqlDbType.NVarChar, 50);
            command.Parameters["@IDNguyenLieu"].Value = nl.IDNguyenLieu1;
            command.Parameters["@IDMonAn"].Value = nl.IDMonAn1;
            command.Parameters["@IDCongThuc"].Value = nl.IDCongThuc1;
            command.Parameters["@TenMonAn"].Value = nl.TenMonAn1;
            command.Parameters["@NguyenLieuMon"].Value = nl.NguyenLieu1;
            command.Parameters["@ChuThich"].Value = nl.ChuThich1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateNL(NguyenLieu_DTO nl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("SuaNguyenLieu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDNguyenLieu", SqlDbType.Int);
            command.Parameters.Add("@IDMonAn", SqlDbType.Int);
            command.Parameters.Add("@IDCongThuc", SqlDbType.Int);
            command.Parameters.Add("@TenMonAn", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NguyenLieuMon", SqlDbType.NVarChar, 4000);
            command.Parameters.Add("@ChuThich", SqlDbType.NVarChar, 50);
            command.Parameters["@IDNguyenLieu"].Value = nl.IDNguyenLieu1;
            command.Parameters["@IDMonAn"].Value = nl.IDMonAn1;
            command.Parameters["@IDCongThuc"].Value = nl.IDCongThuc1;
            command.Parameters["@TenMonAn"].Value = nl.TenMonAn1;
            command.Parameters["@NguyenLieuMon"].Value = nl.NguyenLieu1;
            command.Parameters["@ChuThich"].Value = nl.ChuThich1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteNL(int manl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("XoaNguyenLieu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDNguyenLieu", SqlDbType.Int);
            command.Parameters["@IDNguyenLieu"].Value = manl;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }      
    }
}
