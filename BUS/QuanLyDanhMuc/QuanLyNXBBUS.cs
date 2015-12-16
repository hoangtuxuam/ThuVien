using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAL;
using System.Threading.Tasks;

namespace BUS.QuanLyDanhMuc
{
    public class QuanLyNXBBUS
    {
        nxbDAL xnbDAL = new nxbDAL();
        public bool themNXB(NXB theLoai)
        {
            return xnbDAL.insertNXB(theLoai);
        }
        public bool suaNXB(NXB theLoai)
        {
            return xnbDAL.updateNXB(theLoai);
        }
        public bool xoaNXB(NXB theLoai)
        {
            return xnbDAL.deleteNXB(theLoai);
        }
        public List<NXB> getListNXB()
        {
            return xnbDAL.getListNXB();
        }
    }
}
