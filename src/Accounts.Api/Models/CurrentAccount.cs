using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Accounts.Api.Models
{
    /// <summary>
    /// Представляет текущий счёт.
    /// </summary>
    public class CurrentAccount
    {
        private List<Movement> _movements;
        
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CurrentAccount"/>.
        /// </summary>
        public CurrentAccount()
        {
            _movements = new List<Movement>();
        }

        /// <summary>
        /// Представляет номер счёта в формате ЦБ РФ.
        /// </summary>
        /// <remarks>
        /// Числовой 20-и значный номер.
        /// </remarks>
        public string Number { get; }

        public int CustomerId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Balance { get;internal set; }

        /// <summary>
        /// Ссылка на объект <see cref="Customer"/>, представляющий владельца счёта.
        /// </summary>
        public Customer Owner { get; }
        
        /// <summary>
        /// Возвращает коллекцию всех движений по счёту.
        /// </summary>
        public ReadOnlyCollection<Movement> Movements => _movements.AsReadOnly();
    }

    /// <summary>
    /// Представляет движение по счёту.
    /// </summary>
    public record Movement(DateTime At, decimal Sum);
}