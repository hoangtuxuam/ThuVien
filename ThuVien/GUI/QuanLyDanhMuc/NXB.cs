using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.GUI.QuanLyDanhMuc
{
    public partial class NXB : UserControl
    {
        /*
        1. thêm
        2. sửa
        3. xóa
            */
        int choose = 0;
        int NXBID = 0;
        List<DTO.NXB> listNXB;
        BUS.QuanLyDanhMuc.QuanLyNXBBUS theLoaiBUS = new BUS.QuanLyDanhMuc.QuanLyNXBBUS();
        public NXB()
        {
            InitializeComponent();
        }

        #region xuly button
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (choose != 1)
            {
                setDefaultBackColor();
                btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
                choose = 1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (choose != 2)
            {
                setDefaultBackColor();
                btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
                choose = 2;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (choose != 3)
            {
                setDefaultBackColor();
                btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
                choose = 3;
            }
        }
        private void setDefaultBackColor()
        {
            // đưa màu các button về mặc định
            btnXoa.BackColor = default(Color);
            btnSua.BackColor = default(Color);
            btnThem.BackColor = default(Color);
        }

        #endregion

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {

                try
                {
                    DTO.NXB NXBThem = new DTO.NXB();
                    NXBThem.TenNXB = txtTen.Text.Trim();
                    NXBThem.DiaChiNXB = txtDiaChi.Text.Trim();
                    NXBThem.DienThoaiNXB = txtDienThoai.Text.Trim();
                    NXBThem.Website = txtWebsite.Text.Trim();
                    if (theLoaiBUS.themNXB(NXBThem))
                    {
                        MessageBox.Show("Thêm Nhà Xuất Bản thành công!");
                        loadGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //viết hàm thêm
            }
            else
                if (choose == 2)
            {
                //viết hàm sửa
                DTO.NXB NXBSua = new DTO.NXB();

                NXBSua.MaNXB = NXBID;
                NXBSua.TenNXB = txtTen.Text.Trim();
                NXBSua.DiaChiNXB = txtDiaChi.Text.Trim();
                NXBSua.DienThoaiNXB = txtDienThoai.Text.Trim();
                NXBSua.Website = txtWebsite.Text.Trim();
                if (theLoaiBUS.suaNXB(NXBSua))
                {
                    MessageBox.Show("Sửa Nhà Xuất Bản thành công!");
                    loadGridView();
                }
            }
            else if (choose == 3)
            {
                //viết hàm xóa
                DTO.NXB NXBXoa = new DTO.NXB();
                NXBXoa.MaNXB = NXBID;
                if (theLoaiBUS.xoaNXB(NXBXoa))
                {
                    MessageBox.Show("Xóa Nhà Xuất Bản thành công!");
                    loadGridView();
                }
            }
        }
        private void loadGridView()
        {
            listNXB = theLoaiBUS.getListNXB();
            DataTable table = new DataTable();
            table.Columns.Add("Mã NXB");
            table.Columns.Add("Tên Nhà Xuất Bản");
            table.Columns.Add("Địa Chỉ");
            table.Columns.Add("Số Điện Thoại");
            table.Columns.Add("Website");
            foreach (DTO.NXB nxb in listNXB)
            {
                table.Rows.Add(nxb.MaNXB,nxb.TenNXB, nxb.DiaChiNXB,nxb.DienThoaiNXB,nxb.Website);
            }
            grvDanhSach.DataSource = table;
            grvDanhSach.Columns[0].Visible = false;
        }
        private void resetAllForm()
        {
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtTen.Text = "";
            txtWebsite.Text = "";
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn đặt lại???", "Đặt lại tất cả!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                resetAllForm();
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (choose == 2 || choose == 3)
            {
                
                try
                {
                    int row = e.RowIndex;
                    foreach (DTO.NXB nxb in listNXB)
                    {
                        //MessageBox.Show(grvDanhSach.Rows[row].Cells[0].Value.ToString());
                        if (Convert.ToInt16(grvDanhSach.Rows[row].Cells[0].Value) == nxb.MaNXB)
                        {
                            txtTen.Text = nxb.TenNXB;
                            txtDiaChi.Text = nxb.DiaChiNXB;
                            txtDienThoai.Text = nxb.DienThoaiNXB;
                            txtWebsite.Text = nxb.Website;
                            NXBID = nxb.MaNXB;
                            
                        }
                    }

                }
                catch (Exception)
                {

                }
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            loadGridView();
        }

    }
}
