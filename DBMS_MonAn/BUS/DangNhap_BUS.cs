using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BUS
{
    public class DangNhap_BUS
    {
        public static bool Login(string username, string password)
        {
            return DangNhap_DAL.Instance.Login(username, password);
        }       
    }
}
