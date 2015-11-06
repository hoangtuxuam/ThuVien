using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThuVien.GUI.BaoCao
{
    public partial class BaoCao : Form
    {

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaoCao
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "BaoCao";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.ResumeLayout(false);

        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
