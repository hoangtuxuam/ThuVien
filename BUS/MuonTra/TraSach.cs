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
        public CT_PhieuMuon getCTPhieu(int maPhieu)
        {
            CT_PhieuMuon ctPhieu = new CT_PhieuMuon();
            CT_PhieuMuonDAL ctPhieuDAL = new CT_PhieuMuonDAL();
            ctPhieu = ctPhieuDAL.getCT_PhieuMuonById(maPhieu);
            return ctPhieu;
        }
        public bool tra(DTO.TraSach tra)
        {
            TraSachDAL traDAL = new TraSachDAL();
            traDAL.insertTraSach(tra);
            return true;
        }
    }
}
