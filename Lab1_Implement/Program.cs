using Lab1_Implement.Characters;
using Lab1_Implement.CharacterProperties;
using System;

namespace Lab1_Implement
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating Characters(Hero or Villian) using Factory Pattern
            var characterFactory = new CharacterFactory();
            var hero = characterFactory.CreateCharacter(Side.Hero, CharacterType.Warrior);
            var heroPartner = characterFactory.CreateCharacter(Side.Hero, CharacterType.Archer);
            var villian = characterFactory.CreateCharacter(Side.Villian, CharacterType.Mage);

            // Setting Character stats with Stratregy pattern.
            // Archer and Mage attacks are set through adapter pattern from the Warrior's Attacks.
            PropertiesManager.StatSetter(hero);
            PropertiesManager.AttacksSetter(hero);

            PropertiesManager.StatSetter(heroPartner);
            PropertiesManager.AttacksSetter(heroPartner);

            PropertiesManager.StatSetter(villian);
            PropertiesManager.AttacksSetter(villian);

            // Display Charater, type, stats and Attacks

            // Hero
            Console.WriteLine(
                $"Side: {hero.GetType().Name}\n" +
                $"Character Type: {hero.CharacterType}\n" +
                $"HP: {hero.HP}\n" +
                $"AP: {hero.AP}\n" +
                $"Attacks: [{hero.Attacks.Slash()}, {hero.Attacks.Stab()}, {hero.Attacks.ShieldBash()}]\n");

            // Hero's partner
            Console.WriteLine(
                $"Side: {heroPartner.GetType().Name}\n" +
                $"Character Type: {heroPartner.CharacterType}\n" +
                $"HP: {heroPartner.HP}\n" +
                $"AP: {heroPartner.AP}\n" +
                $"Attacks: [{heroPartner.Attacks.Slash()}, {heroPartner.Attacks.Stab()}, {heroPartner.Attacks.ShieldBash()}]\n");

            // Villian
            Console.WriteLine(
                $"Side: {villian.GetType().Name}\n" +
                $"Character Type: {villian.CharacterType}\n" +
                $"HP: {villian.HP}\n" +
                $"AP: {villian.AP}\n" +
                $"Attacks: [{villian.Attacks.Slash()}, {villian.Attacks.Stab()}, {villian.Attacks.ShieldBash()}]");
        }
    }
}
