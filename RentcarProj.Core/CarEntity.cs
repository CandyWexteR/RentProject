using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentcarProj.Core
{//TODO:Доработать сущность машины
    
    /// <summary>
    /// Описание сущности автомобиля.
    /// </summary>
    public class CarEntity
    {
        /// <summary>
        /// Идентификатор записи.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Марка автомобиля.
        /// </summary>
        public string Mark { get; set; }
        /// <summary>
        /// Цвет автомобиля.
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// Тип коробки передач.
        /// </summary>
        public bool IsMechanic { get; set;}
        /// <summary>
        /// Год выпуска автомобиля.
        /// </summary>
        public DateTime ReleaseYear { get; set; }
        /// <summary>
        /// Номер машины. Должен состоять из 9 символов, первые 6 из которых являются номером автомобиля, а последние 3 - номером региона.
        /// </summary>
        public char[] StateNumber { get; set; }
        



    }
}
