using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DTO;

namespace DAL
{
    class ConnectDB
    {
        public SqlConnection conn { get; set; }
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlDataReader reader;

        // Tạo constructor goi kết nối khi new lớp ConnectData
        public ConnectDB()
        {
            //Connect();
        }

        //Khai bao chuoi ket noi CSDL
        private string strConnect = @"Data Source=DESKTOP-D3QKDSP;Initial Catalog=ThuVien;Integrated Security=True";
        //Kết nối
        public void Connect()
        {
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open(); // Mo ket noi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới Cơ Sở Dữ Liệu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Environment.Exit(0);
            }
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }


        //Hàm lấy dữ liệu từ Database theo câu lệnh sql truyền vào
        public DataTable getdata(string sql)
        {
            Connect();
            // Tạo dataApdapter, thực hiện câu lệnh query
            da = new SqlDataAdapter(sql, conn);
            // Đổ dữ liệu vào DataTable
            dt = new DataTable();
            da.Fill(dt);
            Close();
            return dt;
            
        }
        //lấy list Object từ sql
        public List<Object> getList(String sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sql,conn);
            reader = cmd.ExecuteReader();
            List<Object> listObj = new List<Object>();
            try
            {
                while (reader.Read())
                {
                    listObj.Add(reader);
                }
            }
            finally
            {
                reader.Close();
                Close();
            }
            return listObj;
        }

        //Hàm Thêm, Cập nhật, Xóa dữ liệu theo câu lệnh sql đưa vào
        public bool ThucThiSQL(string sql)
        {
            int numRecordsEffect = 0;
            Connect();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                numRecordsEffect = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI ĐÂY NÀY : " + ex.Message, "Thông báo lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Close();
            }
            if (numRecordsEffect > 0)
                return true;
            return false;
        }

        // Lấy 1 dòng
        public Object get1Row(String sql)
        {
            Connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            reader = cmd.ExecuteReader();
            List<Object> listObj = new List<Object>();
            Object obj;
            try
            {
                obj = reader;
            }
            finally
            {
                reader.Close();
                Close();
            }
            return obj;
        }

    }
}
