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

namespace ThuVien.GUI.QuanLyMuonTra
{
    public partial class MuonSach : UserControl
    {
        DTO.Sach sach;
        DTO.DocGia docGia;
        int masach;
        int maDocGia;
        BUS.MuonTra.MuonSachBUS muonSachBUS = new BUS.MuonTra.MuonSachBUS();
        public MuonSach()
        {
            InitializeComponent();
        }

        private void btnLayTTSach_Click(object sender, EventArgs e)
        {
            masach = Convert.ToInt16(txtMasach.Text.Trim());
            sach = muonSachBUS.layThongTinSach(masach);
            if (sach == null)
            {
                MessageBox.Show("mã sách bạn vừa nhập không đúng");
                masach = 0;
            }
            else
            {
                lblTenSach.Text = "Tên Sách: " + sach.TenSach;
                lblGia.Text = "Giá: " + sach.Gia;
                lblNXB.Text = "NXB: " + sach.nxb.TenNXB;
                lblTheLoai.Text = "Thể Loại: " + sach.theLoai.TenTL;
            }
        }
        private void btnLayTTDocGia_Click(object sender, EventArgs e)
        {
            maDocGia = Convert.ToInt16(txtMaDocGia.Text.Trim());
            docGia = muonSachBUS.layThongTinDocGia(maDocGia);
            if (docGia == null)
            {
                MessageBox.Show("Mã độc giả bạn vừa nhập không đúng");
                maDocGia = 0;
            }
            else
            {
                lblTenDocGia.Text = "Tên Độc Giả: " + docGia.HoTenDG;
                lblDiaChi.Text = "Địa Chỉ: " + docGia.DiachiDG;
                lblEmail.Text = "Email: " + docGia.EmailDG;
                lblDienThoai.Text = "Điện Thoại: " + docGia.DienthoaiDG;
            }
        }

        private void btnChoMuon_Click(object sender, EventArgs e)
        {
            if (masach != 0 && maDocGia != 0)
            {
                if (muonSachBUS.choMuon(masach, maDocGia, Session.cNhanVien.MaNV))
                {
                    MessageBox.Show("cho mượn thành công!");
                }
                else
                {
                    MessageBox.Show("cho mượn thất bại!");
                }
            }
            else if (masach == 0) MessageBox.Show("Chưa chọn sách");
            else MessageBox.Show("chưa chọn độc giả");
        }

        private void btnLayTTDocGia_Click_1(object sender, EventArgs e)
        {
            maDocGia = Convert.ToInt16(txtMaDocGia.Text.Trim());
            docGia = muonSachBUS.layThongTinDocGia(maDocGia);
            if (docGia == null)
            {
                MessageBox.Show("Mã độc giả bạn vừa nhập không đúng");
                maDocGia = 0;
            }
            else
            {
                lblTenDocGia.Text = "Tên Độc Giả: " + docGia.HoTenDG;
                lblDiaChi.Text = "Địa Chỉ: " + docGia.DiachiDG;
                lblEmail.Text = "Email: " + docGia.EmailDG;
                lblDienThoai.Text = "Điện Thoại: " + docGia.DienthoaiDG;
            }
        }
    }
}
