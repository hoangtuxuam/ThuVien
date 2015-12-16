using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class PhieuMuonDAL
    {
        PhieuMuon phieu = new PhieuMuon();
        ConnectDB dbcnn = new ConnectDB();
        public DataTable getTablePhieuMuon()
        {
            String sql = @"select * from viewSach";
            return dbcnn.getdata(sql);
        }
        public List<PhieuMuon> getListPhieuMuon()
        {
            String sql = @"select * from viewSach";
            DataTable table = dbcnn.getdata(sql);
            List<PhieuMuon> listDG = new List<PhieuMuon>();
            foreach (DataRow row in table.Rows)
            {
                PhieuMuon newPhieuMuon = new PhieuMuon();
                newPhieuMuon.MaPhieu = (int)row["MaPhieuMuon"];
                //đổ dữ liệu vào độc giả
                newPhieuMuon.docGia.MaDG = (int)row["MaDG"];
                newPhieuMuon.docGia.HoTenDG = (string)row["HoTenDG"];
                newPhieuMuon.docGia.EmailDG = (string)row["EmailDG"];
                newPhieuMuon.docGia.GioiTinhDG = (bool)row["GioiTinhDG"];
                newPhieuMuon.docGia.NgaysinhDG = (DateTime)row["NgaysinhDG"];
                newPhieuMuon.docGia.DiachiDG = (string)row["DiachiDG"];
                newPhieuMuon.docGia.DienthoaiDG = (string)row["DienthoaiDG"];
                newPhieuMuon.docGia.NgayLamThe = (DateTime)row["NgayLamThe"];
                newPhieuMuon.docGia.NgayHetHan = (DateTime)row["NgayHetHan"];
                newPhieuMuon.docGia.HoatDong = (bool)row["HoatDong"];

                newPhieuMuon.NgayMuon = (DateTime)row["NgayMuon"];
                //đổ dữ liệu vào nhân viên
                newPhieuMuon.nhanVien.MaNV = (int)row["MaNV"];
                newPhieuMuon.nhanVien.HoTenNV = (string)row["HoTenNV"];
                newPhieuMuon.nhanVien.GioiTinhNV = (bool)row["GioiTinhNV"];
                newPhieuMuon.nhanVien.NgaySinhNV = (DateTime)row["NgaySinhNV"];
                newPhieuMuon.nhanVien.DienThoaiNV = (string)row["DienThoaiNV"];
                newPhieuMuon.nhanVien.DiaChiNV = (string)row["DiaChiNV"];
                newPhieuMuon.nhanVien.EmailNV = (string)row["EmailNV"];
                newPhieuMuon.nhanVien.NgayVaoLam = (DateTime)row["NgayVaoLam"];
                newPhieuMuon.nhanVien.MatKhau = (string)row["MatKhau"];
                newPhieuMuon.nhanVien.QuyenHan = (bool)row["QuyenHan"];
                //đổ dữ liệu vào sách
                newPhieuMuon.sach.MaSach = (int)row["MaSach"];
                newPhieuMuon.sach.TenSach = (string)row["TenSach"];
                newPhieuMuon.sach.NoiDungTT = (string)row["NoiDungTT"];
                newPhieuMuon.sach.SoTrang = (int)row["SoTrang"];
                newPhieuMuon.sach.Gia = (int)row["Gia"];
                newPhieuMuon.sach.SoLuong = (int)row["SoLuong"];
                newPhieuMuon.sach.NgayNhap = (DateTime)row["NgayNhap"];
                    newPhieuMuon.sach.nxb.MaNXB = (int)row["MaNXB"];
                    newPhieuMuon.sach.nxb.TenNXB = (string)row["TenNXB"];
                    newPhieuMuon.sach.nxb.DiaChiNXB = (string)row["DiaChiNXB"];
                    newPhieuMuon.sach.nxb.DienThoaiNXB = (string)row["DienThoaiNXB"];
                    newPhieuMuon.sach.nxb.Website = (string)row["Website"];
                newPhieuMuon.sach.tacGia.MaTG = (int)row["MaTG"];
                newPhieuMuon.sach.tacGia.HoTenTG = (string)row["HoTenTG"];
                newPhieuMuon.sach.tacGia.DiaChiTG = (string)row["DiaChiTG"];
                newPhieuMuon.sach.tacGia.DienThoaiTG = (string)row["DienThoaiTG"];
                    newPhieuMuon.sach.theLoai.MaTL = (int)row["MaTL"];
                    newPhieuMuon.sach.theLoai.TenTL = (string)row["TenTL"];
                    newPhieuMuon.sach.theLoai.GhiChu = (string)row["GhiChu"];
                newPhieuMuon.sach.TinhTrang = (bool)row["TinhTrang"];
                
                newPhieuMuon.HanTra = (DateTime)row["HanTra"];
                listDG.Add(newPhieuMuon);
            }
            return listDG;
        }

        public bool insertPhieuMuon(PhieuMuon phieu)
        {
            String sql = @"INSERT INTO [dbo].[PhieuMuon]
                               ([MaDG]
                               ,[NgayMuon]
                               ,[MaNV]
                               ,[MaSach]
                               ,[HanTra])
                         VALUES
                               (" + phieu.docGia.MaDG + @"
                               ,N'"+phieu.NgayMuon+@"'
                               ," + phieu.nhanVien.MaNV + @"
                               ," + phieu.sach.MaSach + @"
                               ,'"+phieu.HanTra+@"')";
            return dbcnn.ThucThiSQL(sql);
        }

        public bool updatePhieuMuon(PhieuMuon phieu)
        {
            String sql = @"UPDATE [dbo].[PhieuMuon]
                           SET [MaDG] = " + phieu.docGia.MaDG + @"
                              ,[NgayMuon] = N'" + phieu.NgayMuon + @"'
                              ,[MaNV] = " + phieu.nhanVien.MaNV + @"
                              ,[MaSach] = " + phieu.sach.MaSach + @"
                              ,[HanTra] = N'" + phieu.HanTra + @"'
                         WHERE [MaPhieu]=" + phieu.MaPhieu;
            return dbcnn.ThucThiSQL(sql);
        }

        public PhieuMuon getPhieuMuonById(int id)
        {
            String sql = @"select * from viewPhieuMuon WHERE [MaPhieuMuon]=" + id;
            DataTable table = dbcnn.getdata(sql);
            PhieuMuon newPhieuMuon = new PhieuMuon();
            if (table.Rows.Count == 1)
            {
                newPhieuMuon.MaPhieu = (int)table.Rows[0]["MaPhieuMuon"];
                //đổ dữ liệu vào độc giả
                newPhieuMuon.docGia.MaDG = (int)table.Rows[0]["MaDG"];
                newPhieuMuon.docGia.HoTenDG = (string)table.Rows[0]["HoTenDG"];
                newPhieuMuon.docGia.EmailDG = (string)table.Rows[0]["EmailDG"];
                newPhieuMuon.docGia.GioiTinhDG = (bool)table.Rows[0]["GioiTinhDG"];
                newPhieuMuon.docGia.NgaysinhDG = (DateTime)table.Rows[0]["NgaysinhDG"];
                newPhieuMuon.docGia.DiachiDG = (string)table.Rows[0]["DiachiDG"];
                newPhieuMuon.docGia.DienthoaiDG = (string)table.Rows[0]["DienthoaiDG"];
                newPhieuMuon.docGia.NgayLamThe = (DateTime)table.Rows[0]["NgayLamThe"];
                newPhieuMuon.docGia.NgayHetHan = (DateTime)table.Rows[0]["NgayHetHan"];
                newPhieuMuon.docGia.HoatDong = (bool)table.Rows[0]["HoatDong"];

                newPhieuMuon.NgayMuon = (DateTime)table.Rows[0]["NgayMuon"];
                //đổ dữ liệu vào nhân viên
                newPhieuMuon.nhanVien.MaNV = (int)table.Rows[0]["MaNV"];
                newPhieuMuon.nhanVien.HoTenNV = (string)table.Rows[0]["HoTenNV"];
                newPhieuMuon.nhanVien.GioiTinhNV = (bool)table.Rows[0]["GioiTinhNV"];
                newPhieuMuon.nhanVien.NgaySinhNV = (DateTime)table.Rows[0]["NgaySinhNV"];
                newPhieuMuon.nhanVien.DienThoaiNV = (string)table.Rows[0]["DienThoaiNV"];
                newPhieuMuon.nhanVien.DiaChiNV = (string)table.Rows[0]["DiaChiNV"];
                newPhieuMuon.nhanVien.EmailNV = (string)table.Rows[0]["EmailNV"];
                newPhieuMuon.nhanVien.NgayVaoLam = (DateTime)table.Rows[0]["NgayVaoLam"];
                newPhieuMuon.nhanVien.MatKhau = (string)table.Rows[0]["MatKhau"];
                newPhieuMuon.nhanVien.QuyenHan = (bool)table.Rows[0]["QuyenHan"];
                //đổ dữ liệu vào sách
                newPhieuMuon.sach.MaSach = (int)table.Rows[0]["MaSach"];
                newPhieuMuon.sach.TenSach = (string)table.Rows[0]["TenSach"];
                newPhieuMuon.sach.NoiDungTT = (string)table.Rows[0]["NoiDungTT"];
                newPhieuMuon.sach.SoTrang = (int)table.Rows[0]["SoTrang"];
                newPhieuMuon.sach.Gia = (int)table.Rows[0]["Gia"];
                newPhieuMuon.sach.SoLuong = (int)table.Rows[0]["SoLuong"];
                newPhieuMuon.sach.NgayNhap = (DateTime)table.Rows[0]["NgayNhap"];
                    newPhieuMuon.sach.nxb.MaNXB = (int)table.Rows[0]["MaNXB"];
                    newPhieuMuon.sach.nxb.TenNXB = (string)table.Rows[0]["TenNXB"];
                    newPhieuMuon.sach.nxb.DiaChiNXB = (string)table.Rows[0]["DiaChiNXB"];
                    newPhieuMuon.sach.nxb.DienThoaiNXB = (string)table.Rows[0]["DienThoaiNXB"];
                    newPhieuMuon.sach.nxb.Website = (string)table.Rows[0]["Website"];
                    newPhieuMuon.sach.tacGia.MaTG = (int)table.Rows[0]["MaTG"];
                newPhieuMuon.sach.tacGia.HoTenTG = (string)table.Rows[0]["HoTenTG"];
                newPhieuMuon.sach.tacGia.DiaChiTG = (string)table.Rows[0]["DiaChiTG"];
                newPhieuMuon.sach.tacGia.DienThoaiTG = (string)table.Rows[0]["DienThoaiTG"];
                    newPhieuMuon.sach.theLoai.MaTL = (int)table.Rows[0]["MaTL"];
                    newPhieuMuon.sach.theLoai.TenTL = (string)table.Rows[0]["TenTL"];
                    newPhieuMuon.sach.theLoai.GhiChu = (string)table.Rows[0]["GhiChu"];
                newPhieuMuon.sach.TinhTrang = (bool)table.Rows[0]["TinhTrang"];

                newPhieuMuon.HanTra = (DateTime)table.Rows[0]["HanTra"];
            }
            return newPhieuMuon;
        }

        public bool deletePhieuMuon(PhieuMuon phieu)
        {
            String sql = @"DELETE FROM [dbo].[PhieuMuon]
                         WHERE [MaPhieu]=" + phieu.MaPhieu;
            return dbcnn.ThucThiSQL(sql);
        }

    }
}
