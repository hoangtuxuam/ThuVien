using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace ThuVien
{
    public partial class LoginForm : Form
    {
        loginBUS loginBus = new loginBUS();
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
            if(err.Length==0)
            {
                Session.cNhanVien = new DTO.NhanVien();
                Session.cNhanVien = loginBus.CheckLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (Session.cNhanVien == null) MessageBox.Show("tên đăng nhập hoặc mật khẩu không đúng");
                else
                {
                    MessageBox.Show("đăng nhập thành công!!");
                    MainForm main = new MainForm();
                    main.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(err);
            }
        }
    }
}
