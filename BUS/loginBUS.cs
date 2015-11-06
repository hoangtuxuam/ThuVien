using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS
{
    public class loginBUS
    {
        public NhanVien CheckLogin(String username, String password)
        {
            String sql = @"SELECT * FROM [NhanVien]";
            return null;
        }
    }
}
