using System.ComponentModel.DataAnnotations;

namespace Money_Transfer.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ABB { get; set; }
    }
}
