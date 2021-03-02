using Tamagochi.MainMenuServices;
using Tamagochi.Interfaces;
using Tamagochi.UserInterfaceServices;

namespace Tamagochi.GameManagement
{
    class Cardinal : ICardinal
    {
        public void StartSupervision()
        {
            var userInterface = new UIElements();

            userInterface.MainMenuLoop();

            if(!GameLoop.GameState)
            {
                PrintService.PrintOutGameOver();
                return;
            }

            var gameLoop = new GameLoop(userInterface.GetAnimal());
            gameLoop.Start();
            PrintService.PrintOutGameOver();
        }
       
    }
}
