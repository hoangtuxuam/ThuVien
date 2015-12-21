using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUS.MuonTra
{
    public class TraSach
    {
        /// <summary>
        /// lấy thông tin phiếu mượn bằng mã phiếu mượn
        /// </summary>
        /// <param name="maPhieu"></param>
        /// <returns></returns>
        public CT_PhieuMuon getCTPhieu(int maPhieu)
        {
            CT_PhieuMuon ctPhieu = new CT_PhieuMuon();
            CT_PhieuMuonDAL ctPhieuDAL = new CT_PhieuMuonDAL();
            ctPhieu = ctPhieuDAL.getCT_PhieuMuonById(maPhieu);
            return ctPhieu;
        }
        /// <summary>
        /// update table trả sách
        /// </summary>
        /// <param name="tra"></param>
        /// <returns></returns>
        public bool tra(DTO.TraSach tra)
        {
            TraSachDAL traDAL = new TraSachDAL();
            traDAL.insertTraSach(tra);
            return true;
        }
        /// <summary>
        /// kiểm tra phiếu mượn đã được
        /// </summary>
        /// <param name="maPhieu"></param>
        /// <returns></returns>
        public bool daTra(int maPhieu)
        {
            TraSachDAL traDAL = new TraSachDAL();
            if (traDAL.getTraSachByMaPhieuMuon(maPhieu) == null) return false;
            return true;
        }
    }
}
