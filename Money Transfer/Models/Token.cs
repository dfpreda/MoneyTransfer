using System;
using System.ComponentModel.DataAnnotations;

namespace Money_Transfer.Models
{
    public class Token
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TokenValue { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }

    }
}
