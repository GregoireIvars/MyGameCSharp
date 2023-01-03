using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_PVE
{
    public  class BearSlayer : Player

    {
            //Constructeur 
            public BearSlayer(string name) : base (name) 
            {
                healthPoint = 100;
                minDamage = 5;
                maxDamage = 15;
            }
    }
}
