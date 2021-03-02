using System;

namespace Tamagochi.AnimalServices
{
    sealed class Rabbit : Animal
    {
        public Rabbit(string animalName) : base(animalName)
        {
            SetProperties();
        }

        public Rabbit(string animalName, int health) : base(animalName, health)
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
            Sound = $"\n{AnimalName}: Kwi! Kwi!";
            DeathMessage = $"\n{AnimalName}: Giving me that carrot wouldn't have killed ya, ya know?";
        }
    }
}
