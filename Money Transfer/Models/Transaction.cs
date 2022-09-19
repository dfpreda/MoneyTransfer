using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Money_Transfer.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Token")]
        public int TokenId { get; set; }
        [Required]
        public int CNP { get; set; }
        [Required]
        public string IBAN { get; set; }
        [Required]
        public double Amount { get; set; }
        [ForeignKey("Currency")]
        public int CurrencyId { get; set; }
        [Required]
        public int AmountReceived { get; set; }
        [ForeignKey("Currency")]
        public int CurrencyReceivedId { get; set; }
        [ForeignKey("State")]
        public int StatusId { get; set; }
    }
}
