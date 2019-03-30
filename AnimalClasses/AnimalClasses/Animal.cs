using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    public class Animal
    {
        /// <summary>
        /// Сервис помощи
        /// </summary>
        public List<CareService> CareService { get; set; }
        /// <summary>
        /// Журнал приема
        /// </summary>
        public List<AnimalReseption> Journal { get; set; }
        /// <summary>
        /// Информация
        /// </summary>
        public AnimalInformation Information { get; set; }
        /// <summary>
        /// Фотография
        /// </summary>
        public byte[] Photo { get; set; }
    }
}
