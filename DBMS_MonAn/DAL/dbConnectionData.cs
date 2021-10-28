using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class dbConnectionData
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=DBMS_MONAN;Integrated Security=True");
            return Conn;
        }
    }
}
