using System;

namespace Accounts.Api.Models
{
    /// <summary>
    /// Представляет платёжное поручение.
    /// </summary>
    public class PaymentOrder
    {
        /// <summary>
        /// Получает уникальный идентификатор платёжного поручения.
        /// </summary>
        public Guid Token { get; }

        /// <summary>
        /// Получает ссылку на объект <see cref="CurrentAccount"/>,  представляющий счёт списания.
        /// </summary>
        public CurrentAccount DebitAccount { get; }

        /// <summary>
        /// Получает ссылку на объект <see cref="CurrentAccount"/> представляюищй счёт зачисления.
        /// </summary>
        public CurrentAccount CreditAccount { get; }

        /// <summary>
        /// Получает сумму платежа.
        /// </summary>
        public decimal Amount { get; }
    }
}