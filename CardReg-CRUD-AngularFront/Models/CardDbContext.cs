using Microsoft.EntityFrameworkCore;

namespace CardReg_CRUD_AngularFront.Models
{
    public class CardDbContext : DbContext
    {
        public CardDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Card> Cards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Card>().HasData(new Card()
            {
                Id = Guid.NewGuid(),
                CardNumber = "12345678910111213",
                CVC = 123,
                ExpireMonth = 1,
                ExpireYear = 2025,
                HolderName = "Card Holder One"
            });
            modelBuilder.Entity<Card>().HasData(new Card()
            {
                Id = Guid.NewGuid(),
                CardNumber = "42345678910111214",
                CVC = 456,
                ExpireMonth = 2,
                ExpireYear = 2022,
                HolderName = "Card Holder Two"
            });
            modelBuilder.Entity<Card>().HasData(new Card()
            {
                Id = Guid.NewGuid(),
                CardNumber = "52345678910111215",
                CVC = 789,
                ExpireMonth = 3,
                ExpireYear = 2027,
                HolderName = "Card Holder Three"
            });
        }
    }
}
