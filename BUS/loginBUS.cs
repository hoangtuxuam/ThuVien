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
        /// <summary>
        /// trả về nhân viên nếu đăng nhập thành công
        /// </summary>
        /// <param name="username">tên đăng nhập</param>
        /// <param name="password">mật khẩu</param>
        /// <returns></returns>
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
