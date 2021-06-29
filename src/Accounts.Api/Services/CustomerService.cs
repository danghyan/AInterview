using Accounts.Api.DB;
using Accounts.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accounts.Api.Services
{
    /// <summary>
    /// Проводит операции со счетами.
    /// </summary>
    public class CustomerService
    {
        /// <summary>
        /// Операция перевода.
        /// </summary>
        public void PaymentTransfer(PaymentOrder paymentOrder)
        {
            using (var db = new InterviewContext())
            {
                var debitAccount = db.Accounts.Where(ac => String.Compare(ac.Number, paymentOrder.DebitAccountNumber, true) == 0).FirstOrDefault();
                if (debitAccount == null)
                {
                    throw new Exception("Данного счета для списания не существует");
                }
                var creditAccount = db.Accounts.Where(ac => String.Compare(ac.Number, paymentOrder.CreditAccountNumber, true) == 0).FirstOrDefault();
                if (creditAccount == null)
                {
                    throw new Exception("Данного счета для зачисления не существует");
                }

                var newPaymentOrder = new PaymentOrder(paymentOrder.DebitAccountNumber, paymentOrder.CreditAccountNumber, paymentOrder.Amount);

                db.PaymentOrders.Add(newPaymentOrder);
                db.SaveChanges();
            }
        }
    }
}
