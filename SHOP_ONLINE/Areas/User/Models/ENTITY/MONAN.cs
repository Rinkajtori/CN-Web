namespace SHOP_ONLINE.Areas.User.Models.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONAN")]
    public partial class MONAN
    {
        [Key]
        public int MAMONAN { get; set; }

        [StringLength(50)]
        public string TENMONAN { get; set; }

        public int? MANHOM { get; set; }

        [Column(TypeName = "image")]
        public byte[] HINHANH { get; set; }

        public int? GIA { get; set; }

        public virtual NHOMMONAN NHOMMONAN { get; set; }
    }
}
