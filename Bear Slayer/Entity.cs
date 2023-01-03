using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Jeu_PVE
{
    public abstract class Entity //  la class mère 
                                 //abstract permet d'empecher notre utilisateur d'instancier une entité vide 
    {
        protected string name; // protected permet l'accès à la variable nom depuis nos classes filles
        protected bool isDead = false;
        protected int healthPoint;
        protected int minDamage;
        protected int maxDamage;
        
        protected Random random = new Random();

        //Constructeur
        public Entity(string name) 
        { 
            this.name = name;
        }
        
        //Méthode pour pouvoir attaqué un monstre.
        //On met en parametre une entité car un monstre est aussi une entité.
        public void Attack(Entity entity)
        {
            int damage = random.Next(minDamage, maxDamage); //Les degats seronts aléatoire entre les degats min et max

            entity.TakeDamage(damage);
            Console.WriteLine(this.name + " HP : (" + this.healthPoint + ")" + " attack  -> " + entity.name);
            Console.WriteLine(entity.name + " lost " + damage + " health point");
            Console.WriteLine(" remain HP (" + entity.healthPoint + ") to "+ entity.name);
            if(entity.isDead)
            {
                Console.WriteLine(entity.name + " is dead");
            }
        }

        //Methode : permetttant la pertes de point de vie .
        //Protected nous permettant d'y accèder depuis nos classe filles
        protected void TakeDamage(int healthPoint) 
        { 
            this.healthPoint -= healthPoint; // on enlevé les points de vie mis en paramètre
            if(this.healthPoint <= 0)
            {
                this.healthPoint = 0; //afin de ne pas afficher un nombre négatif
                isDead= true;
            }
        }

        //Méthode : permetttant de savoir si notre entité est vivante ou non
        public bool IsDead()
        {
            return this.isDead;
        }

       
    }
}
