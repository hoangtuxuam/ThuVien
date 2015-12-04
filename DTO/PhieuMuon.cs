namespace DTO
{
    using System;

    public class PhieuMuon
    {
        public int MaPhieu { get; set; }
        public DocGia docGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public NhanVien nhanVien { get; set; }
        public Sach sach { get; set; }
        public DateTime HanTra { get; set; }
        public PhieuMuon()
        {
            docGia = new DocGia();
            nhanVien = new NhanVien();
            sach = new Sach();
        }
    }
}
