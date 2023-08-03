using System.ComponentModel.DataAnnotations;

namespace Adm1.Models
{
    public class Faculty
    {
        [Key]
        public string  FaID { get; set; }
        public string FaName { get; set; }
    }
}
