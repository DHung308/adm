using System.ComponentModel.DataAnnotations;
namespace Adm1.Models
{
    public class Dongvat
    {
        [Key]
        public string  ID { get; set; }
        public string ChungLoai  { get; set; }
        public string  XuatXu { get; set; }
    }
}
