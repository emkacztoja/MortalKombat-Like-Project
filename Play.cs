using System;

namespace project
{
    internal class Play
    {
        public static void GamePlay(Character playerCharacter, Dod_Play dodPlay)
        {
            dodPlay.PrintEnemyInfo();

            while (playerCharacter.Health > 0 && dodPlay.Enemy.Health > 0)
            {
                Console.WriteLine("\tFIGHT!");

                Console.WriteLine("Wybierz atak: 1 -Normalny atak, 2 - Ultra atak");
                int attackChoice = GetAttackChoice();

                if (attackChoice == 2 && playerCharacter.Mana < 60)
                {
                    Console.WriteLine("Nie masz wystarczająco Many aby użyć tego ataku. Używasz zwykłego ataku.");
                    attackChoice = 1;
                }

                int playerDamage = CalculatePlayerDamage(attackChoice, playerCharacter);
                int enemyDamage = CalculateEnemyDamage();

                playerCharacter.Health -= enemyDamage;
                dodPlay.Enemy.TakeDamage(playerDamage, attackChoice == 2);

                if (attackChoice == 2)
                {
                    playerCharacter.Mana -= 60;
                }

                Console.WriteLine($"Zdrowie Gracza: {playerCharacter.Health}, Mana: {playerCharacter.Mana}");
                Console.WriteLine($"Zdrowie Przeciwnika: {dodPlay.Enemy.Health}");
            }

            if (playerCharacter.Health <= 0)
            {
                Console.WriteLine("Przegrałeś!");
            }
            else
            {
                Console.WriteLine("Wygrałeś!");
            }
        }

        private static int GetAttackChoice()
        {
            int choice;
            while (true)
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1 || choice == 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawny wybór. Użyj 1 dla normalnego ataku, lub 2 dla ultra ataku.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowy parametr. Należy wpisać cyfrę");
                }
            }
            return choice;
        }

        private static int CalculatePlayerDamage(int attackChoice, Character playerCharacter)
        {
            if (attackChoice == 1)
            {
                return playerCharacter.AttackDamage;
            }
            else
            {
                return 2 * playerCharacter.AttackDamage;
            }
        }

        private static int CalculateEnemyDamage()
        {
            return 20;
        }
    }
}
