﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class NhanVienDAL
    {
        public NhanVien nhanVien = new NhanVien();
        ConnectDB dbcnn = new ConnectDB();
        public DataTable getTableNhanVien()
        {
            String sql = @"SELECT [MaNV]
                        ,[HoTenNV]
                        ,[GioiTinhNV]
                        ,[NgaySinhNV]
                        ,[DienThoaiNV]
                        ,[DiaChiNV]
                        ,[EmailNV]
                        ,[NgayVaoLam]
                        ,[MatKhau]
                        ,[QuyenHan]
                    FROM[ThuVien].[dbo].[NhanVien]";
            return dbcnn.getdata(sql);
        }
        public List<NhanVien> getListNhanVien()
        {
            String sql = @"SELECT [MaNV]
                        ,[HoTenNV]
                        ,[GioiTinhNV]
                        ,[NgaySinhNV]
                        ,[DienThoaiNV]
                        ,[DiaChiNV]
                        ,[EmailNV]
                        ,[NgayVaoLam]
                        ,[MatKhau]
                        ,[QuyenHan]
                    FROM[ThuVien].[dbo].[NhanVien]";
            DataTable table = dbcnn.getdata(sql);
            List<NhanVien> listNhanVien = new List<NhanVien>();
            foreach (DataRow row in table.Rows)
            {
                NhanVien nv = new NhanVien();
                nv.MaNV = (int) row["MaNV"];
                nv.HoTenNV = (String)row["HoTenNV"];
                nv.GioiTinhNV = (Boolean)row["GioiTinhNV"];
                nv.NgaySinhNV = (DateTime)row["NgaySinhNV"];
                nv.DienThoaiNV = (String)row["DienThoaiNV"];
                nv.DiaChiNV = (String)row["DiaChiNV"];
                nv.EmailNV = (String)row["EmailNV"];
                nv.NgayVaoLam = (DateTime)row["NgayVaoLam"];
                nv.MatKhau = (String)row["MatKhau"];
                nv.QuyenHan = (Boolean)row["QuyenHan"];
                listNhanVien.Add(nv);
            }
            return listNhanVien;
        }

        public bool chekLogin(String username,String password)
        {
            string sql = @"SELECT [MaNV]
                        ,[HoTenNV]
                        ,[GioiTinhNV]
                        ,[NgaySinhNV]
                        ,[DienThoaiNV]
                        ,[DiaChiNV]
                        ,[EmailNV]
                        ,[NgayVaoLam]
                        ,[MatKhau]
                        ,[QuyenHan]
                    FROM[ThuVien].[dbo].[NhanVien] 
                    WHERE [EmailNV] = '"+username+
                    "' AND [MatKhau] = '" + password+"'";
            //NhanVien nv =(NhanVien) dbcnn.get1Row(sql);
            dbcnn.Connect();
            SqlCommand cmd = new SqlCommand(sql, dbcnn.conn);
            SqlDataReader reader = cmd.ExecuteReader();
            //dbcnn.Close();
            if (reader.HasRows) return true;
            return false;
        }

        public bool InsertNhanVien(NhanVien nv)
        {
            
            String sql = @"INSERT INTO [NhanVien] ([HoTenNV],[GioiTinhNV],[NgaySinhNV],[DienThoaiNV],[DiaChiNV],[EmailNV],[NgayVaoLam],[MatKhau],[QuyenHan]) VALUES ('" + nv.HoTenNV + "'," + Convert.ToInt16(nv.GioiTinhNV) + ",'" + nv.NgaySinhNV + "','" + nv.DienThoaiNV + "','" + nv.DiaChiNV + "','" + nv.EmailNV + "','" + nv.NgayVaoLam + "','" + nv.MatKhau + "'," + Convert.ToInt16(nv.GioiTinhNV) + ")";
            return (dbcnn.ThucThiSQL(sql));
        }
        /// <summary>
        /// sửa nhân viên trong cơ sở dữ liệu
        /// </summary>
        /// <param name="nv">Nhân Viên</param>
        /// <returns></returns>
        public bool updateNhanVien(NhanVien nv)
        {
            string sql;
            if (nv.MatKhau.Length == 0)
            {
                sql = @"UPDATE [dbo].[NhanVien]
                           SET [HoTenNV] = N'" + nv.HoTenNV + @"'
                              ,[GioiTinhNV] = " + Convert.ToInt16(nv.GioiTinhNV) + @"
                              ,[NgaySinhNV] = '" + nv.NgaySinhNV + @"'
                              ,[DienThoaiNV] = N'" + nv.DienThoaiNV + @"'
                              ,[DiaChiNV] = N'" + nv.DiaChiNV + @"'
                              ,[EmailNV] = N'" + nv.EmailNV + @"'
                              ,[NgayVaoLam] = '" + nv.NgayVaoLam + @"'
                              ,[QuyenHan] = " + Convert.ToInt16(nv.QuyenHan) + @"
                         WHERE [MaNV]= " + nv.MaNV;
            }
            else
            {
                sql = @"UPDATE [dbo].[NhanVien]
                           SET [HoTenNV] = N'" + nv.HoTenNV + @"'
                              ,[GioiTinhNV] = " + Convert.ToInt16(nv.GioiTinhNV) + @"
                              ,[NgaySinhNV] = '" + nv.NgaySinhNV + @"'
                              ,[DienThoaiNV] = N'" + nv.DienThoaiNV + @"'
                              ,[DiaChiNV] = N'" + nv.DiaChiNV + @"'
                              ,[EmailNV] = N'" + nv.EmailNV + @"'
                              ,[NgayVaoLam] = '" + nv.NgayVaoLam + @"'
                              ,[MatKhau] = N'" + nv.MatKhau + @"'
                              ,[QuyenHan] = " + Convert.ToInt16(nv.QuyenHan) + @"
                         WHERE [MaNV]= " + nv.MaNV;
            }
            return (dbcnn.ThucThiSQL(sql));
        }
        /// <summary>
        /// xóa nhân viên trong csdl
        /// </summary>
        /// <param name="id">mã nhân viên</param>
        /// <returns></returns>
        public bool DeleteNhanVien(int id)
        {
            dbcnn.Connect();
            String sql = @"DELETE FROM [dbo].[NhanVien] WHERE MaNV=" + id;
            return dbcnn.ThucThiSQL(sql);
        }
        public bool editNhanVien(NhanVien nv)
        {
            String sql = @"UPDATE [dbo].[NhanVien]
                           SET [HoTenNV] = '" + nv.HoTenNV + @"'
                              ,[GioiTinhNV] = " + Convert.ToInt16(nv.GioiTinhNV) +@"
                              ,[NgaySinhNV] = '" + nv.NgaySinhNV + @"'
                              ,[DienThoaiNV] = '" + nv.DienThoaiNV + @"'
                              ,[DiaChiNV] = '" + nv.DiaChiNV + @"'
                              ,[EmailNV] = '" + nv.EmailNV+@"'
                              ,[NgayVaoLam] = '"+nv.NgayVaoLam+@"'
                              ,[MatKhau] = "+nv.MatKhau+@"
                              ,[QuyenHan] = "+Convert.ToInt16(nv.GioiTinhNV)+
                         @"WHERE [MaNV]= "+nv.MaNV;
            return dbcnn.ThucThiSQL(sql);
        }
        public NhanVien getNhanVienById(int id)
        {
            String sql = @"SELECT [MaNV]
                        ,[HoTenNV]
                        ,[GioiTinhNV]
                        ,[NgaySinhNV]
                        ,[DienThoaiNV]
                        ,[DiaChiNV]
                        ,[EmailNV]
                        ,[NgayVaoLam]
                        ,[MatKhau]
                        ,[QuyenHan]
                    FROM[ThuVien].[dbo].[NhanVien] WHERE [MaNV]="+id;
            DataTable table = dbcnn.getdata(sql);
            NhanVien nv = new NhanVien();
            if (table.Rows.Count==1)
            {
                foreach (DataRow row in table.Rows)
                {
                    
                    nv.MaNV = (int)row["MaNV"];
                    nv.HoTenNV = (String)row["HoTenNV"];
                    nv.GioiTinhNV = (Boolean)row["GioiTinhNV"];
                    nv.NgaySinhNV = (DateTime)row["NgaySinhNV"];
                    nv.DienThoaiNV = (String)row["DienThoaiNV"];
                    nv.DiaChiNV = (String)row["DiaChiNV"];
                    nv.EmailNV = (String)row["EmailNV"];
                    nv.NgayVaoLam = (DateTime)row["NgayVaoLam"];
                    nv.MatKhau = (String)row["MatKhau"];
                    nv.QuyenHan = (Boolean)row["QuyenHan"];
                } 
            }
            return nv;
        }
        /// <summary>
        /// lấy ra nhân viên bằng email
        /// </summary>
        /// <param name="email">địa chỉ email</param>
        /// <returns></returns>
        public NhanVien getNhanVienByUsername(string email)
        {
            String sql = @"SELECT [MaNV]
                        ,[HoTenNV]
                        ,[GioiTinhNV]
                        ,[NgaySinhNV]
                        ,[DienThoaiNV]
                        ,[DiaChiNV]
                        ,[EmailNV]
                        ,[NgayVaoLam]
                        ,[MatKhau]
                        ,[QuyenHan]
                    FROM[ThuVien].[dbo].[NhanVien] WHERE [EmailNV]='" + email+"'";
            DataTable table = dbcnn.getdata(sql);
            NhanVien nv = new NhanVien();
            if (table.Rows.Count == 1)
            {
                foreach (DataRow row in table.Rows)
                {

                    nv.MaNV = (int)row["MaNV"];
                    nv.HoTenNV = (String)row["HoTenNV"];
                    nv.GioiTinhNV = (Boolean)row["GioiTinhNV"];
                    nv.NgaySinhNV = (DateTime)row["NgaySinhNV"];
                    nv.DienThoaiNV = (String)row["DienThoaiNV"];
                    nv.DiaChiNV = (String)row["DiaChiNV"];
                    nv.EmailNV = (String)row["EmailNV"];
                    nv.NgayVaoLam = (DateTime)row["NgayVaoLam"];
                    nv.MatKhau = (String)row["MatKhau"];
                    nv.QuyenHan = (Boolean)row["QuyenHan"];
                }
            }
            return nv;
        }
        /// <summary>
        /// lấy ra nhân viên bằng mã nhân viên
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public NhanVien getNhanVienByID(int id)
        {
            String sql = @"SELECT [MaNV]
                        ,[HoTenNV]
                        ,[GioiTinhNV]
                        ,[NgaySinhNV]
                        ,[DienThoaiNV]
                        ,[DiaChiNV]
                        ,[EmailNV]
                        ,[NgayVaoLam]
                        ,[MatKhau]
                        ,[QuyenHan]
                    FROM[ThuVien].[dbo].[NhanVien] WHERE [MaNV]=" + id;
            DataTable table = dbcnn.getdata(sql);
            NhanVien nv = new NhanVien();
            if (table.Rows.Count == 1)
            {
                foreach (DataRow row in table.Rows)
                {

                    nv.MaNV = (int)row["MaNV"];
                    nv.HoTenNV = (String)row["HoTenNV"];
                    nv.GioiTinhNV = (Boolean)row["GioiTinhNV"];
                    nv.NgaySinhNV = (DateTime)row["NgaySinhNV"];
                    nv.DienThoaiNV = (String)row["DienThoaiNV"];
                    nv.DiaChiNV = (String)row["DiaChiNV"];
                    nv.EmailNV = (String)row["EmailNV"];
                    nv.NgayVaoLam = (DateTime)row["NgayVaoLam"];
                    nv.MatKhau = (String)row["MatKhau"];
                    nv.QuyenHan = (Boolean)row["QuyenHan"];
                }
            }
            return nv;
        }

        public bool deleteNhanVien(NhanVien nv)
        {
            String sql = @"DELETE FROM[dbo].[NhanVien]"+
                         @"WHERE [MaNV]= " + nv.MaNV;
            return dbcnn.ThucThiSQL(sql);
        }
    }
}
