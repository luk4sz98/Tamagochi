using Tamagochi.AnimalServices;
using Tamagochi.UserInterfaceServices.InputEnums;

namespace Tamagochi.Interfaces
{
    interface ICreateAnimal
    {
        Animal Create(AnimalSubmenuUserChoice animalToCreate);
    }
}
