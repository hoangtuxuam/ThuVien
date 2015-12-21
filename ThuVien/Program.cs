using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    static class Program
    {
        public static DTO.NhanVien CrNhanVien =null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Session.loginForm = new LoginForm();
            //Application.Run(Session.loginForm);
            Session.splass = new Splass();
            Application.Run(Session.splass);
        }
    }
}
