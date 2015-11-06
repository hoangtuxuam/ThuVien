namespace MaHoa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuMuon")]
    public partial class PhieuMuon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuMuon()
        {
            CT_PhieuMuon = new HashSet<CT_PhieuMuon>();
        }

        [Key]
        public int MaPhieu { get; set; }

        public int MaDG { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime NgayMuon { get; set; }

        public int MaNV { get; set; }

        public int MaSach { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HanTra { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PhieuMuon> CT_PhieuMuon { get; set; }

        public virtual DocGia DocGia { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
