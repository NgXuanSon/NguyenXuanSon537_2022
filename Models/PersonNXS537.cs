using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenXuanSon2022537.Models
{
    public class PesonNXS537
    {
        [Key]
        [StringLength(20)]
        [Required]
        public string PersonID { get; set; }
        [StringLength(50)]
        [Required]
        public string PersonName { get; set; }
    }
}
