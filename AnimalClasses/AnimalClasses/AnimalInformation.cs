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
    /// <summary>
    /// Пол
    /// </summary>
    public enum Gender
    {
        Male,
        Female,
    }
    /// <summary>
    /// Тип животного
    /// </summary>
    public enum AnimalType
    {
        aerial,
        terrestrial,
        underwater,
    }
    /// <summary>
    /// Характер животного
    /// </summary>
    public enum CharacterAnimal
    {
        aggressive,
        calm,
        quiet,
        benevolent,
        mild,
    }
    /// <summary>
    /// Разновидность животного
    /// </summary>
    public enum KindAnimal
    {
        crustacean,
        reptile,
        birdge,
        fish,
        amphibia,
        mammal,
    }
}
