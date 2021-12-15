using System;

namespace Enemies
{
    ///<summary>Represents Zombie class</summary>
    class Zombie
    {
        public int health;
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            health = value;
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
        public int GetHealth()
        {
            return health;
        }
    }
}
