using Accounts.Api.EF;
using Accounts.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounts.Api.BL
{
    public class AccountProvider: IAccountProvider
    {
       

        public IEnumerable<CurrentAccount> GetAllAccounts()
        {
            using (var db = new CustomerDbContext())
            {
               
             return db.Account.ToList();
             
            }
        }

        public CurrentAccount GetCurrentAccount(string number)
        {
            using (var db = new CustomerDbContext())
            {

              var list = db.Customer.SelectMany(x=>x.Accounts).ToList();

                if (list.Any())
                {
                    return list.FirstOrDefault(name => name.Number.Equals(number, StringComparison.Ordinal));
                }
                else return default;
            }
        }

        public CurrentAccount? GetAllAccounts(Customer customer)
        {
            if (customer is null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            using (var db = new CustomerDbContext())
            {

                var currentCustomer = db.Customer.FirstOrDefault(x => x.Id== customer.Id);
                IEnumerable<CurrentAccount>? list = currentCustomer.Accounts;
                if (list.Any())
                {
                    return list;
                }
                else return default;
            }
        }

        public void AddNewPaymentOrder(PaymentOrder order)
        {
            if (order is null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            using (var db = new CustomerDbContext())
            {
                db.PaymentOrder.Add(order);
                db.SaveChanges();
            }
        }
    }
}
