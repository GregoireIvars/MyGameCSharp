using System;


namespace Expérience_en_CSharp
{
    public class Presentateur

    {
        private Random random = new Random();
        private int selectBetween1 = 1;
        private int selectBetween2 = 3;
        //construteur 
       
        public Presentateur() {
            Generate();
        }

        //fonction (méthode) 

       public void  Generate()
        {
            //séléction d'un nombre entre 1 et 3
             int select = random.Next(selectBetween1, selectBetween2);
            Console.WriteLine("Selection du présentateur qui vous lira vos question !! ");
            Console.WriteLine();
            Console.WriteLine("1. Julien laperche");
            Console.WriteLine();
            Console.WriteLine("2. Samuel tienne ");
            Console.WriteLine();
            Console.WriteLine("3. Jean-Luc Eichman");

            switch (select)
            {
                case 1:
                    Console.WriteLine("Julien laperche sera votre présentateur pour cette partie");
                    difficulté();

                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine("Samuel tienne sera votre présentateur pour cette partie");
                    difficulté();

                    Console.Clear();
                    break;
                default:
                case 3:
                    Console.WriteLine("Jean-Luc Eichman sera votre présentateur pour cette partie");
                    difficulté();
                    Console.Clear();
                    break;
            }

        }

        public void difficulté() {
            Console.WriteLine("Selectionnr votre niveau de difficulté !  ");
            Console.WriteLine();
            Console.WriteLine("1. Facile ");
            Console.WriteLine();
            Console.WriteLine("2. Moyen ");
            Console.WriteLine();
            Console.WriteLine("3. Difficile ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Mode : Facile ! ");
                    Console.WriteLine("Lets start !!  ");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "2":
                    Console.WriteLine("Mode : Moyen ! ");
                    Console.WriteLine("Lets start !!  ");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                case "3":
                    Console.WriteLine("Mode : Difficile ! ");
                    Console.WriteLine("Lets start !!  ");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
        



        // Chacun possédera trois mode de difficulté 
        // Avec une liste de question différente entre chaque présentateur 
        //Mettre une sélection aléatoire du présentateur a chaque début de partie 

    }
}