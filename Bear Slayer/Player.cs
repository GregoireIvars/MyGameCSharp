using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_PVE
{
     public abstract class Player : Entity //Player hérite de la class Entity
    {
        private int lvl;
        private int exp;
        private int nbrKill;


        //Constructeur
        public Player(string name) : base(name) //Le constructeur de entity possèdes name en paramètre 
                                                // De ce fait Player doit l'avoir aussi 
        {
            this.name = name;
            this.lvl = 1;
            this.exp = 0;
            this.nbrKill= 0;
        }

        public void numberOfKill(int nbrKill)
        {
            this.nbrKill += nbrKill;

        }
        public void earnExperience(int exp)
        {
            this.exp += exp;// attribution des point experience gagner à exp

            while(this.exp >= expNeedToLvlUp())
            {
                lvl += 1;
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Level Up, You level is now : " + lvl + "!" + " Your Hp was restore ! ");
                healthPoint = 100;
                healthPoint += 10;
                minDamage+= 5;
                maxDamage+= 5;

            }
        }

        public double expNeedToLvlUp()
        {
            return Math.Round(4 * (Math.Pow(lvl, 3)/ 5));
        }



        //Méthode : Affiche les caractéristique de notre personnage
        public string playerStats()
        {
            return this.name + "\n" +
                "Health Point : " + healthPoint + "\n"
                + "Damage : [" + minDamage + ";" + maxDamage + "]"+
                "\n" + "Expérience : (" + exp + "/" + expNeedToLvlUp() + ")\n"+
                "Level : " + lvl + "\n" + "You succesfully kill : " + nbrKill;
        }

    }
}
