using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.GUI.QuanLyDanhMuc
{
    public partial class MainQuanLy : UserControl
    {
        /*
            1. sách
            2. thể loại
            3. tác giả
            4. nxb
            5. độc giả
            6. nhân viên
        */
        private int choose;
        public MainQuanLy()
        {
            InitializeComponent();
            panelMain.Controls.Add(new Sach());
            choose = 1;
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            if (choose != 1)
            {
                setDefaultBackColor();
                btnSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new Sach());
                choose = 1;
            }
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            if (choose != 2)
            {
                setDefaultBackColor();
                btnTheLoai.BackColor = System.Drawing.SystemColors.ActiveCaption;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new TheLoai());
                choose = 2;
            }
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            if (choose != 3)
            {
                setDefaultBackColor();
                btnTacGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new TacGia());
                choose = 3;
            }
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            if (choose != 4)
            {
                setDefaultBackColor();
                btnNXB.BackColor = System.Drawing.SystemColors.ActiveCaption;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new NXB());
                choose = 4;
            }
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            if (choose != 5)
            {
                setDefaultBackColor();
                btnDocGia.BackColor = System.Drawing.SystemColors.ActiveCaption;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new DocGia());
                choose = 5;
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (choose != 6)
            {
                setDefaultBackColor();
                btnNhanVien.BackColor = System.Drawing.SystemColors.ActiveCaption;
                panelMain.Controls.Clear();
                panelMain.Controls.Add(new NhanVien());
                choose = 6;
            }
        }
        private void setDefaultBackColor()
        {
            // đưa màu các button về mặc định
            btnSach.BackColor = default(Color);
            btnTheLoai.BackColor = default(Color);
            btnTacGia.BackColor = default(Color);
            btnNXB.BackColor = default(Color);
            btnDocGia.BackColor = default(Color);
            btnNhanVien.BackColor = default(Color);
        }
    }
}
