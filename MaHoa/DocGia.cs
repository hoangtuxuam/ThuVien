namespace MaHoa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocGia")]
    public partial class DocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocGia()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
        }

        [Key]
        public int MaDG { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTenDG { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailDG { get; set; }

        public bool GioiTinhDG { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgaysinhDG { get; set; }

        [Required]
        [StringLength(150)]
        public string DiachiDG { get; set; }

        [Required]
        [StringLength(12)]
        public string DienthoaiDG { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLamThe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayHetHan { get; set; }

        public bool HoatDong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}
