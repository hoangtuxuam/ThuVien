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
    public partial class NhanVien : UserControl
    {
        /*
        1. thêm
        2. sửa
        3. xóa
            */
        BindingSource sourceGRV = new BindingSource();
        int choose = 0;
        int NhanVienID = 0;
        List<DTO.NhanVien> listNhanVien;
        BUS.QuanLyDanhMuc.QuanLyNhanVienBUS nhanVienBUS = new BUS.QuanLyDanhMuc.QuanLyNhanVienBUS();
        public NhanVien()
        {
            InitializeComponent();
        }

        #region xuly button
        private bool checkQuyen()
        {
            if (!Session.cNhanVien.QuyenHan)
            {
                MessageBox.Show("bạn không có quyền thực hiện hành động này! liên hệ quản trị viên để biết thêm");
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkQuyen())
            {
                if (choose != 1)
                {
                    setDefaultBackColor();
                    btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    choose = 1;
                    enableAllTextField();
                } 
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkQuyen())
            {
                if (choose != 2)
                {
                    setDefaultBackColor();
                    btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    choose = 2;
                    enableAllTextField();
                } 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkQuyen())
            {
                if (choose != 3)
                {
                    setDefaultBackColor();
                    btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    choose = 3;
                    disableAllTextField();
                } 
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
            if (txtHoTen.Text.Trim().Length == 0) err += "Tên không được trống\n";
            if (txtDienThoai.Text.Trim().Length == 0) err += "Số điện thoại không được trống\n";
            else if (!validate.IsNumber(txtDienThoai.Text.Trim())) err += "Số điện thoại phải là số\n";

            if (txtEmail.Text.Trim().Length == 0) err += "Email không được trống\n";
            else if (!validate.IsEmail(txtEmail.Text.Trim())) err += "Email không đúng định dạng\n";

            if (txtDiaChi.Text.Trim().Length == 0) err += "Địa chỉ không được trống\n";
            return err;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (checkErr().Length == 0)
            {
                if (choose == 1)
                {
                    #region thêm sách
                    try
                    {
                        DTO.NhanVien nvThem = new DTO.NhanVien();
                        nvThem.HoTenNV = txtHoTen.Text.Trim();
                        nvThem.EmailNV = txtEmail.Text.Trim();
                        nvThem.DiaChiNV = txtDiaChi.Text.Trim();
                        nvThem.DienThoaiNV = txtDienThoai.Text.Trim();
                        nvThem.MatKhau = txtPassword.Text.Trim();
                        if (cbbQuyenHan.SelectedIndex == 0)
                        {
                            nvThem.QuyenHan = true;
                        }
                        else
                        {
                            nvThem.QuyenHan = false;
                        }
                        if (cbbGioiTinh.SelectedIndex == 0)
                        {
                            nvThem.GioiTinhNV = true;
                        }
                        else
                        {
                            nvThem.GioiTinhNV = false;
                        }
                        nvThem.NgaySinhNV = dateNgaySinh.Value;
                        nvThem.NgayVaoLam = dateNgayVaoLam.Value;
                        if (nhanVienBUS.ThemNhanVien(nvThem))
                        {
                            MessageBox.Show("Thêm nhân viên thành công!");
                            loadGridView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    #endregion
                    //viết hàm thêm
                }
                else
                        if (choose == 2)
                {
                    #region Sửa sách
                    //viết hàm sửa
                    DTO.NhanVien nvSua = new DTO.NhanVien();
                    nvSua.HoTenNV = txtHoTen.Text.Trim();
                    nvSua.EmailNV = txtEmail.Text.Trim();
                    nvSua.DiaChiNV = txtDiaChi.Text.Trim();
                    nvSua.DienThoaiNV = txtDienThoai.Text.Trim();
                    nvSua.MatKhau = txtPassword.Text.Trim();
                    if (cbbQuyenHan.SelectedIndex == 0)
                    {
                        nvSua.QuyenHan = true;
                    }
                    else
                    {
                        nvSua.QuyenHan = false;
                    }
                    if (cbbGioiTinh.SelectedIndex == 0)
                    {
                        nvSua.GioiTinhNV = true;
                    }
                    else
                    {
                        nvSua.GioiTinhNV = false;
                    }
                    nvSua.NgaySinhNV = dateNgaySinh.Value;
                    nvSua.NgayVaoLam = dateNgayVaoLam.Value;
                    nvSua.MaNV = NhanVienID;
                    if (nhanVienBUS.suaNhanVien(nvSua))
                    {
                        MessageBox.Show("Sửa nhân viên thành công!");
                        loadGridView();
                    }
                    #endregion
                }
                else if (choose == 3)
                {
                    #region Xóa  sách
                    //viết hàm xóa
                    DTO.NhanVien nvXoa = new DTO.NhanVien();
                    nvXoa.MaNV = NhanVienID;
                    if (nhanVienBUS.xoaNhanVien(nvXoa))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn đặt lại???", "Đặt lại tất cả!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                resetAllForm();
            }
        }

        private void resetAllForm()
        {
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            dateNgaySinh.Value = DateTime.Today;
            dateNgayVaoLam.Value = DateTime.Today;
            cbbGioiTinh.SelectedIndex = 0;
            cbbQuyenHan.SelectedIndex = 0;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            cbbGioiTinh.Items.Add(new { Text = "Nam", Value = true });
            cbbGioiTinh.Items.Add(new { Text = "Nữ", Value = false });
            cbbGioiTinh.DisplayMember = "Text";
            cbbGioiTinh.ValueMember = "Value";
            cbbQuyenHan.Items.Add(new { Text = "Quản Trị", Value = true });
            cbbQuyenHan.Items.Add(new { Text = "Nhân Viên", Value = false });
            cbbQuyenHan.DisplayMember = "Text";
            cbbQuyenHan.ValueMember = "Value";
            cbbGioiTinh.SelectedIndex = 0;
            cbbQuyenHan.SelectedIndex = 0;



            cbbLocGioiTinh.Items.Add(new { Text = "Nam", Value = true });
            cbbLocGioiTinh.Items.Add(new { Text = "Nữ", Value = false });
            cbbLocGioiTinh.Items.Insert(0, "--Chọn Giới Tính--");
            cbbLocGioiTinh.DisplayMember = "Text";
            cbbLocGioiTinh.ValueMember = "Value";
            cbbLocGioiTinh.SelectedIndex = 0;

            cbbLocQuyenHan.Items.Add(new { Text = "Quản Trị", Value = true });
            cbbLocQuyenHan.Items.Add(new { Text = "Nhân Viên", Value = false });
            cbbLocQuyenHan.Items.Insert(0, "--Chọn Quyền Hạn--");
            cbbLocQuyenHan.DisplayMember = "Text";
            cbbLocQuyenHan.ValueMember = "Value";
            cbbLocQuyenHan.SelectedIndex = 0;
            loadGridView();
        }

        private void loadGridView()
        {
            listNhanVien = nhanVienBUS.getListNhanVien();
            DataTable table = new DataTable();
            table.Columns.Add("Mã Nhân Viên");
            table.Columns.Add("Họ Tên");
            table.Columns.Add("Email");
            table.Columns.Add("Giới Tính");
            table.Columns.Add("Địa Chỉ");
            table.Columns.Add("Điện Thoại");
            table.Columns.Add("Ngày Vào Làm");
            table.Columns.Add("Hoạt Động");
            foreach (DTO.NhanVien nv in listNhanVien)
            {
                string gioiTinh = "Nam";
                string hoatDong = "Quản Trị";
                if (!nv.GioiTinhNV) gioiTinh = "Nữ";
                if (!nv.QuyenHan) hoatDong = "Nhân Viên";
                table.Rows.Add(nv.MaNV, nv.HoTenNV, nv.EmailNV, gioiTinh, nv.DiaChiNV, nv.DienThoaiNV,nv.NgayVaoLam, hoatDong);
            }
            sourceGRV.DataSource = table;
            //sourceGRV.Filter = string.Format(@"1 like 'Nam'");
            grvDanhSach.DataSource = sourceGRV;
            this.grvDanhSach.Columns[0].Visible = false;
        }

        private void ClickCell(object sender, DataGridViewCellEventArgs e)
        {
            if (choose == 2 || choose == 3)
            {
                try
                {
                    int row = e.RowIndex;
                    //DTO.Sach sach = listSach[row];

                    foreach (DTO.NhanVien nv in listNhanVien)
                    {
                        if (nv.MaNV == Convert.ToInt16(grvDanhSach.Rows[row].Cells[0].Value))
                        {
                            txtHoTen.Text = nv.HoTenNV;
                            txtEmail.Text = nv.EmailNV;
                            txtDienThoai.Text = nv.DienThoaiNV;
                            txtDiaChi.Text = nv.DiaChiNV;
                            if (nv.GioiTinhNV) cbbGioiTinh.SelectedIndex = 0;
                            else cbbGioiTinh.SelectedIndex = 1;
                            if (nv.QuyenHan) cbbQuyenHan.SelectedIndex = 0;
                            else cbbQuyenHan.SelectedIndex = 1;
                            dateNgaySinh.Value = nv.NgaySinhNV;
                            dateNgayVaoLam.Value = nv.NgayVaoLam;

                            NhanVienID = nv.MaNV;
                            break;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void enableAllTextField()
        {
            //cho phép các textfield có thể nhập
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtEmail.Enabled = true;
            txtHoTen.Enabled = true;
            cbbGioiTinh.Enabled = true;
            cbbQuyenHan.Enabled = true;
            dateNgayVaoLam.Enabled = true;
            dateNgaySinh.Enabled = true;
        }
        private void disableAllTextField()
        {
            //cho phép các textfield không thể nhập
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            txtEmail.Enabled = false;
            txtHoTen.Enabled = false;
            cbbGioiTinh.Enabled = false;
            cbbQuyenHan.Enabled = false;
            dateNgayVaoLam.Enabled = false;
            dateNgaySinh.Enabled = false;
        }

        private void LocDuLieu(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã Nhân Viên");
            table.Columns.Add("Họ Tên");
            table.Columns.Add("Email");
            table.Columns.Add("Giới Tính");
            table.Columns.Add("Địa Chỉ");
            table.Columns.Add("Điện Thoại");
            table.Columns.Add("Ngày Vào Làm");
            table.Columns.Add("Hoạt Động");
            IEnumerable<DTO.NhanVien> lnv = nhanVienBUS.getListNhanVien();
            lnv = from nv in lnv
                  where nv.HoTenNV.ToLower().Contains(txtTim.Text.Trim())
                || nv.EmailNV.ToLower().Contains(txtTim.Text.Trim())
                || nv.DiaChiNV.ToLower().Contains(txtTim.Text.Trim())
                || nv.DienThoaiNV.ToLower().Contains(txtTim.Text.Trim())
                  select nv;
            if (cbbLocGioiTinh.SelectedIndex == 1)
            {
                lnv = from nv in lnv
                      where nv.GioiTinhNV == true
                      select nv;
            }
            else if(cbbLocGioiTinh.SelectedIndex==2)
            {
                lnv = from nv in lnv
                      where nv.GioiTinhNV == false
                      select nv;
            }

            if (cbbLocQuyenHan.SelectedIndex == 1)
            {
                lnv = from nv in lnv
                      where nv.QuyenHan == true
                      select nv;
            }
            else if (cbbLocQuyenHan.SelectedIndex == 2)
            {
                lnv = from nv in lnv
                      where nv.QuyenHan == false
                      select nv;
            }
            foreach (DTO.NhanVien nv in lnv)
            {
                string gioiTinh = "Nam";
                string hoatDong = "Quản Trị";
                if (!nv.GioiTinhNV) gioiTinh = "Nữ";
                if (!nv.QuyenHan) hoatDong = "Nhân Viên";
                table.Rows.Add(nv.MaNV, nv.HoTenNV, nv.EmailNV, gioiTinh, nv.DiaChiNV, nv.DienThoaiNV, nv.NgayVaoLam, hoatDong);
            }
            sourceGRV.DataSource = table;
            //sourceGRV.Filter = string.Format(@"1 like 'Nam'");
            grvDanhSach.DataSource = sourceGRV;
            this.grvDanhSach.Columns[0].Visible = false;
        }
    }
}
