using System;
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

        public NhanVien chekLogin(String username,String password)
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
                    FROM[ThuVien].[dbo].[NhanVien] 
                    WHERE [EmailNV] = "+username+
                    "AND [MatKhau] = "+password;
            NhanVien nv =(NhanVien) dbcnn.get1Row(sql);
            return nv;
        }

        public bool InsertNhanVien(NhanVien nv)
        {
            //String sql = @"INSERT INTO [dbo].[NhanVien]
            //                   ([HoTenNV],[GioiTinhNV],[NgaySinhNV],[DienThoaiNV],[DiaChiNV],[EmailNV],[NgayVaoLam],[MatKhau],[QuyenHan]) VALUES (@hoten,>,@gioitinh,@ngaysinh,@dienthoai,@diachi,@email,@ngayvaolam,@matkhau,@quyenhan)";
            //SqlCommand cmd = new SqlCommand(sql);
            //cmd.Parameters.Add("@hoten", SqlDbType.Bit);
            //cmd.Parameters.Add("@gioitinh", SqlDbType.Date);
            //cmd.Parameters.Add("@ngaysinh", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@dienthoai", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@diachi", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@email", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@ngayvaolam", SqlDbType.Date);
            //cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@quyenhan", SqlDbType.Bit);

            ////set value for parameter
            //cmd.Parameters["@hoten"].Value = nv.HoTenNV;
            //cmd.Parameters["@gioitinh"].Value = Convert.ToInt16(nv.GioiTinhNV);
            //cmd.Parameters["@ngaysinh"].Value = nv.NgaySinhNV;
            //cmd.Parameters["@dienthoai"].Value = nv.DienThoaiNV;
            //cmd.Parameters["@email"].Value = nv.EmailNV;
            //cmd.Parameters["@ngayvaolam"].Value = nv.NgayVaoLam;
            //cmd.Parameters["@matkhau"].Value = nv.MatKhau;
            //cmd.Parameters["@quyenhan"].Value = Convert.ToInt16(nv.QuyenHan);
            //cmd.Parameters.AddWithValue("@hoten",nv.HoTenNV);
            //dbcnn.Connect();
            //cmd.Connection = dbcnn.conn;
            //int count = cmd.ExecuteNonQuery();
            //dbcnn.Close();
            //if (count==1) return true;
            //return false;
            String sql = @"INSERT INTO [NhanVien] ([HoTenNV],[GioiTinhNV],[NgaySinhNV],[DienThoaiNV],[DiaChiNV],[EmailNV],[NgayVaoLam],[MatKhau],[QuyenHan]) VALUES ('" + nv.HoTenNV + "'," + Convert.ToInt16(nv.GioiTinhNV) + ",'" + nv.NgaySinhNV + "','" + nv.DienThoaiNV + "','" + nv.DiaChiNV + "','" + nv.EmailNV + "','" + nv.NgayVaoLam + "','" + nv.MatKhau + "'," + Convert.ToInt16(nv.GioiTinhNV) + ")";
            return (dbcnn.ThucThiSQL(sql));
        }

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
    }
}
