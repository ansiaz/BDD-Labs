using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    /// <summary>
    /// Сервис помощи
    /// </summary>
    public class CareService
    {
        /// <summary>
        /// Вакцина
        /// </summary>
        public string Vaccination { get; set; }
        /// <summary>
        /// Обследование
        /// </summary>
        public DateTime MaintananceDate { get; set; }
        /// <summary>
        /// Ожидаемая дата следующего обследования
        /// </summary>
        public DateTime? NextPlannedService { get; set; }
        /// <summary>
        /// Описание работ
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Плановое обслуживание
        /// </summary>
        public bool IsPlannedService { get; set; }
    }
}
