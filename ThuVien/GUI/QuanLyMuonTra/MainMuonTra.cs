using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.GUI.QuanLyMuonTra
{
    public partial class MainMuonTra : UserControl
    {
        /*
            1. Mượn
            2. trả
        */
        private int choose;
        public MainMuonTra()
        {
            InitializeComponent();
            pnlMain.Controls.Add(new MuonSach());
            choose = 1;
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            if (choose != 1)
            {
                setDefaultBackColor();
                btnMuon.BackColor = System.Drawing.SystemColors.ActiveCaption;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(new MuonSach());
                choose = 1;
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            if (choose != 2)
            {
                setDefaultBackColor();
                btnTra.BackColor = System.Drawing.SystemColors.ActiveCaption;
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(new MuonSach());
                choose = 2;
            }
        }

        private void setDefaultBackColor()
        {
            // đưa màu các button về mặc định
            btnMuon.BackColor = default(Color);
            btnTra.BackColor = default(Color);
        }
    }
}
