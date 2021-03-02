using System;


namespace Tamagochi.AnimalServices
{
    sealed class Cat : Animal
    { 
        public Cat(string animalName) : base(animalName)
        {
            SetProperties();
        }
        public Cat(string animalName, int health) : base(animalName, health)
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
            Sound = $"\n{AnimalName}: Miaaauu!!!";
            DeathMessage = $"\n{AnimalName}: You disappointed me.";
        }
    }
}
