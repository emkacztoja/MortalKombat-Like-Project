using System;
using System.Threading;

namespace project
{
    internal class Game
    {
        private Character playerCharacter;
        private Dod_Play dodPlay;

        public void Start()
        {
            Console.WriteLine("\tWITAJ W");
            Thread.Sleep(1000);

            Class.Mort();
            Thread.Sleep(1000);
            Class.Komb();
            Thread.Sleep(1000);
            Console.WriteLine("Na start masz: 75 golda i 100 many.");
            Thread.Sleep(1000);
            Console.WriteLine("Każdy ultra atak zabiera ci 60 many");
            Thread.Sleep(1000);
            Console.WriteLine("Miłej Gry!");

            int choice;
            while (true)
            {
                Class.Pos();
                choice = GetCharacterChoice();
                if (choice >= 1 && choice <= 10)
                {
                    playerCharacter = Class.SelectCharacter(choice);
                    Console.WriteLine($"Wybrałeś {playerCharacter.Name}!");
                    dodPlay = new Dod_Play();
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór. Proszę wybrać poprawną postać.");
                }
            }

            while (playerCharacter.Health > 0 && dodPlay.Enemy.Health > 0)
            {
                Play.GamePlay(playerCharacter, dodPlay); 
                Console.WriteLine($"Zdrowie Gracza: {playerCharacter.Health}, Mana: {playerCharacter.Mana}");
                Console.WriteLine($"Zdrowie Przeciwnika: {dodPlay.Enemy.Health}");

                Console.WriteLine("Opcje: 1 - Idź do sklepu | 2 - Kontynuuj, 3 - Zakończ grę");
                int option = GetGameOption();
                if (option == 1)
                {
                    Shop shop = new Shop(playerCharacter);
                    shop.ShowShopMenu();
                    int shopChoice = GetShopChoice();
                    shop.BuyItem(shopChoice);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Kontynuujesz walkę!");
                    dodPlay = new Dod_Play();
                }
                else if (option == 3)
                {
                    Console.WriteLine("Dzięki za grę!");
                    break;
                }
            }
        }

        private int GetCharacterChoice()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Wybierz postać (1-10):");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór. Proszę wybrać poprawną postać.");
                }
            }
            return choice;
        }

        private int GetShopChoice()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Wybierz opcję ze sklepu (1-3):");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór. Proszę wybrać opcję ze sklepu.");
                }
            }
            return choice;
        }

        private int GetGameOption()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Wybierz opcję (1-3):");
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy wybór. Proszę podać poprawną opcję.");
                }
            }
            return choice;
        }
    }
}
