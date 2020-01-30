using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgProvDel1
{
    class SuperHero
    {
        protected string name;
        protected string superPower;
        protected int powerLevel;
        protected int intelligence;
        protected int strength;
        protected int speed;
        protected int skillBonus;

        public SuperHero()
        {
            strength += skillBonus;
            intelligence += skillBonus;
            speed += skillBonus;
        }
    }
}
