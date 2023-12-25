using System.ComponentModel.DataAnnotations;

namespace linkquery.Data
{
    public class Student
    {
        [Key]
        public int S_id { get; set; }
        [Required(ErrorMessage ="Field can't be empty")]
        [MaxLength(25, ErrorMessage = "Maximum length should be 25 character")]
        [MinLength(3,ErrorMessage ="Minimum length should be 3 character")]
        public string S_name { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string Major { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public int Standing { get; set; }
    }
}
