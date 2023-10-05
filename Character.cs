public class Character
{
    public string Name { get; private set; }
    public int Health { get; set; }
    public int AttackDamage { get; set; }
    public int Gold { get; set; }
    public int Mana { get; set; }

    public Character(string name, int health, int attackDamage, int gold, int mana)
    {
        Name = name;
        Health = health;
        AttackDamage = attackDamage;
        Gold = gold;
        Mana = mana;
    }

    public void TakeDamage(int damage, bool isChargedAttack)
    {
        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }

        if (isChargedAttack)
        {
            Mana -= 60;
            if (Mana < 0)
            {
                Mana = 0;
            }
        }
    }
}
