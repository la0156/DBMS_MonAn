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
    public class TaiKhoan_DAL
    {
        public static DataTable GetTaiKhoan()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("LayTaiKhoan", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void InsertTK(TaiKhoan_DTO tk)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("ThemTaiKhoan", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NamSinh", SqlDbType.DateTime);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Quyen", SqlDbType.NVarChar, 50);
            command.Parameters["@TaiKhoan"].Value = tk.TaiKhoan1;
            command.Parameters["@MatKhau"].Value = tk.MatKhau1;
            command.Parameters["@HoTen"].Value = tk.HoTen1;
            command.Parameters["@NamSinh"].Value = tk.NamSinh1;
            command.Parameters["@Email"].Value = tk.Email1;
            command.Parameters["@Quyen"].Value = tk.Quyen;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void UpdateTK(TaiKhoan_DTO tk)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("SuaTaiKhoan", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@HoTen", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@NamSinh", SqlDbType.DateTime);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Quyen", SqlDbType.NVarChar, 50);
            command.Parameters["@TaiKhoan"].Value = tk.TaiKhoan1;
            command.Parameters["@MatKhau"].Value = tk.MatKhau1;
            command.Parameters["@HoTen"].Value = tk.HoTen1;
            command.Parameters["@NamSinh"].Value = tk.NamSinh1;
            command.Parameters["@Email"].Value = tk.Email1;
            command.Parameters["@Quyen"].Value = tk.Quyen;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteTK(string taikhoan)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("XoaTaiKhoan", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar, 50);
            command.Parameters["@TaiKhoan"].Value = taikhoan;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
