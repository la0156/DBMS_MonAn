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
    public class DatMon_DAL
    {
        public static DataTable GetDatMon()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("LayDatMon", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertDM(DatMon_DTO dm)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("ThemDatMon", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDDatMon", SqlDbType.Int);
            command.Parameters.Add("@IDKhachHang", SqlDbType.Int);
            command.Parameters.Add("@IDNhanVien", SqlDbType.Int);
            command.Parameters.Add("@IDMonAn", SqlDbType.Int);
            command.Parameters.Add("@TenMonAn", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenKhachHang", SqlDbType.NText);
            command.Parameters.Add("@SDT", SqlDbType.Int);
            command.Parameters.Add("@SoLuong", SqlDbType.Int);
            command.Parameters.Add("@Gia", SqlDbType.Float);
            command.Parameters.Add("@GiamGia", SqlDbType.Float);
            command.Parameters["@IDDatMon"].Value = dm.IDDatMon1;
            command.Parameters["@IDKhachHang"].Value = dm.IDKhachHang1;
            command.Parameters["@IDNhanVien"].Value = dm.IDNhanVien1;
            command.Parameters["@IDMonAn"].Value = dm.IDMonAn1;
            command.Parameters["@TenMonAn"].Value = dm.TenMonAn1;
            command.Parameters["@TenKhachHang"].Value = dm.TenKhachHang1;
            command.Parameters["@SDT"].Value = dm.SDT1;
            command.Parameters["@SoLuong"].Value = dm.SoLuong1;
            command.Parameters["@Gia"].Value = dm.Gia1;
            command.Parameters["@GiamGia"].Value = dm.GiamGia1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }


        public static void UpdateDM(DatMon_DTO dm)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("SuaDatMon", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDDatMon", SqlDbType.Int);
            command.Parameters.Add("@IDKhachHang", SqlDbType.Int);
            command.Parameters.Add("@IDNhanVien", SqlDbType.Int);
            command.Parameters.Add("@IDMonAn", SqlDbType.Int);
            command.Parameters.Add("@TenMonAn", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenKhachHang", SqlDbType.NText);
            command.Parameters.Add("@SDT", SqlDbType.Int);
            command.Parameters.Add("@SoLuong", SqlDbType.Int);
            command.Parameters.Add("@Gia", SqlDbType.Float);
            command.Parameters.Add("@GiamGia", SqlDbType.Float);
            command.Parameters["@IDDatMon"].Value = dm.IDDatMon1;
            command.Parameters["@IDKhachHang"].Value = dm.IDKhachHang1;
            command.Parameters["@IDNhanVien"].Value = dm.IDNhanVien1;
            command.Parameters["@IDMonAn"].Value = dm.IDMonAn1;
            command.Parameters["@TenMonAn"].Value = dm.TenMonAn1;
            command.Parameters["@TenKhachHang"].Value = dm.TenKhachHang1;
            command.Parameters["@SDT"].Value = dm.SDT1;
            command.Parameters["@SoLuong"].Value = dm.SoLuong1;
            command.Parameters["@Gia"].Value = dm.Gia1;
            command.Parameters["@GiamGia"].Value = dm.GiamGia1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteDM(int iddm)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("XoaDatMon", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@IDDatMon", SqlDbType.Int);
            command.Parameters["@IDDatMon"].Value = iddm;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
