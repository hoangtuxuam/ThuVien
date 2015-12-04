namespace DTO
{
    using System;
    public class Sach
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string NoiDungTT { get; set; }
        public int SoTrang { get; set; }
        public int Gia { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayNhap { get; set; }
        public NXB nxb { get; set; }
        public TacGia tacGia { get; set; }
        public TheLoai theLoai { get; set; }
        public bool TinhTrang { get; set; }
        public Sach()
        {
            nxb = new NXB();
            tacGia = new TacGia();
            theLoai = new TheLoai();
        }
    }
}
