using Microsoft.EntityFrameworkCore;
using Money_Transfer.Models;

namespace Money_Transfer.Database
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options):base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Country> CountriesInEU { get; set; }


    }
}
