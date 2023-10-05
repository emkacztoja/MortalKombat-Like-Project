using System;

public class Shop
{
    private Character playerCharacter;

    public Shop(Character character)
    {
        playerCharacter = character;
    }

    public void ShowShopMenu()
    {
        Console.WriteLine("Witamy w Sklepie");
        Console.WriteLine("1. Mikstura leczenia (+20 życia) - 10 golda");
        Console.WriteLine("2. Mikstura siły (+5 damage) - 15 golda");
        Console.WriteLine("3. Wyjście");
    }

    public void BuyItem(int choice)
    {
        switch (choice)
        {
            case 1:
                if (playerCharacter.Gold >= 10)
                {
                    playerCharacter.Health += 20;
                    playerCharacter.Gold -= 10;
                    Console.WriteLine("Zakupiłeś miksturę leczenia (+20 życia) za 10 golda");
                }
                else
                {
                    Console.WriteLine("Nie posiadasz wystarczająco złota aby zakupić ten przedmiot");
                }
                break;
            case 2:
                if (playerCharacter.Gold >= 15)
                {
                    playerCharacter.AttackDamage += 5;
                    playerCharacter.Gold -= 15;
                    Console.WriteLine("Zakupiłeś miksturę siły (+5 damage) za 15 golda");
                }
                else
                {
                    Console.WriteLine("Nie posiadasz wystarczająco złota aby zakupić ten przedmiot");
                }
                break;
            case 3:
                Console.WriteLine("Wychodzisz ze sklepu (it's not a bug, it's a feature)");
                break;
            default:
                Console.WriteLine("Nieprawidłowy parametr");
                break;
        }
    }
}
