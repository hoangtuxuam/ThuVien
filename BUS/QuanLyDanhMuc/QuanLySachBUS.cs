using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;

namespace BUS.QuanLyDanhMuc
{
    public class QuanLySachBUS
    {
        SachDAL sachDAL;
        public List<TheLoai> getListTheLoai()
        {
            TheLoaiDAL theLoai = new TheLoaiDAL();
            return theLoai.getListTheLoai();
        }
        public List<NXB> getListNXB()
        {
            nxbDAL nxb = new nxbDAL();
            return nxb.getListNXB();
        }
        public List<TacGia> getListTacGia()
        {
            TacGiaDAL tacGia = new TacGiaDAL();
            return tacGia.getListTacGia();
        }
        public List<Sach> getListSach()
        {
            sachDAL = new SachDAL();
            List<Sach> listSach = sachDAL.getListSach();
            return sachDAL.getListSach();
        }
        public bool ThemSach(Sach sach)
        {
            return sachDAL.insertSach(sach);
        }
        public bool suaSach(Sach sach)
        {
            return sachDAL.updateSach(sach);
        }
        public bool xoaSach(Sach sach)
        {
            return sachDAL.deleteSach(sach);
        }
    }
}
