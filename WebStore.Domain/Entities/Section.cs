using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities.Base;
using WebStore.Domain.Entities.Base.Interfaces;

namespace WebStore.Domain.Entities
{
    /// <summary>
    /// Секция товаров
    /// </summary>
    public class Section: NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Номер заказа
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Индентификатор родителя
        /// </summary>
        public int? ParentId { get; set; }
    }
}
