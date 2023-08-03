using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adm1.Models
{
    public class Student
    {
        [Key]
        public string  ID { get; set; }
        public string Name  { get; set; }
        public string FaID { get; set; }
        [ForeignKey("FaID")]
        public Faculty? Faculty { get; set; }
    }
}
