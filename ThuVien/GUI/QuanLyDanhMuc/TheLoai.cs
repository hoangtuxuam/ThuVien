using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

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
                enableAllTextField();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (choose != 2)
            {
                setDefaultBackColor();
                btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
                choose = 2;
                enableAllTextField();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (choose != 3)
            {
                setDefaultBackColor();
                btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
                choose = 3;
                disableAllTextField();
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
            if (checkErr().Length == 0)
            {
                if (choose == 1)
                {

                    #region Thêm
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
                    #endregion
                }
                else
                        if (choose == 2)
                {
                    #region Sửa
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
                    #endregion
                }
                else if (choose == 3)
                {
                    #region Xóa
                    //viết hàm xóa
                    DTO.TheLoai TheLoaiXoa = new DTO.TheLoai();
                    TheLoaiXoa.MaTL = TheLoaiID;
                    if (theLoaiBUS.xoaTheLoai(TheLoaiXoa))
                    {
                        MessageBox.Show("Xóa Thể Loại thành công!");
                        loadGridView();
                    }
                    #endregion
                } 
            }
            else
            {
                MessageBox.Show(checkErr(), "Lỗi");
            }
        }
        private void loadGridView()
        {
            listTheLoai = theLoaiBUS.getListTheLoai();
            DataTable table = new DataTable();
            table.Columns.Add("Mã Thể Loại");
            table.Columns.Add("Nên Thể Loại");
            table.Columns.Add("Ghi Chú");
            foreach (DTO.TheLoai tl in listTheLoai)
            {
                table.Rows.Add(tl.MaTL,tl.TenTL, tl.GhiChu);
            }
            grvDanhSach.DataSource = table;
            this.grvDanhSach.Columns[0].Visible = false;

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
                try
                {
                    int row = e.RowIndex;
                    foreach (DTO.TheLoai theLoai in listTheLoai)
                    {
                        if (Convert.ToInt16(grvDanhSach.Rows[row].Cells[0].Value) == theLoai.MaTL)
                        {
                            txtTenTL.Text = theLoai.TenTL;
                            txtGhiChu.Text = theLoai.GhiChu;
                            TheLoaiID = theLoai.MaTL;
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

        private void enableAllTextField()
        {
            //cho phép các textfield có thể nhập
            txtTenTL.Enabled = true;
            txtGhiChu.Enabled = true;
        }

        private void disableAllTextField()
        {
            //cho phép các textfield không thể nhập
            txtTenTL.Enabled = false;
            txtGhiChu.Enabled = false;
        }
        private string checkErr()
        {
            BUS.Validate validate = new BUS.Validate();
            string err = "";
            if (txtTenTL.Text.Trim().Length == 0) err += "Tên thể loại không được trống\n";
            return err;
        }

        private void locduLieu(object sender, EventArgs e)
        {
            listTheLoai = theLoaiBUS.getListTheLoai();
            DataTable table = new DataTable();
            table.Columns.Add("Mã Thể Loại");
            table.Columns.Add("Nên Thể Loại");
            table.Columns.Add("Ghi Chú");
            IEnumerable<DTO.TheLoai> lnv;
            lnv = from nv in listTheLoai
                  where nv.TenTL.ToLower().Contains(txtTim.Text.Trim())
                || nv.GhiChu.ToLower().Contains(txtTim.Text.Trim())
                  select nv;
            foreach (DTO.TheLoai tl in lnv)
            {
                table.Rows.Add(tl.MaTL, tl.TenTL, tl.GhiChu);
            }
            grvDanhSach.DataSource = table;
            this.grvDanhSach.Columns[0].Visible = false;
        }
    }
}
