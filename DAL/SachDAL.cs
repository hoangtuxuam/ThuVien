using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SachDAL
    {
        Sach sach = new Sach();
        ConnectDB dbcnn = new ConnectDB();
        public DataTable getTableSach()
        {
            //string sql = @"select [masach]
            //              ,[tensach]
            //              ,[noidungtt]
            //              ,[sotrang]
            //              ,[gia]
            //              ,[soluong]
            //              ,[ngaynhap]
            //              ,[nxb].[manxb]
            //           ,[tennxb]
            //              ,[diachinxb]
            //              ,[dienthoainxb]
            //              ,[website]
            //              ,[tacgia].[matg]
            //           ,[hotentg]
            //              ,[diachitg]
            //              ,[dienthoaitg]
            //              ,[theloai].[matl]
            //           ,[tentl]
            //              ,[ghichu]
            //              ,[tinhtrang]
            //          from [dbo].[sach] join [nxb] on [sach].manxb = nxb.manxb
            //           join tacgia on [tacgia].matg = sach.matg 
            //           join [theloai] on [theloai].matl = sach.matl";
            string sql = "select * from viewSach";
            return dbcnn.getdata(sql);
        }
        public List<Sach> getListSach()
        {
            //String sql = @"SELECT [MaSach]
            //              ,[TenSach]
            //              ,[NoiDungTT]
            //              ,[SoTrang]
            //              ,[Gia]
            //              ,[SoLuong]
            //              ,[NgayNhap]
            //              ,[NXB].[MaNXB]
            //           ,[TenNXB]
            //              ,[DiaChiNXB]
            //              ,[DienThoaiNXB]
            //              ,[Website]
            //              ,[TacGia].[MaTG]
            //           ,[HoTenTG]
            //              ,[DiaChiTG]
            //              ,[DienThoaiTG]
            //              ,[TheLoai].[MaTL]
            //           ,[TenTL]
            //              ,[GhiChu]
            //              ,[TinhTrang]
            //          FROM [dbo].[Sach] JOIN [NXB] on [Sach].MaNXB = NXB.MaNXB
            //           JOIN TacGia ON [TacGia].MaTG = Sach.MaTG 
            //           JOIN [TheLoai] ON [TheLoai].MaTL = Sach.MaTL";
            string sql = "select * from viewSach";
            DataTable table = dbcnn.getdata(sql);
            List<Sach> listSach = new List<Sach>();
            foreach (DataRow row in table.Rows)
            {
                Sach newSach = new Sach();
                newSach.MaSach = (int)row["MaSach"];
                newSach.TenSach = (string)row["TenSach"];
                newSach.NoiDungTT = (string)row["NoiDungTT"];
                newSach.SoTrang = (int)row["SoTrang"];
                newSach.Gia = (int)row["Gia"];
                newSach.SoLuong = (int)row["SoLuong"];
                newSach.NgayNhap = (DateTime)row["NgayNhap"];
                newSach.nxb.MaNXB = (int)row["MaNXB"];
                newSach.nxb.TenNXB = (string)row["TenNXB"];
                newSach.nxb.DiaChiNXB = (string)row["DiaChiNXB"];
                newSach.nxb.DienThoaiNXB = (string)row["DienThoaiNXB"];
                newSach.nxb.Website = (string)row["Website"];
                newSach.tacGia.MaTG = (int)row["MaTG"];
                newSach.tacGia.HoTenTG = (string)row["HoTenTG"];
                newSach.tacGia.DiaChiTG = (string)row["DiaChiTG"];
                newSach.tacGia.DienThoaiTG = (string)row["DienThoaiTG"];
                newSach.theLoai.MaTL = (int)row["MaTL"];
                newSach.theLoai.TenTL = (string)row["TenTL"];
                newSach.theLoai.GhiChu = row["GhiChu"].ToString();
                newSach.TinhTrang = (bool)row["TinhTrang"];
                listSach.Add(newSach);
            }
            return listSach;
        }

        public bool insertSach(Sach sach)
        {
            String sql = @"INSERT INTO [dbo].[Sach]
                               ([TenSach]
                               ,[NoiDungTT]
                               ,[SoTrang]
                               ,[Gia]
                               ,[SoLuong]
                               ,[NgayNhap]
                               ,[MaNXB]
                               ,[MaTG]
                               ,[MaTL]
                               ,[TinhTrang])
                         VALUES
                               (N'" + sach.TenSach + @"'
                               ,N'" + sach.NoiDungTT + @"'
                               ," + sach.SoLuong + @"
                               ," + sach.Gia + @"
                               ," + sach.SoTrang + @"
                               ,'" + sach.NgayNhap + @"'
                               ," + sach.nxb.MaNXB + @"
                               ," + sach.tacGia.MaTG + @"
                               ," + sach.theLoai.MaTL + @"
                               ," + Convert.ToInt16(sach.TinhTrang) + ")";
            return dbcnn.ThucThiSQL(sql);
        }

        public bool updateSach(Sach sach)
        {
            String sql = @"UPDATE [dbo].[Sach]
                           SET [TenSach] = N'" + sach.TenSach + @"'
                              ,[NoiDungTT] = N'" + sach.NoiDungTT + @"'
                              ,[SoTrang] = " + sach.SoTrang + @"
                              ,[Gia] = " + sach.Gia + @"
                              ,[SoLuong] = " + sach.SoLuong + @"
                              ,[NgayNhap] = '" + sach.NgayNhap + @"'
                              ,[MaNXB] = " + sach.nxb.MaNXB + @"
                              ,[MaTG] = " + sach.tacGia.MaTG + @"
                              ,[MaTL] = " + sach.theLoai.MaTL + @"
                              ,[TinhTrang] = " + Convert.ToInt16(sach.TinhTrang) + @"
                         WHERE [MaSach]=" + sach.MaSach;
            return dbcnn.ThucThiSQL(sql);
        }

        public Sach getSachById(int id)
        {
            //String sql = @"SELECT [MaSach]
            //              ,[TenSach]
            //              ,[NoiDungTT]
            //              ,[SoTrang]
            //              ,[Gia]
            //              ,[SoLuong]
            //              ,[NgayNhap]
            //              ,[NXB].[MaNXB]
            //           ,[TenNXB]
            //              ,[DiaChiNXB]
            //              ,[DienThoaiNXB]
            //              ,[Website]
            //              ,[TacGia].[MaTG]
            //           ,[HoTenTG]
            //              ,[DiaChiTG]
            //              ,[DienThoaiTG]
            //              ,[TheLoai].[MaTL]
            //           ,[TenTL]
            //              ,[GhiChu]
            //              ,[TinhTrang]
            //          FROM [dbo].[Sach] JOIN [NXB] on [Sach].MaNXB = NXB.MaNXB
            //           JOIN TacGia ON [TacGia].MaTG = Sach.MaTG 
            //           JOIN [TheLoai] ON [TheLoai].MaTL = Sach.MaTL
            //              FROM [dbo].[Sach] WHERE [MaSach]=" + id;
            string sql = @"select * from viewSach WHERE MaSach=" + id;
            DataTable table = dbcnn.getdata(sql);
            Sach newSach = new Sach();
            if (table.Rows.Count == 1)
            {
                newSach.MaSach = (int)table.Rows[0]["MaSach"];
                newSach.TenSach = (string)table.Rows[0]["TenSach"];
                newSach.NoiDungTT = (string)table.Rows[0]["NoiDungTT"];
                newSach.SoTrang = (int)table.Rows[0]["SoTrang"];
                newSach.Gia = (int)table.Rows[0]["Gia"];
                newSach.SoLuong = (int)table.Rows[0]["SoLuong"];
                newSach.NgayNhap = (DateTime)table.Rows[0]["NgayNhap"];
                newSach.nxb.MaNXB = (int)table.Rows[0]["MaNXB"];
                newSach.nxb.TenNXB = (string)table.Rows[0]["TenNXB"];
                newSach.nxb.DiaChiNXB = (string)table.Rows[0]["DiaChiNXB"];
                newSach.nxb.DienThoaiNXB = (string)table.Rows[0]["DienThoaiNXB"];
                newSach.nxb.Website = (string)table.Rows[0]["Website"];
                newSach.tacGia.MaTG = (int)table.Rows[0]["MaTG"];
                newSach.tacGia.HoTenTG = (string)table.Rows[0]["HoTenTG"];
                newSach.tacGia.DiaChiTG = (string)table.Rows[0]["DiaChiTG"];
                newSach.tacGia.DienThoaiTG = (string)table.Rows[0]["DienThoaiTG"];
                newSach.theLoai.MaTL = (int)table.Rows[0]["MaTL"];
                newSach.theLoai.TenTL = (string)table.Rows[0]["TenTL"];
                newSach.theLoai.GhiChu = table.Rows[0]["GhiChu"].ToString();
                newSach.TinhTrang = (bool)table.Rows[0]["TinhTrang"];
                return newSach;
            }
            return null;
            
        }

        public bool deleteSach(Sach sach)
        {
            string sql = "DELETE FROM [dbo].[Sach]"
                        + "WHERE MaSach = "+sach.MaSach;
            return dbcnn.ThucThiSQL(sql);
        }
    }
}
