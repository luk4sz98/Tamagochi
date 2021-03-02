using System;

namespace Tamagochi.AnimalServices
{
    sealed class Dog : Animal
    {
        public Dog(string animalName) : base(animalName)
        {
            SetProperties();
        }
        public Dog(string animalName, int health) : base(animalName, health)
        {
            SetProperties();
        }

        public override void GiveSound()
        {
            Console.WriteLine($"\n{Sound}");
        }

        public override void PrintDeathMessage()
        {
            base.PrintDeathMessage();
            Console.WriteLine(DeathMessage);
        }

        private void SetProperties()
        {
            Sound = $"\n{AnimalName}: Hau Hau!";
            DeathMessage = $"\n{AnimalName}: Wasn't I a good boy???";
        }
    }
}
