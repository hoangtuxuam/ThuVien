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
    public class CT_PhieuMuonDAL
    {
        CT_PhieuMuon ctPhieu = new CT_PhieuMuon();
        ConnectDB dbcnn = new ConnectDB();
        /// <summary>
        /// lấy danh sách
        /// </summary>
        /// <returns></returns>
        public DataTable getTableCT_PhieuMuon()
        {
            String sql = @"SELECT [MaPhieu]
                              ,[MaSach]
                              ,[HanTra]
                          FROM [dbo].[CT_PhieuMuon]";
            return dbcnn.getdata(sql);
        }
        /// <summary>
        /// lấy list chi tiết phiếu mượn
        /// </summary>
        /// <returns></returns>
        public List<CT_PhieuMuon> getListCT_PhieuMuon()
        {
            String sql = @"SELECT [MaPhieu]
                              ,[MaSach]
                              ,[HanTra]
                          FROM [dbo].[CT_PhieuMuon]";
            DataTable table = dbcnn.getdata(sql);
            List<CT_PhieuMuon> listTG = new List<CT_PhieuMuon>();
            foreach (DataRow row in table.Rows)
            {
                CT_PhieuMuon newCT_PhieuMuon = new CT_PhieuMuon();
                newCT_PhieuMuon.phieuMuon.MaPhieu = (int)row["MaPhieu"];
                PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();
                newCT_PhieuMuon.phieuMuon = phieuMuonDAL.getPhieuMuonById(newCT_PhieuMuon.phieuMuon.MaPhieu);

                newCT_PhieuMuon.sach.MaSach = (int)row["MaSach"];
                SachDAL sachDAL = new SachDAL();
                newCT_PhieuMuon.sach = sachDAL.getSachById(newCT_PhieuMuon.sach.MaSach);
                newCT_PhieuMuon.HanTra = (DateTime)row["DiaChiTG"];
                listTG.Add(newCT_PhieuMuon);
            }
            return listTG;
        }
        /// <summary>
        /// insert ct_phieumuon vào database
        /// </summary>
        /// <param name="ctPhieu"></param>
        /// <returns></returns>
        public bool insertCT_PhieuMuon(CT_PhieuMuon ctPhieu)
        {
            String sql = @"INSERT INTO [dbo].[CT_PhieuMuon]
                               ([MaPhieu]
                               ,[MaSach]
                               ,[HanTra])
                         VALUES
                               ("+ctPhieu.phieuMuon.MaPhieu+ @"
                               ," + ctPhieu.sach.MaSach + @"
                               ,'"+ctPhieu.HanTra+"')";
            return dbcnn.ThucThiSQL(sql);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ctPhieu"></param>
        /// <returns></returns>
        public bool updateCT_PhieuMuon(CT_PhieuMuon ctPhieu)
        {
            String sql = @"UPDATE [dbo].[CT_PhieuMuon]
                           SET [MaPhieu] = " + ctPhieu.phieuMuon.MaPhieu + @"
                              ,[MaSach] = " + ctPhieu.sach.MaSach + @"
                              ,[HanTra] = '" + ctPhieu.HanTra + @"'
                         WHERE [MaPhieu]=" + ctPhieu.phieuMuon.MaPhieu;
            return dbcnn.ThucThiSQL(sql);
        }
        /// <summary>
        /// lấy chi tiết phiếu mượn bằng ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CT_PhieuMuon getCT_PhieuMuonById(int id)
        {
            String sql = @"SELECT [MaPhieu]
                              ,[MaSach]
                              ,[HanTra]
                          FROM [dbo].[CT_PhieuMuon] WHERE [MaPhieu]=" + id;
            DataTable table = dbcnn.getdata(sql);
            CT_PhieuMuon newCT_PhieuMuon = new CT_PhieuMuon();
            if (table.Rows.Count == 1)
            {
                newCT_PhieuMuon.phieuMuon.MaPhieu = (int)table.Rows[0]["MaPhieu"];
                PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();
                newCT_PhieuMuon.phieuMuon = phieuMuonDAL.getPhieuMuonById(newCT_PhieuMuon.phieuMuon.MaPhieu);

                newCT_PhieuMuon.sach.MaSach = (int)table.Rows[0]["MaSach"];
                SachDAL sachDAL = new SachDAL();
                newCT_PhieuMuon.sach = sachDAL.getSachById(newCT_PhieuMuon.sach.MaSach);
                //newCT_PhieuMuon.HanTra = (DateTime)table.Rows[0]["DiaChiTG"];
            }
            else return null;
            return newCT_PhieuMuon;
        }

        /// <summary>
        /// xóa phiếu mượn trong cơ sở dữ liệu
        /// </summary>
        /// <param name="ctPhieu"></param>
        /// <returns></returns>
        public bool deleteCT_PhieuMuon(CT_PhieuMuon ctPhieu)
        {
            String sql = @"DELETE FROM [dbo].[CT_PhieuMuon]
                         WHERE [MaPhieu]=" + ctPhieu.phieuMuon.MaPhieu;
            return dbcnn.ThucThiSQL(sql);
        }
    }
}
