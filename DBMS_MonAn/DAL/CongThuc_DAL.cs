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
    public class CongThuc_DAL
    {
        public static DataTable GetCongThuc()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("LayCongThuc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertCT(CongThuc_DTO ct)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("ThemCongThuc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDCongThuc", SqlDbType.Int);
            command.Parameters.Add("@NguyenLieu", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenMonAn", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@CachCheBien", SqlDbType.NText);
            command.Parameters.Add("@MucDo", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@ChuThich", SqlDbType.NVarChar, 50);
            command.Parameters["@IDCongThuc"].Value = ct.IDCongThuc1;
            command.Parameters["@NguyenLieu"].Value = ct.NguyenLieu1;
            command.Parameters["@TenMonAn"].Value = ct.TenMonAn1;
            command.Parameters["@CachCheBien"].Value = ct.CachCheBien1;
            command.Parameters["@MucDo"].Value = ct.MucDo1;
            command.Parameters["@ChuThich"].Value = ct.ChuThich1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateCT(CongThuc_DTO ct)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("SuaCongThuc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDCongThuc", SqlDbType.Int);
            command.Parameters.Add("@NguyenLieu", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenMonAn", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@CachCheBien", SqlDbType.NText);
            command.Parameters.Add("@MucDo", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@ChuThich", SqlDbType.NVarChar, 50);
            command.Parameters["@IDCongThuc"].Value = ct.IDCongThuc1;
            command.Parameters["@NguyenLieu"].Value = ct.NguyenLieu1;
            command.Parameters["@TenMonAn"].Value = ct.TenMonAn1;
            command.Parameters["@CachCheBien"].Value = ct.CachCheBien1;
            command.Parameters["@MucDo"].Value = ct.MucDo1;
            command.Parameters["@ChuThich"].Value = ct.ChuThich1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteCT(int idcongthuc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("XoaCongThuc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDCongThuc", SqlDbType.Int);
            command.Parameters["@IDCongThuc"].Value = idcongthuc;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
