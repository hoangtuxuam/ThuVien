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
            String sql = @"SELECT [MaPhieu]
                              ,[MaDG]
                              ,[NgayMuon]
                              ,[MaNV]
                          FROM [dbo].[PhieuMuon]";
            return dbcnn.getdata(sql);
        }
        public List<PhieuMuon> getListPhieuMuon()
        {
            String sql = @"SELECT [MaPhieu]
                              ,[MaDG]
                              ,[NgayMuon]
                              ,[MaNV]
                          FROM [dbo].[PhieuMuon]";
            DataTable table = dbcnn.getdata(sql);
            List<PhieuMuon> listDG = new List<PhieuMuon>();
            foreach (DataRow row in table.Rows)
            {
                PhieuMuon newPhieuMuon = new PhieuMuon();
                newPhieuMuon.MaPhieu = (int)row["MaPhieu"];
                //đổ dữ liệu vào độc giả
                newPhieuMuon.docGia.MaDG = (int)row["MaDG"];
                DocGiaDAL dgDAL = new DocGiaDAL();
                newPhieuMuon.docGia = dgDAL.getDocGiaById(newPhieuMuon.docGia.MaDG);

                newPhieuMuon.NgayMuon = (DateTime)row["NgayMuon"];
                //đổ dữ liệu vào nhân viên
                newPhieuMuon.nhanVien.MaNV = (int)row["MaNV"];
                NhanVienDAL nvDAL = new NhanVienDAL();
                newPhieuMuon.nhanVien = nvDAL.getNhanVienByID(newPhieuMuon.nhanVien.MaNV);


                listDG.Add(newPhieuMuon);
            }
            return listDG;
        }

        public bool insertPhieuMuon(PhieuMuon phieu)
        {
            String sql = @"INSERT INTO [dbo].[PhieuMuon]
                               ([MaDG]
                               ,[NgayMuon]
                               ,[MaNV])
                         VALUES
                               (" + phieu.docGia.MaDG + @"
                               ,N'"+phieu.NgayMuon+@"'
                               ," + phieu.nhanVien.MaNV + @")";
            return dbcnn.ThucThiSQL(sql);
        }

        public bool updatePhieuMuon(PhieuMuon phieu)
        {
            String sql = @"UPDATE [dbo].[PhieuMuon]
                           SET [MaDG] = " + phieu.docGia.MaDG + @"
                              ,[NgayMuon] = N'" + phieu.NgayMuon + @"'
                              ,[MaNV] = " + phieu.nhanVien.MaNV + @"
                         WHERE [MaPhieu]=" + phieu.MaPhieu;
            return dbcnn.ThucThiSQL(sql);
        }

        public PhieuMuon getPhieuMuonById(int id)
        {
            String sql = @"SELECT [MaPhieu]
                              ,[MaDG]
                              ,[NgayMuon]
                              ,[MaNV]
                          FROM [dbo].[PhieuMuon] WHERE [MaPhieu]=" + id;
            DataTable table = dbcnn.getdata(sql);
            PhieuMuon newPhieuMuon = new PhieuMuon();
            if (table.Rows.Count == 1)
            {
                newPhieuMuon.MaPhieu = (int)table.Rows[0]["MaPhieu"];
                //đổ dữ liệu vào độc giả
                newPhieuMuon.docGia.MaDG = (int)table.Rows[0]["MaDG"];
                DocGiaDAL dgDAL = new DocGiaDAL();
                newPhieuMuon.docGia = dgDAL.getDocGiaById(newPhieuMuon.docGia.MaDG);

                newPhieuMuon.NgayMuon = (DateTime)table.Rows[0]["NgayMuon"];
                //đổ dữ liệu vào nhân viên
                newPhieuMuon.nhanVien.MaNV = (int)table.Rows[0]["MaNV"];
                NhanVienDAL nvDAL = new NhanVienDAL();
                newPhieuMuon.nhanVien = nvDAL.getNhanVienByID(newPhieuMuon.nhanVien.MaNV);
                //đổ dữ liệu vào sách
            }
            return newPhieuMuon;
        }
        public PhieuMuon getPhieuMuonVuaNhap()
        {
            String sql = @"SELECT TOP(1) [MaPhieu]
                              ,[MaDG]
                              ,[NgayMuon]
                              ,[MaNV]
                          FROM [dbo].[PhieuMuon] ORDER BY [MaPhieu] desc";
            DataTable table = dbcnn.getdata(sql);
            PhieuMuon newPhieuMuon = new PhieuMuon();
            if (table.Rows.Count == 1)
            {
                newPhieuMuon.MaPhieu = (int)table.Rows[0]["MaPhieu"];
                //đổ dữ liệu vào độc giả
                newPhieuMuon.docGia.MaDG = (int)table.Rows[0]["MaDG"];
                DocGiaDAL dgDAL = new DocGiaDAL();
                newPhieuMuon.docGia = dgDAL.getDocGiaById(newPhieuMuon.docGia.MaDG);

                newPhieuMuon.NgayMuon = (DateTime)table.Rows[0]["NgayMuon"];
                //đổ dữ liệu vào nhân viên
                newPhieuMuon.nhanVien.MaNV = (int)table.Rows[0]["MaNV"];
                NhanVienDAL nvDAL = new NhanVienDAL();
                newPhieuMuon.nhanVien = nvDAL.getNhanVienByID(newPhieuMuon.nhanVien.MaNV);
                //đổ dữ liệu vào sách
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
