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
        NhanVienDAL nvDAL = new NhanVienDAL();
        public NhanVien CheckLogin(String username, String password)
        {
            MaHoa mh = new MaHoa();
            password = mh.EncodeMD5(password);
            if (nvDAL.chekLogin(username, password))
            {
                return nvDAL.getNhanVienByUsername(username);
            }
            return null;
        }
    }
}
