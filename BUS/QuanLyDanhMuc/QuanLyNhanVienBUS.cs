using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS.QuanLyDanhMuc
{
    public class QuanLyNhanVienBUS
    {
        NhanVienDAL nhanVienDAL;
        MaHoa mh = new MaHoa();
        public QuanLyNhanVienBUS()
        {
            nhanVienDAL = new NhanVienDAL();
        }
        public List<NhanVien> getListNhanVien()
        {
            return nhanVienDAL.getListNhanVien();
        }
        public bool ThemNhanVien(NhanVien nhanVien)
        {
            nhanVien.MatKhau = mh.EncodeMD5(nhanVien.MatKhau);
            return nhanVienDAL.InsertNhanVien(nhanVien);

        }
        public bool suaNhanVien(NhanVien nhanVien)
        {
            if (nhanVien.MatKhau.Length != 0)
            {
                nhanVien.MatKhau = mh.EncodeMD5(nhanVien.MatKhau);
            }
            return nhanVienDAL.updateNhanVien(nhanVien);
        }
        public bool xoaNhanVien(NhanVien nhanVien)
        {
            return nhanVienDAL.deleteNhanVien(nhanVien);
        }
    }
}
