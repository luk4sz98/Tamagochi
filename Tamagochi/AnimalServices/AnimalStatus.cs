using Tamagochi.Interfaces;

namespace Tamagochi.AnimalServices
{
    class AnimalStatus : IAnimalStatus
    {
        public bool CheckHealth(int health)
        {
            if (health <= 0)
            {
                return true;
            }
            return false;
        }

        public bool CheckIfEligibleForFeeding(int health)
        {
            if (health < 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        
    }
}
