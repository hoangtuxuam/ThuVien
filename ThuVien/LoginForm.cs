using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK==MessageBox.Show("Bạn có thật sự muốn thoát??", "Thoát!!", MessageBoxButtons.OKCancel))
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String err = "";
            if (txtUsername.Text.Trim().Length == 0)
            {
                err += "Tài khoản không được trống!\n";
            }
            
            if (txtPassword.Text.Trim().Length == 0)
            {
                err += "Mật khẩu không được trống!";
            }
            if (err.Trim().Length!=0)
            {
                MessageBox.Show(err, "Lỗi!!");
            }else
            {

            }
        }
    }
}
