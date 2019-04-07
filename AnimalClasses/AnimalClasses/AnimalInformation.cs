using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    /// <summary>
    /// Информация
    /// </summary>
    public class AnimalInformation
    {
        /// <summary>
        /// Редкость
        /// </summary>
        public Rarity Rarity { get; set; }
        /// <summary>
        /// Разновидность животных
        /// </summary>
        public KindAnimal KindAnimal { get; set; }
        /// <summary>
        /// Характер животных
        /// </summary>
        public CharacterAnimal CharacterAnimal { get; set; }
        /// <summary>
        /// Тип животных
        /// </summary>
        public AnimalType AnimalType { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBithday { get; set; }
        /// <summary>
        /// Кличка
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Порода
        /// </summary>
        public string Breed { get; set; }
    }
}
