using Tamagochi.UserInterfaceServices.InputEnums;

namespace Tamagochi.Interfaces
{
    interface IAnimalSubmenu
    {
        void SubmenuLoop();
        AnimalSubmenuUserChoice GetAnimalToCreate();
    }
}
