using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS.MuonTra
{
    public class MuonSachBUS
    {
        DTO.PhieuMuon phieuMuon;
        DTO.CT_PhieuMuon ctPhieu;
        SachDAL sachDAL = new SachDAL();
        DocGiaDAL docGiaDAL = new DocGiaDAL();
        PhieuMuonDAL phieuMuonDAL;
        CT_PhieuMuonDAL ctPhieuDAL;
        public Sach layThongTinSach(int maSach)
        {
            return sachDAL.getSachById(maSach);
        }
        public DocGia layThongTinDocGia(int maDocGia)
        {
            return docGiaDAL.getDocGiaById(maDocGia);
        }
        /// <summary>
        /// ham cho muon sach. neu cho muon thanh cong tra ve true. nguoc lai la false
        /// </summary>
        /// <param name="maSach">Mã Sách</param>
        /// <param name="maDocGia">Mã Độc Giả</param>
        /// <returns></returns>
        public bool choMuon(int maSach,int maDocGia,int maNV)
        {
            ctPhieuDAL = new CT_PhieuMuonDAL();
            phieuMuonDAL = new PhieuMuonDAL();
            //đổ dữ liệu vào mã phiếu mượn
            phieuMuon = new PhieuMuon();
            phieuMuon.docGia.MaDG = maDocGia;
            phieuMuon.NgayMuon = DateTime.Now;
            phieuMuon.nhanVien.MaNV = maNV;
            if (!phieuMuonDAL.insertPhieuMuon(phieuMuon)) return false;

            ctPhieu = new CT_PhieuMuon();
            ctPhieu.phieuMuon = phieuMuonDAL.getPhieuMuonVuaNhap();
            ctPhieu.sach.MaSach = maSach;
            ctPhieu.HanTra = DateTime.Now.AddDays(30);
            if (!ctPhieuDAL.insertCT_PhieuMuon(ctPhieu)) return false;
            return true;
        }

        public bool conSach(int id)
        {
            int TongSoSach = sachDAL.getSachById(id).SoLuong;
            ThongKeDAL thongke = new ThongKeDAL();
            int DangChoMuon = thongke.SoSachDangChoMuon(id);
            if (TongSoSach > DangChoMuon) return true;
            return false;
        }
    }
}
