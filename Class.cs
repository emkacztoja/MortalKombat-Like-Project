using System;

namespace project
{
    internal class Class
    {
        //Logo Mortal Kombat

        public static void Mort()
        {
            Console.WriteLine(" _    _   ____   ____  _____   __     _");
            Console.WriteLine("|  \\/  | /    \\ | _  \\|__ __| /_ \\   | |");
            Console.WriteLine("| |\\/| ||  /\\  || - _/  | |  //_\\ \\  | |");
            Console.WriteLine("| |  | ||  \\/  ||   \\   | | / ___  \\ | |__");
            Console.WriteLine("|_|  |_| \\____/ |_|\\_\\  |_|/_/   \\__\\|____|");
        }

        public static void Komb()
        {
            Console.WriteLine(" _  __  ____   _    _  ____     __    _____");
            Console.WriteLine("| |/ / /    \\ |  \\/  || _  \\   /_ \\  |__ __|");
            Console.WriteLine("|   / |  /\\  || |\\/| || - _/  //_\\ \\   | |");
            Console.WriteLine("|   \\ |  \\/  || |  | || _  \\ / ___  \\  | |");
            Console.WriteLine("|_|\\_\\ \\____/ |_|  |_||____//_/   \\__\\ |_|");
        }

        //Menu Wybierania Postaci

        public static void Pos()
        {
            Console.WriteLine(" _____________________________");
            Console.WriteLine("|        Wybierz Postać       |");
            Console.WriteLine("|-----------------------------|");
            Console.WriteLine("| 1. Sub-Zero                 |");
            Console.WriteLine("| 2. Scorpion                 |");
            Console.WriteLine("| 3. Liu Kang                 |");
            Console.WriteLine("| 4. Luna                     |");
            Console.WriteLine("| 5. Drago                    |");
            Console.WriteLine("| 6. Sylvan                   |");
            Console.WriteLine("| 7. Zara                     |");
            Console.WriteLine("| 8. Ryker                    |");
            Console.WriteLine("| 9. Seraphina                |");
            Console.WriteLine("| 10. Kai                     |");
            Console.WriteLine("|_____________________________|");
        }

        public static Character SelectCharacter(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Character("Sub-Zero", 100, 25, 75, 100);
                case 2:
                    return new Character("Scorpion", 100, 25, 75, 100);
                case 3:
                    return new Character("Liu Kang", 100, 25, 75, 100);
                case 4:
                    return new Character("Luna", 120, 20, 75, 100); 
                case 5:
                    return new Character("Drago", 140, 35, 75, 100);
                case 6:
                    return new Character("Sylvan", 80, 30, 75, 100);
                case 7:
                    return new Character("Zara", 90, 40, 75, 100);
                case 8:
                    return new Character("Ryker", 200, 10, 75, 100);
                case 9:
                    return new Character("Seraphina", 80, 30, 75, 100);
                case 10:
                    return new Character("Kai", 120, 30, 75, 100);
                default:
                    throw new ArgumentException("Nieprawidłowy Parametr");
            }
        }
    }
}
