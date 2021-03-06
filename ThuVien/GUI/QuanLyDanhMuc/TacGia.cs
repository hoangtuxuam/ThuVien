﻿using System;
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
    public partial class TacGia : UserControl
    {
        /*
        1. thêm
        2. sửa
        3. xóa
            */
        int choose = 0;
        int TacGiaID = 0;
        List<DTO.TacGia> listTacGia;
        BUS.QuanLyDanhMuc.QuanLyTacGiaBUS tacGiaiBUS = new BUS.QuanLyDanhMuc.QuanLyTacGiaBUS();
        public TacGia()
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
            if (choose == 1)
            {

                if (checkErr().Trim().Length!=0)
                {
                    try
                    {
                        DTO.TacGia TacGiaThem = new DTO.TacGia();
                        TacGiaThem.HoTenTG = txtHoTen.Text.Trim();
                        TacGiaThem.DiaChiTG = txtDiaChi.Text.Trim();
                        TacGiaThem.DienThoaiTG = txtDienThoai.Text.Trim();
                        if (tacGiaiBUS.themtacGia(TacGiaThem))
                        {
                            MessageBox.Show("Thêm Tác Giả thành công!");
                            loadGridView();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    } 
                }
                else
                {
                    MessageBox.Show(checkErr(), "Lỗi");
                }
                //viết hàm thêm
            }
            else
                if (choose == 2)
            {
                //viết hàm sửa
                if (checkErr().Trim().Length!=0)
                {
                    DTO.TacGia TacGiaSua = new DTO.TacGia();

                    TacGiaSua.MaTG = TacGiaID;
                    TacGiaSua.HoTenTG = txtHoTen.Text.Trim();
                    TacGiaSua.DiaChiTG = txtDiaChi.Text.Trim();
                    TacGiaSua.DienThoaiTG = txtDienThoai.Text.Trim();
                    if (tacGiaiBUS.suatacGia(TacGiaSua))
                    {
                        MessageBox.Show("Sửa Tác Giả thành công!");
                        loadGridView();
                    } 
                }
                else
                {
                    MessageBox.Show(checkErr(), "Lỗi");
                }
            }
            else if (choose == 3)
            {
                //viết hàm xóa
                DTO.TacGia TacGiaXoa = new DTO.TacGia();
                TacGiaXoa.MaTG = TacGiaID;
                if (tacGiaiBUS.xoatacGia(TacGiaXoa))
                {
                    MessageBox.Show("Xóa Tác Giả thành công!");
                    loadGridView();
                }
            }
        }

        private void loadGridView()
        {
            listTacGia = tacGiaiBUS.getListtacGia();
            DataTable table = new DataTable();
            table.Columns.Add("Mã Tác Giả");
            table.Columns.Add("Họ Tên Tác Giả");
            table.Columns.Add("Địa Chỉ");
            table.Columns.Add("Số Điện Thoại");
            foreach (DTO.TacGia tg in listTacGia)
            {
                table.Rows.Add(tg.MaTG,tg.HoTenTG, tg.DiaChiTG,tg.DienThoaiTG);
            }
            grvDanhSach.DataSource = table;
            grvDanhSach.Columns[0].Visible = false;

        }
        private void resetAllForm()
        {
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtHoTen.Text = "";
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
                    foreach (DTO.TacGia tacGia in listTacGia)
                    {
                        if (Convert.ToInt16(grvDanhSach.Rows[row].Cells[0].Value) == tacGia.MaTG)
                        {
                            txtHoTen.Text = tacGia.HoTenTG;
                            txtDiaChi.Text = tacGia.DiaChiTG;
                            txtDienThoai.Text = tacGia.DienThoaiTG;
                            TacGiaID = tacGia.MaTG;
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
            txtDiaChi.Enabled = true;
            txtDienThoai.Enabled = true;
            txtHoTen.Enabled = true;
        }

        private void disableAllTextField()
        {
            //cho phép các textfield không thể nhập
            txtDiaChi.Enabled = false;
            txtDienThoai.Enabled = false;
            txtHoTen.Enabled = false;
        }

        private string checkErr()
        {
            BUS.Validate validate = new BUS.Validate();
            string err = "";
            if (txtHoTen.Text.Trim().Length == 0) err += "họ tên không được trống\n";
            if (txtDienThoai.Text.Trim().Length == 0) err += "Số điện thoại không được trống\n";
            else if (!validate.IsNumber(txtDienThoai.Text.Trim())) err += "Số điện thoại phải là số\n";
            if (txtDiaChi.Text.Trim().Length == 0) err += "Địa chỉ không được trống\n";
            return err;
        }

        private void locDuLieu(object sender, EventArgs e)
        {
            listTacGia = tacGiaiBUS.getListtacGia();
            DataTable table = new DataTable();
            table.Columns.Add("Mã Tác Giả");
            table.Columns.Add("Họ Tên Tác Giả");
            table.Columns.Add("Địa Chỉ");
            table.Columns.Add("Số Điện Thoại");
            IEnumerable<DTO.TacGia> ltg;
            ltg = from tg in listTacGia
                  where tg.HoTenTG.ToLower().Contains(txtTim.Text.Trim())
                || tg.DiaChiTG.ToLower().Contains(txtTim.Text.Trim())
                || tg.DienThoaiTG.ToLower().Contains(txtTim.Text.Trim())
                  select tg;
            foreach (DTO.TacGia tg in ltg)
            {
                table.Rows.Add(tg.MaTG, tg.HoTenTG, tg.DiaChiTG, tg.DienThoaiTG);
            }
            grvDanhSach.DataSource = table;
            grvDanhSach.Columns[0].Visible = false;
        }
    }
}
