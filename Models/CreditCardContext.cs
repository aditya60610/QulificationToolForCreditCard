using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QulificationToolForCreditCard.Models
{
    public class CreditCardContext:DbContext
    {
        public CreditCardContext()
        {
        }

        public CreditCardContext(DbContextOptions<CreditCardContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CardDetails> CardDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardDetails>().HasData(
                new CardDetails { CreditCardId = 1, CardName = "None",APR = 0M, Message = "No credit cards are available for the customer below 18 Age." , CreatedDateTime = DateTime.Now, ModifiedDateTime= DateTime.Now},
                new CardDetails { CreditCardId = 2, CardName = "Barclay", APR = 24.6M, Message = "Enjoy the Barclay credit card, Barclay credit card now offers an APR of 24.60 %", CreatedDateTime = DateTime.Now, ModifiedDateTime = DateTime.Now },
                new CardDetails { CreditCardId = 3, CardName = "Vanquis", APR=36.8M, Message = "Enjoy the Vanquis credit card, Vanquis credit card now offers an APR of 36.80 %", CreatedDateTime = DateTime.Now, ModifiedDateTime = DateTime.Now });
        }
    }
}
