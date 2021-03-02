using Tamagochi.UserInterfaceServices.InputEnums;

namespace Tamagochi.Interfaces
{
    interface IUIElements
    {
        void MainMenuLoop();
        AnimalSubmenuUserChoice GetAnimal();
    }
}
