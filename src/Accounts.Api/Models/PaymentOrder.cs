using System;

namespace Accounts.Api.Models
{
    /// <summary>
    /// Представляет платёжное поручение.
    /// </summary>
    public class PaymentOrder
    {
        public PaymentOrder(string debitAccountNumber, string creditAccountNumber, decimal amount)
        {
            Token = Guid.NewGuid();
            DebitAccountNumber = debitAccountNumber;
            CreditAccountNumber = creditAccountNumber;
            Amount = amount;
        }
        /// <summary>
        /// Получает уникальный идентификатор платёжного поручения.
        /// </summary>
        public Guid Token { get; }

        /// <summary>
        /// Получает ссылку на объект <see cref="CurrentAccount"/>,  представляющий счёт списания.
        /// </summary>
        public CurrentAccount DebitAccount { get; }

        /// <summary>
        /// Получает номер счета списания.
        /// </summary>
        public string DebitAccountNumber { get; }

        /// <summary>
        /// Получает ссылку на объект <see cref="CurrentAccount"/> представляюищй счёт зачисления.
        /// </summary>
        public CurrentAccount CreditAccount { get; }

        /// <summary>
        /// Получает номер счета зачисления.
        /// </summary>
        public string CreditAccountNumber { get; }

        /// <summary>
        /// Получает сумму платежа.
        /// </summary>
        public decimal Amount { get; }
    }
}