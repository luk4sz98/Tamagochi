
namespace Tamagochi.Interfaces
{
    interface IAnimalStatus
    {
        bool CheckHealth(int health);
        bool CheckIfEligibleForFeeding(int health);
    }
}
