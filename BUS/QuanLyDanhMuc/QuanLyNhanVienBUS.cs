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
        /// <summary>
        /// lấy ra danh sách nhân viên
        /// </summary>
        /// <returns></returns>
        public List<NhanVien> getListNhanVien()
        {
            return nhanVienDAL.getListNhanVien();
        }
        /// <summary>
        /// thêm nhân viên
        /// </summary>
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool ThemNhanVien(NhanVien nhanVien)
        {
            nhanVien.MatKhau = mh.EncodeMD5(nhanVien.MatKhau);
            return nhanVienDAL.InsertNhanVien(nhanVien);

        }
        /// <summary>
        /// update nhân viên
        /// </summary>
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool suaNhanVien(NhanVien nhanVien)
        {
            if (nhanVien.MatKhau.Length != 0)
            {
                nhanVien.MatKhau = mh.EncodeMD5(nhanVien.MatKhau);
            }
            return nhanVienDAL.updateNhanVien(nhanVien);
        }
        /// <summary>
        /// delete nhân viên
        /// </summary>
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool xoaNhanVien(NhanVien nhanVien)
        {
            return nhanVienDAL.deleteNhanVien(nhanVien);
        }
    }
}
