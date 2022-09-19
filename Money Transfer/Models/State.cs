using System.ComponentModel.DataAnnotations;

namespace Money_Transfer.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
