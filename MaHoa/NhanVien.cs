namespace MaHoa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        public int MaNV { get; set; }
        public string HoTenNV { get; set; }
        public bool GioiTinhNV { get; set; }
        public DateTime NgaySinhNV { get; set; }
        public string DienThoaiNV { get; set; }
        public string DiaChiNV { get; set; }
        public string EmailNV { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string MatKhau { get; set; }
        public bool QuyenHan { get; set; }
    }
}
