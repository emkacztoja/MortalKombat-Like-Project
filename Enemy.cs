public class Enemy
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int AttackDamage { get; private set; }

    public Enemy(string name, int health, int attackDamage)
    {
        Name = name;
        Health = health;
        AttackDamage = attackDamage;
    }

    public void TakeDamage(int damage, bool isChargedAttack)
    {
        if (isChargedAttack)
        {
            damage *= 2;
        }

        Health -= damage;
        if (Health < 0)
        {
            Health = 0;
        }
    }
}
