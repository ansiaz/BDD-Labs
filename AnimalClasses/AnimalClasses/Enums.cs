using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClasses
{
    /// <summary>
    /// Состояние
    /// </summary>
    public enum Condition
    {
        good,
        normal,
        bad,
        awful,
    }
    /// <summary>
    /// Редкость
    /// </summary>
    public enum Rarity
    {
        probablyDisappeared,
        threatenedWithExtinction,
        dwindlingInNumbers,
        rare,
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
