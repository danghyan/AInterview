using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

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
        [StringLength(20, MinimumLength = 20)]
        public string Number { get; }

        /// <summary>
        /// Владелец счета.
        /// </summary>
        public int CustomerId { get; }

        /// <summary>
        /// Баланс счета.
        /// </summary>
        public decimal Balance { get; }        
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