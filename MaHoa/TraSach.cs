namespace MaHoa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraSach")]
    public partial class TraSach
    {
        [Key]
        public int MaPhieu { get; set; }

        public int MaPhieuMuon { get; set; }

        public int MaNV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        public int? PhatHuHong { get; set; }

        public int? PhatQuaHan { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
