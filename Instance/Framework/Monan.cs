namespace Instance.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Monan")]
    public partial class Monan
    {
        [Key]
        [StringLength(10)]
        public string IDMon { get; set; }

        [Required]
        [StringLength(10)]
        public string TenMon { get; set; }

        public int Nhom { get; set; }
    }
}
