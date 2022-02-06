using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentcarProj.Core
//TODO:Выполнить работу над ошибками и осознать выполненную работу.Дописать эту сущность.
{
    /// <summary>
    /// Описание сущности записи автомобиля.
    /// </summary>
     class CarRecording
    {
        /// <summary>
        /// Запись в базе данных.
        /// </summary>
       public Guid Id { get; set; }

        /// <summary>
        /// Запись автомобиля в базе данных.
        /// </summary>
        public Guid CarId { get; set; }
        /// <summary>
        /// Время окончания аренды автомобиля.
        /// </summary>
        
        public DateTime? EndOfRent  { get; set; }
       
        /// <summary>
        /// Стоиомость аренды автомобиля за месяц.
        /// </summary>
        public uint CostPerMonth { get; set; }





    }
}
