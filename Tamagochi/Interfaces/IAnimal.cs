
namespace Tamagochi.Interfaces
{
    interface IAnimal
    {
        int GetHealth();
        string GetName();
        void ChangeHealth(int amount);
        void GiveSound();
        void PrintDeathMessage();
    }
}
