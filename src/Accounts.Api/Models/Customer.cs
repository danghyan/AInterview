using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Accounts.Api.Models
{
    /// <summary>
    /// Представляет клиента.
    /// </summary>
    public class Customer
    {
        private List<PaymentOrder> _orders;

        public Customer()
        {
            _orders = new List<PaymentOrder>();

        }

        /// <summary>
        /// Получает уникальный идентификатор клиента.
        /// </summary>
        public int Id { get; set; }

        public IEnumerable <CurrentAccount> Accounts { get; set; }
        /// <summary>
        /// Получает коллекцию всех платёжных поручений.
        /// </summary>
        public ReadOnlyCollection<PaymentOrder> Orders { get; }

        /// <summary>
        /// Создаёт платёжное поручение.
        /// </summary>
        public void CreateOrder()
        {
            // Реализовать алгоритм формирования платёжного поручения.
        }
    }
}