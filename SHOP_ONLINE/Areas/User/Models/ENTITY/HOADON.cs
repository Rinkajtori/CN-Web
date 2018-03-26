namespace SHOP_ONLINE.Areas.User.Models.ENTITY
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [Key]
        public int MAHD { get; set; }

        public int? MAKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY { get; set; }

        public int? TONGTIEN { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
