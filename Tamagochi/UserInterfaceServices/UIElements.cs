using Tamagochi.Interfaces;
using Tamagochi.UserInterfaceServices;
using Tamagochi.GameManagement;
using Tamagochi.UserInterfaceServices.InputEnums;

namespace Tamagochi.MainMenuServices
{
    class UIElements : IUIElements
    {
        public static bool animalSubmenuLoopState;
        public static bool mainMenuLoopState;

        private AnimalSubmenuUserChoice animalToCreate;

        public void MainMenuLoop()
        {
            mainMenuLoopState = true;

            while (mainMenuLoopState)
            {
                PrintService.PrintOutMainMenu();
                MainMenuUserInput();
            }
        }

        public AnimalSubmenuUserChoice GetAnimal()
        {
            return animalToCreate;
        }

        private AnimalSubmenuUserChoice GetAnimalToCreate()
        {
            return animalToCreate;
        }

        
        private void MainMenuUserInput()
        {
            switch (UserInputService.GetMainMenuChoice())
            {
                case MainMenuUserChoice.ChooseAnimal:
                    {
                        AnimalSubmenuLoop();

                        var choice = GetAnimalToCreate();

                        if (choice != AnimalSubmenuUserChoice.Return)
                        {
                            animalToCreate = choice;
                            mainMenuLoopState = false;
                            GameLoop.GameState = true;
                        }
                    }
                    break;

                case MainMenuUserChoice.Exit:
                    {
                        GameLoop.GameState = false;
                        mainMenuLoopState = false;
                    }
                    break;
                default:
                    {
                        PrintService.PrintInvalidInputMessage();
                    }
                    break;
            }
        }

        private void AnimalSubmenuLoop()
        {
            animalSubmenuLoopState = true;

            while (animalSubmenuLoopState)
            {
                PrintService.PrintOutAnimalSubmenu();
                AnimalSubmenuGetChoice();
            }
        }

        private void AnimalSubmenuGetChoice()
        {
            var choice = UserInputService.GetAnimalSubmenuChoice();
            switch (choice)
            {
                case AnimalSubmenuUserChoice.Cat:
                case AnimalSubmenuUserChoice.Rabbit:
                case AnimalSubmenuUserChoice.Dog:
                case AnimalSubmenuUserChoice.Return:
                    {
                        animalSubmenuLoopState = false;
                        animalToCreate = choice;
                    }
                    break;
                default:
                    {
                        PrintService.PrintInvalidInputMessage();
                    }
                    break;
            }
        }
    }
}
