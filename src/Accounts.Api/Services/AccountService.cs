using Accounts.Api.DB;
using Accounts.Api.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Accounts.Api.Services
{
    /// <summary>
    /// Предоставляет данные об аккаунтах.
    /// </summary>
    public class AccountService
    {
        /// <summary>
        /// Информация о текущем аккаунте.
        /// </summary>
        public CurrentAccount? GetCurrentAccount(string number)
        {
            using (var db = new InterviewContext())
            {
                var account = db.Accounts
                                .Where(a => String.Compare(a.Number, number, true) == 0)
                                .FirstOrDefault();

                if (account != null)
                {
                    return account;
                }
                return default;
            }
        }
        /// <summary>
        /// Информация обо всех аккаунтах.
        /// </summary>
        public IEnumerable<CurrentAccount> GetAllAccounts()
        {
            using (var db = new InterviewContext())
            {
                return db.Accounts.ToList();
            }
        }

        /// <summary>
        /// Информация обо всех аккаунтах конкретного кастомера.
        /// </summary>
        public IEnumerable<CurrentAccount> GetCurrentAccounts(int customerId)
        {
            using (var db = new InterviewContext())
            {
                var accounts = db.Accounts
                                 .Where(ac => ac.CustomerId == customerId)
                                 .ToList();

                return accounts;
            }
        }
    }
}
