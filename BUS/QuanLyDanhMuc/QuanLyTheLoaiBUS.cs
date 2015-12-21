using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;
using System.Threading.Tasks;

namespace BUS.QuanLyDanhMuc
{
    public class QuanLyTheLoaiBUS
    {
        TheLoaiDAL theLoaiDAL = new TheLoaiDAL();
        public bool themTheLoai(TheLoai theLoai)
        {
            return theLoaiDAL.insertTheLoai(theLoai);
        }
        public bool suaTheLoai(TheLoai theLoai)
        {
            return theLoaiDAL.updateTheLoai(theLoai);
        }
        public bool xoaTheLoai(TheLoai theLoai)
        {
            return theLoaiDAL.deleteTheLoai(theLoai);
        }
        public List<TheLoai> getListTheLoai()
        {
            return theLoaiDAL.getListTheLoai();
        }
    }
}
