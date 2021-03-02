using System;
using Tamagochi.GameManagement;
using Tamagochi.Interfaces;

namespace Tamagochi.AnimalServices
{
    abstract class Animal : IAnimal
    {
        protected string AnimalName;
        protected int Health;
        protected string Sound;
        protected string DeathMessage;

        public Animal() { }

        public Animal(string animalName)
        {
            AnimalName = animalName;
            Health = 3;
        }

        public Animal(string animalName, int health)
        {
            AnimalName = animalName;
            Health = health;
        }
        
        public int GetHealth()
        {
            return Health;
        }

        public string GetName()
        {
            return AnimalName;
        }

        public void ChangeHealth(int amount)
        {
            Health += amount;
        }

        public abstract void GiveSound();

        public virtual void PrintDeathMessage()
        {
            Console.Clear();
            Console.WriteLine("Your Animal is dead! Filthy human bastard!");
        }

        public void Stats()
        {
            Console.WriteLine($"\n\nImie zwierzaka: {AnimalName}");
            Console.WriteLine($"Poziom życia zwierzaka: {Health}");
        }
    }
}
