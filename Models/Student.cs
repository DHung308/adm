using System.ComponentModel.DataAnnotations;

namespace Adm1.Models
{
    public class Student
    {
        [Key]
        public string  ID { get; set; }
        public string Name  { get; set; }
    }
}
