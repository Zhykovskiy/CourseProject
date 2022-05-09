using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPCStore.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
