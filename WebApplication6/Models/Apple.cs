namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Apple")]
    public partial class Apple
    {
        [Key]
        public int phones { get; set; }

        [Required]
        [StringLength(10)]
        public string Iphone1 { get; set; }

        [Required]
        [StringLength(10)]
        public string Iphone2 { get; set; }

        [Required]
        [StringLength(10)]
        public string Iphone3 { get; set; }
    }
}
