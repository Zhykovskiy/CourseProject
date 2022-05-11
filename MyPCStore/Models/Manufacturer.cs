using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPCStore.Models
{
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
