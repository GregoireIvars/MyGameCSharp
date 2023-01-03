using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_PVE
{
    public class Monsters : Entity
    {

        public Monsters(string name) : base(name) 
        {
            this.name= name;
            this.healthPoint = 75;
            this.minDamage = 10;
            this.maxDamage = 15;
        }

        public void upgradeMonster()
        {
            healthPoint += 10;
            minDamage += 3;
            maxDamage += 3;
        }
    }
}
