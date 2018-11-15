namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Samsung")]
    public partial class Samsung
    {
        [Key]
        public int phones { get; set; }

        [Required]
        [StringLength(10)]
        public string Galaxy1 { get; set; }

        [Required]
        [StringLength(10)]
        public string Galaxy2 { get; set; }

        [Required]
        [StringLength(10)]
        public string Galaxy3 { get; set; }
    }
}
