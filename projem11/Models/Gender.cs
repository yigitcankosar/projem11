using System.ComponentModel.DataAnnotations;

namespace projem11.Models
{
    public class Gender
    {
        [Key]
        public int GenderID { get; set; }
        [Required(ErrorMessage = "{0} gerekli"), Display(Name = "Cinsiyet"), StringLength(20, MinimumLength = 2, ErrorMessage = "{0} en az {2} en çok {1} olmalıdır. ")]
        public string GenderName{ get; set; }


    }
}