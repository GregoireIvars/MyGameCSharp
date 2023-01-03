using System;
using System.Security.Cryptography.X509Certificates;

namespace Jeu_PVE
{
    internal class Program
    {
       

        static void Main(string[] args) // nous initialise notre code 
        {
           Menu();
        }

        private static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Welcome to : Bear Slayer !");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("###################################");
            Console.WriteLine(" This game is really simple \n");
            Console.WriteLine(" You are a Bear Slayer and you need to kill some mad bear \n");
            Console.WriteLine("If you succesfully kill some bear you earn some Exp and can lvl Up \n");
            Console.WriteLine("But if your player can be upgrade you opponent can be too !");
            Console.WriteLine("###################################");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Are you a Bear Slayer ??");
            Console.WriteLine();
            Console.WriteLine("1. Yes !");
            Console.WriteLine();
            Console.WriteLine("2. Hell yeah !");
            Console.WriteLine();
            Console.WriteLine("3. Of Course i am !");
            Console.WriteLine();
            Console.WriteLine("4. No i'm not a Bear Slayer.");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Yes you are !");
                    Console.WriteLine();
                    Play(new BearSlayer("Player"));
                    Console.WriteLine();
                    Console.Clear();
                    Console.WriteLine("The game started !!!");
                    break;
                case "2":
                    Console.WriteLine("I like your confidence!");
                    Console.WriteLine();
                    Play(new BearSlayer("Player"));
                    Console.Clear();
                    Console.WriteLine("The game started !!!");
                    break;
                case "3":
                    Console.WriteLine("I see that");
                    Console.WriteLine();
                    Play(new BearSlayer("Player"));
                    Console.Clear();
                    Console.WriteLine("The game started !!!");
                    break;
                default:
                case "4":
                    Console.WriteLine("So why are you here ?");
                    Console.WriteLine("The game ended !!!");
                    break;
            }

        static void Play(Player myPlayer)
        {
            Monsters monsters = new Monsters("Bear");// on instancie un monstre
            bool Win = true;
            bool Continu = false;

                while (!monsters.IsDead())
                {
                    //Tour du monstre
                    Console.ForegroundColor = ConsoleColor.Red;
                    monsters.Attack(myPlayer);
                    Console.WriteLine();
                    Console.ReadKey(true);

                    if (myPlayer.IsDead())
                    {
                        Win = false;
                        break;
                    }

                    //Tour du joueur 
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your turn");
                    Console.WriteLine();
                    Console.WriteLine("1 . Attack ");
                    Console.WriteLine();
                    Console.WriteLine("2 . Run Aways");
                    Console.WriteLine();
                    Console.WriteLine("3 . Do nothing");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            myPlayer.Attack(monsters);
                            Console.WriteLine();
                            Console.ReadKey(true);
                            break;
                        case "2":
                            //implémentation d'une méthode de chance de s'échapper
                            int luck = Random.Shared.Next(1, 10);
                            int cpt = 1;
                            Console.ForegroundColor = ConsoleColor.Green;
                            while (cpt > 0)
                            {
                                Console.Write("You want to run away ?");
                                Console.WriteLine();
                                Console.WriteLine("so try to guess a number [1;10]");

                                bool valid = int.TryParse(Console.ReadLine()!.Trim(), out int input);

                                if (!valid)
                                {
                                    Console.WriteLine("You are not a real Bear Slayer");
                                    Console.WriteLine();
                                    while (!Continu)
                                    {
                                        Console.WriteLine("After you run away, do you want to retry ? (Y/N)");
                                        Console.ForegroundColor= ConsoleColor.DarkRed;
                                        string enter = Console.ReadLine().ToUpper();// toUpper pour pas faire de
                                                                                    // différence entre majuscule ou minuscule 
                                        if (enter == "Y")
                                        {
                                            Continu = true;
                                            Console.WriteLine("That's my Bear Slayer !");
                                            Play(myPlayer);
                                            Console.Clear();
                                        }
                                        else if (enter == "N")
                                        {
                                            Console.WriteLine("You are a Weak Bear Slayer");
                                            Console.Clear();
                                            Environment.Exit(0);
                                        }
                                    }
                                }
                                else 
                                {
                                    Console.WriteLine("You fail to escape");
                                    cpt--;
                                    myPlayer.IsDead();
                                    break;
                                }

                            }
                            break;
                        default:
                        case "3":
                            Console.WriteLine("you choose to do nothing ");
                            Console.WriteLine();
                            Console.WriteLine("And nothing happen");
                            break;
                    }
                }

                if (Win)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Congratulation you kill the bear !");
                    Console.WriteLine();
                    myPlayer.numberOfKill(1);
                    Console.WriteLine("You earn some experience ! ");
                    myPlayer.earnExperience(6);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(myPlayer.playerStats());
                    Console.WriteLine("(take care the monster can lvlUp too)");
                    monsters.upgradeMonster();

                    while (!Continu)
                    {
                        Console.WriteLine("Do you want kill a another bear ? (Y/N)");
                        string enter = Console.ReadLine().ToUpper();// toUpper pour pas faire de différence entre majuscule ou minuscule 
                        if (enter == "Y")
                        {
                            Continu = true;
                            Console.WriteLine("That's my Bear Slayer !");
                            Play(myPlayer);
                        }
                        else if (enter == "N")
                        {
                            Console.WriteLine("You are a Weak Bear Slayer");
                            Environment.Exit(0);
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("You died");
                    Console.ReadKey();
                    Console.WriteLine();
                }
            }

            }
        }
    }
