namespace SHOP_ONLINE.Areas.User.Models.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUKIEN")]
    public partial class SUKIEN
    {
        [Key]
        public int MASK { get; set; }

        [StringLength(50)]
        public string TENSK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYBATDAU { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAYKETTHUC { get; set; }

        public int? MANHOM { get; set; }

        [StringLength(200)]
        public string MOTA { get; set; }

        public virtual NHOMMONAN NHOMMONAN { get; set; }
    }
}
