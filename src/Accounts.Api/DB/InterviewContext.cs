using Accounts.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Accounts.Api.DB
{
    public class InterviewContext : DbContext
    {
        public DbSet<CurrentAccount> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PaymentOrder> PaymentOrders { get; set; }
    }
}
