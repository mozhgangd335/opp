using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroGame
{
    internal class Game
    {
       private static List<Gamers> _gamers = new List<Gamers>();
        public static void AddGamers(string name, int speed, int power, int type)
        {
            if (type == 1)
            {
                var hero = new Hero(name);
                hero.Speed = speed;
                hero.Power = power;
                hero.Name = name;
                _gamers.Add(hero);

            }
            if (type == 2)
            {
                var enemy = new Enemy(name);
                enemy.Name = name;
                enemy.Power = power;
                enemy.Speed = speed;
                _gamers.Add(enemy);

            }
            if (type == 3)
            {
                var other = new Other(name);
                other.Name = name;
                other.Power = power;
                other.Speed = speed;
                _gamers.Add(other);


            }


        } public static void Fight(string attacker1name, string attacker2name)
            {

            var attacke1 = _gamers.Find(_ => _.Name == attacker1name);
            var attacker2= _gamers.Find(_ => _.Name == attacker2name);
            attacke1.Attack(attacke1.Speed, attacker2.Power);
            }

    }
}
