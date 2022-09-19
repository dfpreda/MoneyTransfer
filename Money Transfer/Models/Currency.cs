using System.ComponentModel.DataAnnotations;

namespace Money_Transfer.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
