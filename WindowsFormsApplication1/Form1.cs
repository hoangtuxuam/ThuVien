﻿using System;
using System.Data;
using System.Windows.Forms;
using DAL;
using DTO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void load(object sender, EventArgs e)
        {
            PhieuMuonDAL phieu = new PhieuMuonDAL();
            NhanVienDAL nv = new NhanVienDAL();
            DataTable table = new DataTable();
            table = phieu.getTablePhieuMuon();
            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.HoTenNV = "hai";
            nv.GioiTinhNV = false;
            nv.DiaChiNV = "ha tinh";
            nv.DienThoaiNV = "123";
            nv.EmailNV = "abc@abc.com";
            nv.MatKhau = "12345";
            nv.QuyenHan = false;
            nv.NgaySinhNV = DateTime.Now;
            nv.NgayVaoLam = DateTime.Now;
            NhanVienDAL nvdal = new NhanVienDAL();
            if (nvdal.InsertNhanVien(nv))
            {
                MessageBox.Show("chen thanh cong!");
            }
            else
            {
                MessageBox.Show("chen that bai");
            }
        }
    }
}
