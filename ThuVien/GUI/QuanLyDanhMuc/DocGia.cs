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
    public partial class DocGia : UserControl
    {
        /*
        1. thêm
        2. sửa
        3. xóa
            */
        int choose = 0;
        int DocGiaID = 0;
        List<DTO.DocGia> listDocGia;
        BUS.QuanLyDanhMuc.QuanLyDocGiaBUS docGiaBUS = new BUS.QuanLyDanhMuc.QuanLyDocGiaBUS();
        public DocGia()
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
                        DTO.DocGia dgThem = new DTO.DocGia();
                        dgThem.HoTenDG = txtHoTen.Text.Trim();
                        dgThem.EmailDG = txtEmail.Text.Trim();
                        dgThem.DiachiDG = txtDiaChi.Text.Trim();
                        dgThem.DienthoaiDG = txtDienThoai.Text.Trim();
                        if (cbbHoatDong.SelectedIndex == 0)
                        {
                            dgThem.HoatDong = true;
                        }
                        else
                        {
                            dgThem.HoatDong = false;
                        }
                        if (cbbGioiTinh.SelectedIndex == 0)
                        {
                            dgThem.GioiTinhDG = true;
                        }
                        else
                        {
                            dgThem.GioiTinhDG = false;
                        }
                        dgThem.NgaysinhDG = dateNgaySinh.Value;
                        dgThem.NgayLamThe = dateNgayLamThe.Value;
                        dgThem.NgayHetHan = dateNgayHetHan.Value;
                        if (docGiaBUS.ThemDocGia(dgThem))
                        {
                            MessageBox.Show("Thêm độc giả thành công!");
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
                    DTO.DocGia dgSua = new DTO.DocGia();
                    dgSua.HoTenDG = txtHoTen.Text.Trim();
                    dgSua.EmailDG = txtEmail.Text.Trim();
                    dgSua.DiachiDG = txtDiaChi.Text.Trim();
                    dgSua.DienthoaiDG = txtDienThoai.Text.Trim();
                    if (cbbHoatDong.SelectedIndex==0)
                    {
                        dgSua.HoatDong = true;
                    }
                    else
                    {
                        dgSua.HoatDong = false;
                    }
                    if (cbbGioiTinh.SelectedIndex == 0)
                    {
                        dgSua.GioiTinhDG = true;
                    }
                    else
                    {
                        dgSua.GioiTinhDG = false;
                    }
                    dgSua.NgaysinhDG = dateNgaySinh.Value;
                    dgSua.NgayLamThe = dateNgayLamThe.Value;
                    dgSua.NgayHetHan = dateNgayHetHan.Value;
                    dgSua.MaDG = DocGiaID;
                    if (docGiaBUS.suaDocGia(dgSua))
                    {
                        MessageBox.Show("Sửa độc giả thành công!");
                        loadGridView();
                    }
                    #endregion
                }
                else if (choose == 3)
                {
                    #region Xóa  sách
                    //viết hàm xóa
                    DTO.DocGia dgXoa = new DTO.DocGia();
                    dgXoa.MaDG = DocGiaID;
                    if (docGiaBUS.xoaDocGia(dgXoa))
                    {
                        MessageBox.Show("Xóa độc giả thành công!");
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
            dateNgayHetHan.Value = DateTime.Today;
            dateNgayLamThe.Value = DateTime.Today;
            cbbGioiTinh.SelectedIndex = 0;
            cbbHoatDong.SelectedIndex = 0;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            cbbGioiTinh.Items.Add(new { Text = "Nam", Value = true });
            cbbGioiTinh.Items.Add(new { Text = "Nữ", Value = false });
            cbbGioiTinh.DisplayMember = "Text";
            cbbGioiTinh.ValueMember = "Value";
            cbbHoatDong.Items.Add(new { Text = "Có", Value = true });
            cbbHoatDong.Items.Add(new { Text = "Không", Value = false });
            cbbHoatDong.DisplayMember = "Text";
            cbbHoatDong.ValueMember = "Value";
            cbbGioiTinh.SelectedIndex = 0;
            cbbHoatDong.SelectedIndex = 0;
            loadGridView();
        }

        private void loadGridView()
        {
            listDocGia = docGiaBUS.getListDocGia();
            DataTable table = new DataTable();
            table.Columns.Add("Mã Độc Giả");
            table.Columns.Add("Họ Tên");
            table.Columns.Add("Email");
            table.Columns.Add("Giới Tính");
            table.Columns.Add("Địa Chỉ");
            table.Columns.Add("Điện Thoại");
            table.Columns.Add("Hoạt Động");
            foreach (DTO.DocGia dg in listDocGia)
            {
                string gioiTinh = "Nam";
                string hoatDong = "Có";
                if (!dg.GioiTinhDG) gioiTinh = "Nữ";
                if (!dg.HoatDong) hoatDong = "Không";
                table.Rows.Add(dg.MaDG, dg.HoTenDG, dg.EmailDG, gioiTinh, dg.DiachiDG, dg.DienthoaiDG, hoatDong);
            }

            grvDanhSach.DataSource = table;
            //this.grvDanhSach.Columns[0].Visible = false;
        }

        private void ClickCell(object sender, DataGridViewCellEventArgs e)
        {
            if (choose == 2 || choose == 3)
            {
                try
                {
                    int row = e.RowIndex;
                    //DTO.Sach sach = listSach[row];

                    foreach (DTO.DocGia dg in listDocGia)
                    {
                        if (dg.MaDG == Convert.ToInt16(grvDanhSach.Rows[row].Cells[0].Value))
                        {
                            txtHoTen.Text = dg.HoTenDG;
                            txtEmail.Text = dg.EmailDG;
                            txtDienThoai.Text = dg.DienthoaiDG;
                            txtDiaChi.Text = dg.DiachiDG;
                            if (dg.GioiTinhDG) cbbGioiTinh.SelectedIndex = 0;
                            else cbbGioiTinh.SelectedIndex = 1;
                            if (dg.HoatDong) cbbHoatDong.SelectedIndex = 0;
                            else cbbHoatDong.SelectedIndex = 1;
                            dateNgaySinh.Value = dg.NgaysinhDG;
                            dateNgayLamThe.Value = dg.NgayLamThe;
                            dateNgayHetHan.Value = dg.NgayHetHan;

                            DocGiaID = dg.MaDG;
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
            cbbHoatDong.Enabled = true;
            dateNgayHetHan.Enabled = true;
            dateNgayLamThe.Enabled = true;
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
            cbbHoatDong.Enabled = false;
            dateNgayHetHan.Enabled = false;
            dateNgayLamThe.Enabled = false;
            dateNgaySinh.Enabled = false;
        }

        private void locDuLieu(object sender, EventArgs e)
        {
            listDocGia = docGiaBUS.getListDocGia();
            DataTable table = new DataTable();
            table.Columns.Add("Mã Độc Giả");
            table.Columns.Add("Họ Tên");
            table.Columns.Add("Email");
            table.Columns.Add("Giới Tính");
            table.Columns.Add("Địa Chỉ");
            table.Columns.Add("Điện Thoại");
            table.Columns.Add("Hoạt Động");
            IEnumerable<DTO.DocGia> ldg;
            ldg = from dg in listDocGia
                  where dg.HoTenDG.ToLower().Contains(txtTim.Text.Trim())
                || dg.EmailDG.ToLower().Contains(txtTim.Text.Trim())
                || dg.DiachiDG.ToLower().Contains(txtTim.Text.Trim())
                || dg.DienthoaiDG.ToLower().Contains(txtTim.Text.Trim())
                                  select dg;
            foreach (DTO.DocGia dg in ldg)
            {
                string gioiTinh = "Nam";
                string hoatDong = "Có";
                if (!dg.GioiTinhDG) gioiTinh = "Nữ";
                if (!dg.HoatDong) hoatDong = "Không";
                table.Rows.Add(dg.MaDG, dg.HoTenDG, dg.EmailDG, gioiTinh, dg.DiachiDG, dg.DienthoaiDG, hoatDong);
            }

            grvDanhSach.DataSource = table;
        }
    }
}
