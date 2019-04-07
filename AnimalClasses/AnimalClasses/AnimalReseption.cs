using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    /// <summary>
    /// Прием животного
    /// </summary>
    public class AnimalReseption
    {
        /// <summary>
        /// Откуда
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Болезнь
        /// </summary>
        public string Ill { get; set; }
        /// <summary>
        /// Редкость
        /// </summary>
        public Rarity Rarity { get; set; }
        /// <summary>
        /// Состояние
        /// </summary>
        public Condition condition { get; set; }
    }
}
