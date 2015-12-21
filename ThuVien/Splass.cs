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
    public partial class Splass : Form
    {
        public Splass()
        {
            InitializeComponent();
        }

        private void close(object sender, EventArgs e)
        {
            timer1.Stop();
            Session.loginForm = new LoginForm();
            this.Hide();
            Session.loginForm = new LoginForm();
            Session.loginForm.Show();
        }

        private void load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            timer1.Start();
        }
    }
}
