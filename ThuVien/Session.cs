using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    static class Session
    {
        public static DTO.NhanVien cNhanVien;
        public static LoginForm loginForm;
        public static MainForm mainForm;
        public static Splass splass;
        public static void closeAllForm()
        {
            //mainForm.Close();
            loginForm.Close();
            splass.Close();
        }
    }
}
