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
        Validate validate = new BUS.Validate();
        BUS.MuonTra.MuonSachBUS muonSachBUS = new BUS.MuonTra.MuonSachBUS();
        public MuonSach()
        {
            InitializeComponent();
        }

        private void btnLayTTSach_Click(object sender, EventArgs e)
        {
            if (txtMasach.Text.Trim().Length!=0&&validate.IsNumber(txtMasach.Text.Trim()))
            {
                masach = Convert.ToInt16(txtMasach.Text.Trim());
                sach = muonSachBUS.layThongTinSach(masach);
                if (sach == null)
                {
                    MessageBox.Show("mã sách bạn vừa nhập không đúng");
                    masach = 0;
                }
                else
                if(muonSachBUS.conSach(masach))
                {
                    MessageBox.Show("tìm thấy sách!");
                    lblTenSach.Text = "Tên Sách: " + sach.TenSach;
                    lblGia.Text = "Giá: " + sach.Gia;
                    lblNXB.Text = "NXB: " + sach.nxb.TenNXB;
                    lblTacGia.Text = "Tác Giả: " + sach.tacGia.HoTenTG;
                    lblTheLoai.Text = "Thể Loại: " + sach.theLoai.TenTL;
                }
                else
                {
                    MessageBox.Show("Sách này đã hết!");
                }
            }
            else
            {
                if (txtMasach.Text.Trim().Length == 0) MessageBox.Show("bạn chưa nhập mã sách");
                else
                {
                    MessageBox.Show("Mã sách phải là số!");
                    txtMasach.Text = "";
                }
            }
        }
        private void btnLayTTDocGia_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text.Trim().Length != 0 && validate.IsNumber(txtMaDocGia.Text.Trim()))
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
                    MessageBox.Show("tìm thấy độc giả!");
                    lblTenDocGia.Text = "Tên Độc Giả: " + docGia.HoTenDG;
                    lblDiaChi.Text = "Địa Chỉ: " + docGia.DiachiDG;
                    lblEmail.Text = "Email: " + docGia.EmailDG;
                    lblDienThoai.Text = "Điện Thoại: " + docGia.DienthoaiDG;
                } 
            }
            else
            {
                if (txtMaDocGia.Text.Trim().Length == 0) MessageBox.Show("bạn chưa nhập mã độc giả");
                else
                {
                    MessageBox.Show("Mã độc giả phải là số!");
                    txtMaDocGia.Text = "";
                }
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
            if (txtMaDocGia.Text.Trim().Length!=0&&validate.IsNumber(txtMaDocGia.Text.Trim()))
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
                    if (docGia.HoatDong&&DateTime.Compare(docGia.NgayHetHan,DateTime.Now)>0)
                    {
                        lblTenDocGia.Text = "Tên Độc Giả: " + docGia.HoTenDG;
                        lblDiaChi.Text = "Địa Chỉ: " + docGia.DiachiDG;
                        lblEmail.Text = "Email: " + docGia.EmailDG;
                        lblDienThoai.Text = "Điện Thoại: " + docGia.DienthoaiDG;
                    }
                    else
                    {
                        if (!docGia.HoatDong)
                            MessageBox.Show("Độc Giả không được phép mượn sách");
                        else MessageBox.Show("Thẻ đã hết hạn");
                    }
                }
            }
            else
            {
                if (txtMaDocGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("mã độc giả không được trống");
                }
                else
                {
                    MessageBox.Show("mã độc giả phải là số");
                }
            }
        }
    }
}
