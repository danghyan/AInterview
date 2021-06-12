using Accounts.Api.Models;
using Microsoft.EntityFrameworkCore;


namespace Accounts.Api.EF
{
    public class CustomerDbContext: DbContext
    {
       

        public DbSet<Customer> Customer { get; set; }
        public DbSet<PaymentOrder> PaymentOrder { get; set; }
        public DbSet<CurrentAccount> Account { get; set; }
    }
}
