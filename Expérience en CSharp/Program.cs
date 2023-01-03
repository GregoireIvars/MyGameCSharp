using System;
using System.Runtime.CompilerServices;

namespace Expérience_en_CSharp
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {   Player player = new Player();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bonjour à tous et à toutes ! \n ");
            Console.WriteLine("Bienvenu dans notre Émision : Question \n");
            Console.WriteLine("Question  a pour but de tester vos limite en terme de connaissance \n");
            Console.WriteLine("Que ce soit de la culture Général , ou autre tout type de thême peuvent être aborder");
            Console.WriteLine(" But du jeu : \n " );
            Console.WriteLine("Vous devez répondre correctement au question posez");
            Console.WriteLine("Si vous répondez correctement votre score augmentera ");
            Console.WriteLine("En cas de mauvaise réponse vous risquez de perdre 1 Point de vie ");
            Console.WriteLine("Si vous ne possèdez plus aucun de ces point vie la partie ce termine ");
            Console.WriteLine("Si vous enchainez les bonnes réponses vous pouvez réobtenir un point de vie ");
            Console.WriteLine();
            Console.WriteLine(" Nous vous souhaitons bonne chance ( Ps : Évitez la triche ) ");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Bonjour ! \n");
            Console.WriteLine("quel est votre prénom ?");
            player.Name = Console.ReadLine();
            Console.WriteLine("Quel est votre nom ?");
            player.lastName = Console.ReadLine();
            Console.WriteLine("Bonjour " + player.Name + " " + player.lastName);
            Console.WriteLine("Votre score est actuellement de : " + player.score);
            Console.WriteLine("Il vous reste " + player.HP + " de point de vie");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Menu : \n");
            Console.WriteLine();
            Console.WriteLine(" 1. Play \n");
            Console.WriteLine();
            Console.WriteLine("2. Your Profile \n");
            Console.WriteLine();
            Console.WriteLine("3. Exit \n");

            switch(Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Game();
                    break;
                    case"2":
                    Console.WriteLine("Prénom : " + player.Name + " \n" +
                                       "Nom : " + player.lastName +
                                        "Score :  " + player.score + "\n" + 
                                        "Point de vie : " + player.HP);
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                case "3":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FERMETURE DU JEU");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }

        }

       

        public static void Game ()
        {
            Presentateur presentateur = new Presentateur();
            presentateur.Generate();

          

        }
    }
}