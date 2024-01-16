using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    abstract class Gamers
    {


        protected Gamers(string name)
        {
            Name = name;
            Speed = 50;
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public int Power { get; set; }
        public Situation situation { get; set; }
        public virtual void Attack(int speed, int enemyPower)
        {
            if (speed <= 5)
            {

                situation = Situation.Dead;
                throw new Exception("hero can be dead");
            }
            if (situation == Situation.Alive)
            {
                Health = speed - enemyPower;
                if (speed <= 5)
                {

                    situation = Situation.Dead;
                    throw new Exception("hero can be dead");
                }
            }
        }
    }

    enum Situation
    {
        Dead,
        Alive
    }

}





