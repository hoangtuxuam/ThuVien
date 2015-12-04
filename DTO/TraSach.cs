namespace DTO
{
    using System;
    public class TraSach
    {
        public int MaPhieu { get; set; }
        public PhieuMuon phieuMuon { get; set; }
        public NhanVien nhanVien { get; set; }
        public DateTime NgayTra { get; set; }
        public int PhatHuHong { get; set; }
        public int PhatQuaHan { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
