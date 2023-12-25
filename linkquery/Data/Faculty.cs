using System.ComponentModel.DataAnnotations;

namespace linkquery.Data
{
    public class Faculty
    {
        [Key]
        public int f_id { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [MaxLength(25, ErrorMessage = "Maximum length should be 25 character")]
        [MinLength(3, ErrorMessage = "Minimum length should be 3 character")]
        public string f_name { get; set; }
        public int dept_id { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [MaxLength(100)]
        public int f_standing { get; set; }
       

    }
}
