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
    public partial class TheLoai : UserControl
    {
        /*
        1. thêm
        2. sửa
        3. xóa
            */
        int choose = 0;
        int TheLoaiID = 0;
        List<DTO.TheLoai> listTheLoai;
        BUS.QuanLyDanhMuc.QuanLyTheLoaiBUS theLoaiBUS = new BUS.QuanLyDanhMuc.QuanLyTheLoaiBUS();
        public TheLoai()
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
                    DTO.TheLoai TheLoaiThem = new DTO.TheLoai();
                    TheLoaiThem.TenTL = txtTenTL.Text.Trim();
                    TheLoaiThem.GhiChu = txtGhiChu.Text.Trim();
                    if (theLoaiBUS.themTheLoai(TheLoaiThem))
                    {
                        MessageBox.Show("Thêm Thể Loại thành công!");
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
                DTO.TheLoai TheLoaiSua = new DTO.TheLoai();
                
                TheLoaiSua.MaTL = TheLoaiID;
                TheLoaiSua.TenTL = txtTenTL.Text.Trim();
                TheLoaiSua.GhiChu = txtGhiChu.Text.Trim();
                TheLoaiSua.MaTL = TheLoaiID;
                if (theLoaiBUS.suaTheLoai(TheLoaiSua))
                {
                    MessageBox.Show("Sửa Thể Loại thành công!");
                    loadGridView();
                }
            }
            else if (choose == 3)
            {
                //viết hàm xóa
                DTO.TheLoai TheLoaiXoa = new DTO.TheLoai();
                TheLoaiXoa.MaTL = TheLoaiID;
                if (theLoaiBUS.xoaTheLoai(TheLoaiXoa))
                {
                    MessageBox.Show("Xóa Thể Loại thành công!");
                    loadGridView();
                }
            }
        }
        private void loadGridView()
        {
            listTheLoai = theLoaiBUS.getListTheLoai();
            DataTable table = new DataTable();
            table.Columns.Add("Nên Thể Loại");
            table.Columns.Add("Ghi Chú");
            foreach (DTO.TheLoai tl in listTheLoai)
            {
                table.Rows.Add(tl.TenTL, tl.GhiChu);
            }
            grvDanhSach.DataSource = table;

        }
        private void resetAllForm()
        {
            txtGhiChu.Text = "";
            txtTenTL.Text = "";
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
                int row = e.RowIndex;
                DTO.TheLoai theLoai = listTheLoai[row];
                txtTenTL.Text = theLoai.TenTL;
                txtGhiChu.Text = theLoai.GhiChu;
                TheLoaiID = theLoai.MaTL;
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            loadGridView();
        }
    }
}
