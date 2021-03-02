using System;
using Tamagochi.UserInterfaceServices.InputEnums;

namespace Tamagochi.UserInterfaceServices
{
    static class UserInputService
    {
        public static AnimalSubmenuUserChoice GetAnimalSubmenuChoice()
        {
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out var userChoice);

            return (AnimalSubmenuUserChoice)userChoice;
        }

        public static MainMenuUserChoice GetMainMenuChoice()
        {
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out var userChoice);

            return (MainMenuUserChoice)userChoice;
        }

        public static GameLoopUserChoice GetGameLoopChoice()
        {
            int.TryParse(Console.ReadKey().KeyChar.ToString(), out var userChoice);

            return (GameLoopUserChoice)userChoice;
        }

    }
}
