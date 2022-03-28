using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenXuanSon2022537.Models
{
    public class NXS537
    {
        [Key]
        [Required]
        [Display(Name = "Mã id")]
        [StringLength(20)]
        public string NXSID { get; set; }
        [Required]
        [Display(Name = "Họ và Tên")]
        [StringLength(50)]
        public string NXSName { get; set;}
        [Display(Name="Giới tính")]
        [Required]
        [StringLength(30)]
        public string NXSGender {get; set;}
        

    }
}