using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ThuVien.GUI.BaoCao
{
    public partial class DocGia : UserControl
    {
        public DocGia()
        {
            InitializeComponent();
        }



        private void btnHienBaoCao_Click(object sender, EventArgs e)
        {
            if (cbxDocGia.Checked == true)
            {
                String strCon = "server=TRANSACHTHANH\\BACHLYTRANTHANH;database=ThuVien;trusted_connection=true;";
                SqlConnection con = new SqlConnection(strCon);
                con.Open();
                string strSelect = "select * from DocGia";
                SqlDataAdapter da = new SqlDataAdapter(strSelect, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
                grvBaoCao.DataSource = dt;
            }
        }
            
    }
}
