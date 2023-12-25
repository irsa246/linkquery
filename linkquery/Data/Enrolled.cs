using System.ComponentModel.DataAnnotations;

namespace linkquery.Data
{
    public class Enrolled
    {
        [Key]
       public int id { get; set; }
       public int S_id { get; set; }
       public int C_id { get; set; }
        public Class? Class { get; set; }
        public Student? Student { get; set; }
    }
}
