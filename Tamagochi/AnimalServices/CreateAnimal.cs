using System;
using Tamagochi.Interfaces;
using Tamagochi.UserInterfaceServices.InputEnums;

namespace Tamagochi.AnimalServices
{
    class CreateAnimal : ICreateAnimal
    {
         public Animal Create(AnimalSubmenuUserChoice animalToCreate)
        {
            switch (animalToCreate)
            {
                case AnimalSubmenuUserChoice.Cat:
                    {
                        
                        return new Cat(AnimalName());
                    }
                case AnimalSubmenuUserChoice.Rabbit:
                    {
                        return new Rabbit(AnimalName());
                    }
                case AnimalSubmenuUserChoice.Dog:
                    {
                        return new Dog(AnimalName());
                    }
                default:
                    {
                        Console.WriteLine("Nie udało się utworzyć zwierzęcia!");
                        return null;
                    }
            }
        }

        private string AnimalName()
        {
            Console.Clear();
            Console.Write("Podaj imie dla swojego zwierzaka: ");
           
            return Console.ReadLine();
        }

    }
}
