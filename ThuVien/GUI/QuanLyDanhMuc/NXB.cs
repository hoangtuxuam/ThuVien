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
        /// <summary>
        /// trả về lỗi khi kiểm tra các textbox nhập đúng dữ liệu hay không. trả về chuỗi rỗng nếu không có lỗi
        /// </summary>
        /// <returns>Thông báo lỗi</returns>
        private string checkErr()
        {
            BUS.Validate validate = new BUS.Validate();
            string err = "";
            if (txtTen.Text.Trim().Length == 0) err += "Tên không được trống\n";
            if (txtDienThoai.Text.Trim().Length == 0) err += "Số điện thoại không được trống\n";
            else if (!validate.IsNumber(txtDienThoai.Text.Trim())) err += "Số điện thoại phải là số\n";
            if (txtDiaChi.Text.Trim().Length == 0) err += "Địa chỉ không được trống\n";
            if (txtWebsite.Text.Trim().Length == 0) err += "Website không được trống\n";
            return err;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkErr().Length==0)
            {
                if (choose == 1)
                {

                    #region thêm nxb
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

                    //viết hàm thêm
                    #endregion
                }
                else
                        if (choose == 2)
                {
                    #region sửa nxb
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
                    #endregion
                }
                else if (choose == 3)
                {
                    #region xóa nxb
                    //viết hàm xóa
                    DTO.NXB NXBXoa = new DTO.NXB();
                    NXBXoa.MaNXB = NXBID;
                    if (theLoaiBUS.xoaNXB(NXBXoa))
                    {
                        MessageBox.Show("Xóa Nhà Xuất Bản thành công!");
                        loadGridView();
                    }
                    else
                    {
                        MessageBox.Show("xóa nhà xuất bản không thành công!!");
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
            listNXB = theLoaiBUS.getListNXB();
            DataTable table = new DataTable();
            table.Columns.Add("Mã NXB");
            table.Columns.Add("Tên Nhà Xuất Bản");
            table.Columns.Add("Địa Chỉ");
            table.Columns.Add("Số Điện Thoại");
            table.Columns.Add("Website");
            foreach (DTO.NXB nxb in listNXB)
            {
                table.Rows.Add(nxb.MaNXB, nxb.TenNXB, nxb.DiaChiNXB, nxb.DienThoaiNXB, nxb.Website);
            }
            grvDanhSach.DataSource = table;
            grvDanhSach.Columns[0].Visible = false;
        }
        private void resetAllForm()
        {
            //đưa các textfled về rỗng
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtTen.Text = "";
            txtWebsite.Text = "";
        }

        private void enableAllTextField()
        {
            //cho phép các textfield có thể nhập
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtTen.Enabled = true;
            txtWebsite.Enabled = true;
        }

        private void disableAllTextField()
        {
            //cho phép các textfield không thể nhập
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            txtTen.Enabled = false;
            txtWebsite.Enabled = false;
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

        private void locDuLieu(object sender, EventArgs e)
        {
            listNXB = theLoaiBUS.getListNXB();
            DataTable table = new DataTable();
            table.Columns.Add("Mã NXB");
            table.Columns.Add("Tên Nhà Xuất Bản");
            table.Columns.Add("Địa Chỉ");
            table.Columns.Add("Số Điện Thoại");
            table.Columns.Add("Website");
            IEnumerable<DTO.NXB> lNXB;
            lNXB = from nv in listNXB
                  where nv.TenNXB.ToLower().Contains(txtTim.Text.Trim())
                || nv.DiaChiNXB.ToLower().Contains(txtTim.Text.Trim())
                || nv.DienThoaiNXB.ToLower().Contains(txtTim.Text.Trim())
                || nv.Website.ToLower().Contains(txtTim.Text.Trim())
                                  select nv;
            foreach (DTO.NXB nxb in lNXB)
            {
                table.Rows.Add(nxb.MaNXB, nxb.TenNXB, nxb.DiaChiNXB, nxb.DienThoaiNXB, nxb.Website);
            }
            grvDanhSach.DataSource = table;
            grvDanhSach.Columns[0].Visible = false;
        }
    }
}
