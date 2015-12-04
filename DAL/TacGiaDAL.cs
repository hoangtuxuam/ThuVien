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
    class TacGiaDAL
    {
        TacGia tacGia = new TacGia();
        ConnectDB dbcnn = new ConnectDB();
        public DataTable getTableTacGia()
        {
            String sql = @"SELECT [MaTG]
                              ,[HoTenTG]
                              ,[DiaChiTG]
                              ,[DienThoaiTG]
                          FROM [dbo].[TacGia]";
            return dbcnn.getdata(sql);
        }
        public List<TacGia> getListTacGia()
        {
            String sql = @"SELECT [MaTG]
                              ,[HoTenTG]
                              ,[DiaChiTG]
                              ,[DienThoaiTG]
                          FROM [dbo].[TacGia]";
            DataTable table = dbcnn.getdata(sql);
            List<TacGia> listTG = new List<TacGia>();
            foreach (DataRow row in table.Rows)
            {
                TacGia newTacGia = new TacGia();
                newTacGia.MaTG = (int)row["MaTG"];
                newTacGia.HoTenTG = (String)row["HoTenTG"];
                newTacGia.DiaChiTG = (String)row["DiaChiTG"];
                newTacGia.DienThoaiTG = (string)row["DienThoaiTG"];
                listTG.Add(newTacGia);
            }
            return listTG;
        }

        public bool insertTacGia(TacGia tacGia)
        {
            String sql = @"INSERT INTO [dbo].[TacGia]
                               ([HoTenTG]
                               ,[DiaChiTG]
                               ,[DienThoaiTG])
                         VALUES
                               ('"+tacGia.HoTenTG+ @"'
                               ,'" + tacGia.DiaChiTG + @"'
                               ,'" + tacGia.DienThoaiTG + @"')";
            return dbcnn.ThucThiSQL(sql);
        }

        public bool updateTacGia(TacGia tacGia)
        {
            String sql = @"UPDATE [dbo].[TacGia]
                           SET [HoTenTG] = N'" + tacGia.HoTenTG + @"'
                              ,[DiaChiTG] = N'" + tacGia.DiaChiTG + @"'
                              ,[DienThoaiTG] = N'" + tacGia.DienThoaiTG + @"'
                         WHERE [MaTG]=" + tacGia.MaTG;
            return dbcnn.ThucThiSQL(sql);
        }

        public TacGia getTacGiaById(int id)
        {
            String sql = @"SELECT [MaTacGia]
                              ,[TenTacGia]
                              ,[DiaChiTacGia]
                              ,[DienThoaiTacGia]
                              ,[Website]
                          FROM [dbo].[TacGia] WHERE [MaTacGia]=" + id;
            DataTable table = dbcnn.getdata(sql);
            TacGia newTacGia = new TacGia();
            if (table.Rows.Count == 1)
            {
                newTacGia.MaTG = (int)table.Rows[0]["MaTG"];
                newTacGia.HoTenTG = (string)table.Rows[0]["HoTenTG"];
                newTacGia.DiaChiTG = (string)table.Rows[0]["DiaChiTG"];
                newTacGia.DienThoaiTG = (string)table.Rows[0]["DienThoaiTG"];
            }
            return newTacGia;
        }
    }
}
