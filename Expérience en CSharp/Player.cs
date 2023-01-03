using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expérience_en_CSharp
{
    public class Player 
    {
        public string Name;
        public string lastName;
        public int score;
        public int HP = 3;

        public Player(string Name, string lastName, int score, int HP)
        {
            this.Name = Name;
            this.lastName = lastName;
            this.score = score;
            this.HP = HP;
        }

        public Player()
        { 
            // construteur vide 
        }

        public void pointScore(int score) {
            score += score; // incrémentation du score 
        }

        // créé methode permettant la perte de hp 
        
    }
}
