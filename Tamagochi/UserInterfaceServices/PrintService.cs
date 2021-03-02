using System;

namespace Tamagochi.UserInterfaceServices
{
    static class PrintService
    {
        public static void PrintOutMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Witaj w grze Tamagotchi!\n");
            Console.WriteLine("1. Wybierz zwierzaka");
            Console.WriteLine("2. Wyjdź z gry\n");
            Console.Write("Wybierz jedną z dostępnych opcji: ");
        }

        public static void PrintOutAnimalSubmenu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz swojego zwierzaka!\n");
            Console.WriteLine("1. Kot");
            Console.WriteLine("2. Królik");
            Console.WriteLine("3. Pies");
            Console.WriteLine("4. Powrót\n");
            Console.Write("Twój wybór: ");
        }

        public static void PrintOutGameOver()
        {
            Console.WriteLine("\n\t\tGAME OVER\n");
            Console.Write("Wciśnij dowolny przycisk aby kontynuować. . .");
            Console.ReadKey();
        }

        public static void PrintOutActions()
        {
            Console.Clear();
            Console.WriteLine("Akcje, które możesz wykonać:\n");
            Console.WriteLine("1. Daj głos");
            Console.WriteLine("2. Nakarm zwierzaka");
            Console.WriteLine("3. Wyświetl statystyki");
            Console.WriteLine("4. Opuść swojego zwierzaka\n");
            Console.Write("Wybierz jedną z dostępnych opcji: ");
        }

        public static void PrintInvalidInputMessage()
        {
            Console.Write("\nWprowadzono niepoprawne dane! Wciśnij dowolny przycisk aby kontynuować. . .");
            Console.ReadKey();
        }
    }
}
