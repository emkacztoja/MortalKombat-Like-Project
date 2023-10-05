using System;

internal class Dod_Play
{
    private Enemy enemy;

    public Dod_Play()
    {
        Random genr = new Random();
        int wrg = genr.Next(1, 16);

        string[] enemyNames = {
            "Mileena", "Baraka", "Sindel", "Raiden", "Kitana",
            "Goro", "Shang Tsung", "Sonya Blade", "Johnny Cage", "Kano",
            "Jax", "Zephyr", "Scorpion", "Viperia", "Kabal" };
        string enemyName = enemyNames[wrg - 1];
        int health = genr.Next(80, 120);
        int attackDamage = genr.Next(15, 25);

        enemy = new Enemy(enemyName, health, attackDamage);
    }

    public Enemy Enemy
    {
        get { return enemy; }
    }

    public void PrintEnemyInfo()
    {
        Console.WriteLine($"Walczysz z {enemy.Name} (Życie: {enemy.Health}, Damage: 15).");
    }
}
