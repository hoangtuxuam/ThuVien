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
            //chuỗi lỗi
            String err = "";
            if (txtUsername.Text.Trim().Length == 0)
            {
                //nếu tài khoản trống thì thêm lỗi vào err
                err += "Tài khoản không được trống!\n";
            }
            else
            {
                BUS.Validate val = new BUS.Validate();
                //kiểm tra email có đúng định dạng không
                if (!val.IsEmail(txtUsername.Text.Trim()))
                    err += "tài khoản phải là email";
            }
            
            if (txtPassword.Text.Trim().Length == 0)
            {
                //nếu mật khẩu trống thì thêm lỗi vào err
                err += "Mật khẩu không được trống!";
            }

            if(err.Length==0)
            {
                Session.cNhanVien = new DTO.NhanVien();
                Session.cNhanVien = loginBus.CheckLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                //nếu cNhanVien trống thì báo không thành công
                if (Session.cNhanVien == null) MessageBox.Show("tên đăng nhập hoặc mật khẩu không đúng");
                else
                {
                    MessageBox.Show("đăng nhập thành công!!");
                    Session.mainForm = new MainForm();
                    Session.mainForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show(err);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }

        private void DongChuongTrinh(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn có thật sự muốn thoát??", "Thoát!!", MessageBoxButtons.OKCancel))
            {
                Application.Exit();
            }
        }
    }
}
