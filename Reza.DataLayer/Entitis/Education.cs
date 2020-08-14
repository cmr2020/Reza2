using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Reza.DataLayer.Entitis
{
    public class Education
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="نام رشته")]
        [Required(ErrorMessage ="نام رشته را وارد بکنید")]
        [MaxLength(50)]
        public string Field { get; set; }


        [Display(Name = "نام مدرسه")]
        [Required(ErrorMessage = "نام مدرسه را وارد بکنید")]
        [MaxLength(50)]
        public string SchoolName { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "توضیحات را وارد بکنید")]
        [MaxLength(500)]
        public string Description { get; set; }

        [Display(Name = "تاریخ")]
        public DateTime CreateDate { get; set; }


    }
}
