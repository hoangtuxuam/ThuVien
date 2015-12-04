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
    class nxbDAL
    {
        NXB nxb = new NXB();
        ConnectDB dbcnn = new ConnectDB();
        public DataTable getTableNXB()
        {
            String sql = @"SELECT [MaNXB]
                              ,[TenNXB]
                              ,[DiaChiNXB]
                              ,[DienThoaiNXB]
                              ,[Website]
                          FROM [dbo].[NXB]";
            return dbcnn.getdata(sql);
        }
        public List<NXB> getListNXB()
        {
            String sql = @"SELECT [MaNXB]
                              ,[TenNXB]
                              ,[DiaChiNXB]
                              ,[DienThoaiNXB]
                              ,[Website]
                          FROM [dbo].[NXB]";
            DataTable table = dbcnn.getdata(sql);
            List<NXB> listDG = new List<NXB>();
            foreach (DataRow row in table.Rows)
            {
                NXB newNXB = new NXB();
                newNXB.MaNXB = (int)row["MaNXB"];
                newNXB.TenNXB = (String)row["TenNXB"];
                newNXB.DiaChiNXB = (String)row["DiaChiNXB"];
                newNXB.DienThoaiNXB = (string)row["DienThoaiNXB"];
                newNXB.Website = (string)row["Website"];
                listDG.Add(newNXB);
            }
            return listDG;
        }

        public bool insertNXB(NXB nxb)
        {
            String sql = @"INSERT INTO [dbo].[NXB]
                               ([TenNXB]
                               ,[DiaChiNXB]
                               ,[DienThoaiNXB]
                               ,[Website])
                         VALUES
                               (N'"+nxb.TenNXB+ @"'
                               ,N'" + nxb.DiaChiNXB + @"'
                               ,N'" + nxb.DienThoaiNXB + @"'
                               ,N'" + nxb.Website + @"')";
            return dbcnn.ThucThiSQL(sql);
        }

        public bool updateNXB(NXB nxb)
        {
            String sql = @"UPDATE [dbo].[NXB]
                           SET [TenNXB] = N'" + nxb.TenNXB + @"'
                              ,[DiaChiNXB] = N'" + nxb.DiaChiNXB + @"'
                              ,[DienThoaiNXB] = N'" + nxb.DienThoaiNXB + @"'
                              ,[Website] = N'" + nxb.Website + @"'
                         WHERE [MaNXB]="+nxb.MaNXB;
            return dbcnn.ThucThiSQL(sql);
        }

        public NXB getNXBById(int id)
        {
            String sql = @"SELECT [MaNXB]
                              ,[TenNXB]
                              ,[DiaChiNXB]
                              ,[DienThoaiNXB]
                              ,[Website]
                          FROM [dbo].[NXB] WHERE [MaNXB]=" + id;
            DataTable table = dbcnn.getdata(sql);
            NXB newNXB = new NXB();
            if (table.Rows.Count == 1)
            {
                newNXB.MaNXB = (int)table.Rows[0]["MaNXB"];
                newNXB.TenNXB = (string)table.Rows[0]["TenNXB"];
                newNXB.DiaChiNXB = (string)table.Rows[0]["DiaChiNXB"];
                newNXB.DienThoaiNXB = (string)table.Rows[0]["DienThoaiNXB"];
                newNXB.Website = (string)table.Rows[0]["Website"];
            }
            return newNXB;
        }
    }
}
