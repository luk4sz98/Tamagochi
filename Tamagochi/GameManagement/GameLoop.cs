using System;
using Tamagochi.AnimalServices;
using Tamagochi.Interfaces;
using Tamagochi.UserInterfaceServices;
using Tamagochi.UserInterfaceServices.InputEnums;

namespace Tamagochi.GameManagement
{
    class GameLoop : IGameLoop
    {
        public static bool GameState { get; set; }

        private readonly Animal _animal;
        private readonly AnimalStatus _animalStatus;
        private readonly CreateAnimal _createAnimal;

        public GameLoop(AnimalSubmenuUserChoice animal)
        {
            _createAnimal = new CreateAnimal();
            _animal = _createAnimal.Create(animal);
            _animalStatus = new AnimalStatus();
        }

        public void Start()
        { 
            while (GameState)
            {
                PrintService.PrintOutActions();
                UserInput();
                CheckAnimalCondition();
            }
        }
        public void Stop()
        {
            GameState = false;
        }

        private void CheckAnimalCondition()
        {
            if (_animalStatus.CheckHealth(_animal.GetHealth()))
            {
                _animal.PrintDeathMessage();
                Stop();
            }
        }

        private void UserInput()
        {
            switch (UserInputService.GetGameLoopChoice())
            {
                case GameLoopUserChoice.GiveSound:
                    {
                        _animal.GiveSound();
                        _animal.ChangeHealth(-1);
                        Console.WriteLine($"\nTwój zwierzak zgłodniał! Jego poziom życia spadł do {_animal.GetHealth()}\n");
                        Console.ReadKey();
                    }
                    break;
                case GameLoopUserChoice.Feed:
                    {
                        if(_animalStatus.CheckIfEligibleForFeeding(_animal.GetHealth()))
                        {
                            Console.WriteLine("\n\nNakarmiłeś zwierzaka! Jego poziom życia wzrósł o jeden");
                            _animal.ChangeHealth(1);
                        }
                        else
                        {
                            Console.WriteLine($"\n\nTwój zwierzak jest już najedzony!");
                        }
                        
                        Console.ReadKey();
                    }
                    break;
                case GameLoopUserChoice.Stats:
                    {
                        _animal.Stats();
                        Console.ReadKey();
                    }
                    break;
                case GameLoopUserChoice.Exit:
                    {
                        _animal.PrintDeathMessage();
                        Stop();
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
