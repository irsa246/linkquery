using System.ComponentModel.DataAnnotations;

namespace linkquery.Data
{
    public class Class
    {
        [Key]
        public int C_id { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [MaxLength(25, ErrorMessage = "Maximum length should be 25 character")]
        [MinLength(3, ErrorMessage = "Minimum length should be 3 character")]
        public string? C_name { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public int? Romm_num { get; set; }
        public int f_id { get; set; }
        public Faculty? Faculty { get; set; }
    }
}
