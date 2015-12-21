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
    public class DocGiaDAL
    {
        DocGia dg = new DocGia();
        ConnectDB dbcnn = new ConnectDB();
        public DataTable getTableDocGia()
        {
            String sql = @"SELECT TOP 1000 [MaDG]
                          ,[HoTenDG]
                          ,[EmailDG]
                          ,[GioiTinhDG]
                          ,[NgaysinhDG]
                          ,[DiachiDG]
                          ,[DienthoaiDG]
                          ,[NgayLamThe]
                          ,[NgayHetHan]
                          ,[HoatDong]
                      FROM [ThuVien].[dbo].[DocGia]";
            return dbcnn.getdata(sql);
        }
        public List<DocGia> getListDocGia()
        {
            String sql = @"SELECT [MaDG]
                          ,[HoTenDG]
                          ,[EmailDG]
                          ,[GioiTinhDG]
                          ,[NgaysinhDG]
                          ,[DiachiDG]
                          ,[DienthoaiDG]
                          ,[NgayLamThe]
                          ,[NgayHetHan]
                          ,[HoatDong]
                      FROM [ThuVien].[dbo].[DocGia]";
            DataTable table = dbcnn.getdata(sql);
            List<DocGia> listDG = new List<DocGia>();
            foreach (DataRow row in table.Rows)
            {
                DocGia newdg = new DocGia();
                newdg.MaDG = (int) row["MaDG"];
                newdg.HoTenDG = (String)row["HoTenDG"];
                newdg.EmailDG = (String)row["EmailDG"];
                newdg.GioiTinhDG = (bool)row["GioiTinhDG"];
                newdg.NgaysinhDG = (DateTime)row["NgaysinhDG"];
                newdg.DiachiDG = (String)row["DiachiDG"];
                newdg.DienthoaiDG = (String)row["DienthoaiDG"];
                newdg.NgayLamThe = (DateTime)row["NgayLamThe"];
                newdg.NgayHetHan = (DateTime)row["NgayHetHan"];
                newdg.HoatDong = (bool)row["HoatDong"];
                listDG.Add(newdg);
            }
            return listDG;
        }

        public bool insertDocGia(DocGia dg)
        {
            String sql = @"INSERT INTO [dbo].[DocGia]
                               ([HoTenDG]
                               ,[EmailDG]
                               ,[GioiTinhDG]
                               ,[NgaysinhDG]
                               ,[DiachiDG]
                               ,[DienthoaiDG]
                               ,[NgayLamThe]
                               ,[NgayHetHan]
                               ,[HoatDong])
                         VALUES
                               (N'" + dg.HoTenDG + @"'
                               ,N'" + dg.EmailDG + @"'
                               ," + Convert.ToInt16(dg.GioiTinhDG) + @"
                               ,'" + dg.NgaysinhDG + @"'
                               ,N'" + dg.DiachiDG + @"'
                               ,N'" + dg.DienthoaiDG + @"'
                               ,'" + dg.NgayHetHan + @"'
                               ,'"+dg.NgayHetHan+@"'
                               ,"+Convert.ToInt16(dg.HoatDong) +")";
            return dbcnn.ThucThiSQL(sql);
        }

        public bool updateDocGia(DocGia dg)
        {
            String sql = @"UPDATE [dbo].[DocGia]
                           SET [HoTenDG] = N'" + dg.HoTenDG + @"'
                              ,[EmailDG] = N'" + dg.EmailDG + @"'
                              ,[GioiTinhDG] = " + Convert.ToInt16(dg.GioiTinhDG) + @"
                              ,[NgaysinhDG] = N'" + dg.NgaysinhDG + @"'
                              ,[DiachiDG] = N'" + dg.DiachiDG + @"'
                              ,[DienthoaiDG] = N'" + dg.DienthoaiDG + @"'
                              ,[NgayLamThe] = N'" + dg.NgayLamThe + @"'
                              ,[NgayHetHan] = N'" + dg.NgayHetHan + @"'
                              ,[HoatDong] ="+Convert.ToInt16(dg.HoatDong)+@"
                         WHERE [MaDG]=" + dg.MaDG;
            return dbcnn.ThucThiSQL(sql);
        }

        public DocGia getDocGiaById(int id)
        {
            String sql = @"SELECT [MaDG]
                          ,[HoTenDG]
                          ,[EmailDG]
                          ,[GioiTinhDG]
                          ,[NgaysinhDG]
                          ,[DiachiDG]
                          ,[DienthoaiDG]
                          ,[NgayLamThe]
                          ,[NgayHetHan]
                          ,[HoatDong]
                      FROM [ThuVien].[dbo].[DocGia] WHERE [MaDG]=" + id;
            DataTable table = dbcnn.getdata(sql);
            DocGia newdg = new DocGia();
            if (table.Rows.Count == 1)
            {
                newdg.MaDG = (int)table.Rows[0]["MaDG"];
                newdg.HoTenDG = (String)table.Rows[0]["HoTenDG"];
                newdg.EmailDG = (String)table.Rows[0]["EmailDG"];
                newdg.GioiTinhDG = (bool)table.Rows[0]["GioiTinhDG"];
                newdg.NgaysinhDG = (DateTime)table.Rows[0]["NgaysinhDG"];
                newdg.DiachiDG = (String)table.Rows[0]["DiachiDG"];
                newdg.DienthoaiDG = (String)table.Rows[0]["DienthoaiDG"];
                newdg.NgayLamThe = (DateTime)table.Rows[0]["NgayLamThe"];
                newdg.NgayHetHan = (DateTime)table.Rows[0]["NgayHetHan"];
                newdg.HoatDong = (bool)table.Rows[0]["HoatDong"];
            }
            return newdg;
        }

        public bool deleteDocGia(DocGia dg)
        {
            String sql = @"DELETE FROM [dbo].[DocGia]
                         WHERE [MaDG]=" + dg.MaDG;
            return dbcnn.ThucThiSQL(sql);
        }
    }
}
