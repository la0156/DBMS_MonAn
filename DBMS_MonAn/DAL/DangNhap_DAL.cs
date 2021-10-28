using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class DangNhap_DAL
    {
        private static DangNhap_DAL instance;
        public static DangNhap_DAL Instance
        {
            get { if (instance == null) instance = new DangNhap_DAL(); return instance; }
            private set { instance = value; }
        }      

        private DangNhap_DAL() { }
        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
    }
}
