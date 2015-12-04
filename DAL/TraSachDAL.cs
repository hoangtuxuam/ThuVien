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
    class TraSachDAL
    {
        TraSach traSach = new TraSach();
        ConnectDB dbcnn = new ConnectDB();
        public DataTable getTableTraSach()
        {
            String sql = @"SELECT [MaPhieu]
                              ,[MaPhieuMuon]
                              ,[MaNV]
                              ,[NgayTra]
                              ,[PhatHuHong]
                              ,[PhatQuaHan]
                          FROM [dbo].[TraSach]";
            return dbcnn.getdata(sql);
        }
        public List<TraSach> getListTraSach()
        {
            String sql = @"SELECT [MaPhieu]
                              ,[MaPhieuMuon]
                              ,[MaNV]
                              ,[NgayTra]
                              ,[PhatHuHong]
                              ,[PhatQuaHan]
                          FROM [dbo].[TraSach]";
            DataTable table = dbcnn.getdata(sql);
            List<TraSach> listTG = new List<TraSach>();
            foreach (DataRow row in table.Rows)
            {
                TraSach newTraSach = new TraSach();
                newTraSach.MaPhieu = (int)row["MaPhieu"];
                newTraSach.phieuMuon.MaPhieu = (int)row["MaPhieu"];
                PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();
                newTraSach.phieuMuon = phieuMuonDAL.getPhieuMuonById(newTraSach.phieuMuon.MaPhieu);
                newTraSach.nhanVien.MaNV = (int)row["MaNV"];
                NhanVienDAL nhanVienDAL = new NhanVienDAL();
                newTraSach.nhanVien = nhanVienDAL.getNhanVienById(newTraSach.nhanVien.MaNV);
                newTraSach.NgayTra = (DateTime)row["NgayTra"];
                newTraSach.PhatHuHong = (int)row["PhatHuHong"];
                newTraSach.PhatQuaHan = (int)row["PhatQuaHan"];
                listTG.Add(newTraSach);
            }
            return listTG;
        }

        public bool insertTraSach(TraSach traSach)
        {
            String sql = @"INSERT INTO [dbo].[TraSach]
                               ([MaPhieuMuon]
                               ,[MaNV]
                               ,[NgayTra]
                               ,[PhatHuHong]
                               ,[PhatQuaHan])
                         VALUES
                               ("+traSach.MaPhieu+ @"
                               ," + traSach.MaPhieu + @"
                               ,'" + traSach.NgayTra + @"'
                               ," + traSach.PhatHuHong + @"
                               ," + traSach.PhatQuaHan + @")";
            return dbcnn.ThucThiSQL(sql);
        }

        public bool updateTraSach(TraSach traSach)
        {
            String sql = @"UPDATE [dbo].[TraSach]
                           SET [MaPhieuMuon] = " + traSach.MaPhieu + @"
                              ,[MaNV] = " + traSach.nhanVien.MaNV + @"
                              ,[NgayTra] = '" + traSach.NgayTra + @"'
                              ,[PhatHuHong] = " + traSach.PhatHuHong + @"
                              ,[PhatQuaHan] = " + traSach.PhatQuaHan + @"
                         WHERE [MaPhieu]=" + traSach.MaPhieu;
            return dbcnn.ThucThiSQL(sql);
        }

        public TraSach getTraSachById(int id)
        {
            String sql = @"SELECT [MaPhieu]
                              ,[MaPhieuMuon]
                              ,[MaNV]
                              ,[NgayTra]
                              ,[PhatHuHong]
                              ,[PhatQuaHan]
                          FROM [dbo].[TraSach] WHERE [MaPhieu]=" + id;
            DataTable table = dbcnn.getdata(sql);
            TraSach newTraSach = new TraSach();
            if (table.Rows.Count == 1)
            {
                newTraSach.MaPhieu = (int)table.Rows[0]["MaTG"];
                newTraSach.phieuMuon.MaPhieu = (int)table.Rows[0]["MaPhieu"];
                PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();
                newTraSach.phieuMuon = phieuMuonDAL.getPhieuMuonById(newTraSach.phieuMuon.MaPhieu);
                newTraSach.nhanVien.MaNV = (int)table.Rows[0]["MaNV"];
                NhanVienDAL nhanVienDAL = new NhanVienDAL();
                newTraSach.nhanVien = nhanVienDAL.getNhanVienById(newTraSach.nhanVien.MaNV);
                newTraSach.NgayTra = (DateTime)table.Rows[0]["NgayTra"];
                newTraSach.PhatHuHong = (int)table.Rows[0]["PhatHuHong"];
                newTraSach.PhatQuaHan = (int)table.Rows[0]["PhatQuaHan"];
            }
            return newTraSach;
        }
    }
}
