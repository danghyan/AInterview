using Accounts.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounts.Api.BL
{
    public interface IAccountProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<CurrentAccount> GetAllAccounts();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        CurrentAccount GetCurrentAccount(string number);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        CurrentAccount? GetAllAccounts(Customer customer);
     void   AddNewPaymentOrder(PaymentOrder order);
    }
}
