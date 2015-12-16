using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS.QuanLyDanhMuc
{
    public class QuanLyTacGiaBUS
    {
        TacGiaDAL tacGiaDAL = new TacGiaDAL();
        public bool themtacGia(TacGia tacGia)
        {
            return tacGiaDAL.insertTacGia(tacGia);
        }
        public bool suatacGia(TacGia tacGia)
        {
            return tacGiaDAL.updateTacGia(tacGia);
        }
        public bool xoatacGia(TacGia tacGia)
        {
            return tacGiaDAL.deleteTacGia(tacGia);
        }
        public List<TacGia> getListtacGia()
        {
            return tacGiaDAL.getListTacGia();
        }
    }
}
