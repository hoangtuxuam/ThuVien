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
    class TheLoaiDAL
    {
        TheLoai theLoai = new TheLoai();
        ConnectDB dbcnn = new ConnectDB();
        public DataTable getTableTheLoai()
        {
            String sql = @"SELECT [MaTL]
                              ,[TenTL]
                              ,[GhiChu]
                          FROM [dbo].[TheLoai]";
            return dbcnn.getdata(sql);
        }
        public List<TheLoai> getListTheLoai()
        {
            String sql = @"SELECT [MaTL]
                              ,[TenTL]
                              ,[GhiChu]
                          FROM [dbo].[TheLoai]";
            DataTable table = dbcnn.getdata(sql);
            List<TheLoai> listTG = new List<TheLoai>();
            foreach (DataRow row in table.Rows)
            {
                TheLoai newTheLoai = new TheLoai();
                newTheLoai.MaTL = (int)row["MaTL"];
                newTheLoai.TenTL = (String)row["TenTL"];
                newTheLoai.GhiChu = (String)row["GhiChu"];
                listTG.Add(newTheLoai);
            }
            return listTG;
        }

        public bool insertTheLoai(TheLoai theLoai)
        {
            String sql = @"INSERT INTO [dbo].[TheLoai]
                               ([TenTL]
                               ,[GhiChu])
                         VALUES
                               (N'"+theLoai.TenTL+ @"'
                               ,N'" + theLoai.GhiChu + @"')";
            return dbcnn.ThucThiSQL(sql);
        }

        public bool updateTheLoai(TheLoai theLoai)
        {
            String sql = @"UPDATE [dbo].[TheLoai]
                           SET [TenTL] = N'" + theLoai.TenTL + @"'
                              ,[GhiChu] = N'" + theLoai.GhiChu + @"'
                         WHERE [MaTL]=" + theLoai.MaTL;
            return dbcnn.ThucThiSQL(sql);
        }

        public TheLoai getTheLoaiById(int id)
        {
            String sql = @"SELECT [MaTL]
                              ,[TenTL]
                              ,[GhiChu]
                          FROM [dbo].[TheLoai]
                          WHERE [MaTL]=" + id;
            DataTable table = dbcnn.getdata(sql);
            TheLoai newTheLoai = new TheLoai();
            if (table.Rows.Count == 1)
            {
                newTheLoai.MaTL = (int)table.Rows[0]["MaTL"];
                newTheLoai.TenTL = (string)table.Rows[0]["TenTL"];
                newTheLoai.GhiChu = (string)table.Rows[0]["GhiChu"];
            }
            return newTheLoai;
        }
    }
}
