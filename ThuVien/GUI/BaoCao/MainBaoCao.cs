using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace ThuVien.GUI.BaoCao
{
    public partial class MainBaoCao : UserControl
    {
        BUS.ThongKe.ThongkeBUS thongKeBUS = new BUS.ThongKe.ThongkeBUS();
        public MainBaoCao()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            grvPhieuChuaTra.DataSource = thongKeBUS.thongKePhieuMuon();
            grvDocGia.DataSource = thongKeBUS.ThongKeDocGiaDangMuon();
            grvSach.DataSource = thongKeBUS.ThongKeSachDangChoMuon();
            grvPhieuDaTra.DataSource = thongKeBUS.thongKeDaTra();
            txtPhieuMuon.Text = "Có " + (grvPhieuChuaTra.RowCount-1) + " phiếu mượn chưa trả";
            lblDaTra.Text = "Có " + (grvPhieuDaTra.RowCount - 1) + " phiếu mượn đã trả";
            lblsoDocGia.Text = "Có " + (grvDocGia.RowCount-1) + " độc giả đang mượn sách";
        }

        private void xemChiTietDocGiaDangMuon(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt16(grvSach.Rows[e.RowIndex].Cells[0].Value);
            MessageBox.Show(thongKeBUS.DanhSachDocGiaMuonByID(id), "Danh Sách Độc Giả Đang Mượn Sách"+ grvSach.Rows[e.RowIndex].Cells[1].Value);
        }

        private void xemChiTietSachDangMuon(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt16(grvDocGia.Rows[e.RowIndex].Cells[0].Value);
            MessageBox.Show(thongKeBUS.SachDangMuonByID(id),"Danh Sách các sách "+ grvDocGia.Rows[e.RowIndex].Cells[0].Value+" đang mượn");
        }
    }
}
