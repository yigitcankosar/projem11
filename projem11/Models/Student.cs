using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projem11.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required(ErrorMessage ="{0} gerekli"),Display(Name ="İlk ve Varsa İkinci Adı"),StringLength(40,MinimumLength =2,ErrorMessage ="{0} en az {2} en çok {1} olmalıdır. ")]
        public string  NameAndSecondName{ get; set; }
        [Required(ErrorMessage = "{0} gerekli"), Display(Name = "Soyisim"), StringLength(20, MinimumLength = 2, ErrorMessage = "{0} en az {2} en çok {1} olmalıdır. ")]
        public string  SurName{ get; set; }

        [Required(ErrorMessage = "{0} gerekli"), Display(Name = "Telefon"), StringLength(14, MinimumLength = 10, ErrorMessage = "{0} en az {2} en çok {1} olmalıdır. ")]
        public string Mobile{ get; set; }

        [Required(ErrorMessage = "{0} gerekli"), Display(Name = "Doğum Yeri")]
        public int GenderID { get; set; }

        public Gender Gender{ get; set; }

    }
}
