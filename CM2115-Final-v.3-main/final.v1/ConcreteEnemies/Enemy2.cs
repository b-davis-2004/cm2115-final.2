namespace final.v1;

public class Enemy2 : IEnemy
{
    public string Name => "Enemy2";
    public int Health { get; set; } = 100;
    public int AttackPower => 20;

    public bool IsDefeated => Health <= 0;

    public void Attack(Player player)
    {
        Console.WriteLine($"{Name} does xyz for {AttackPower} damage!");
        player.Health -= AttackPower;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} does xyz, taking {damage} damage!");
    }
}

//Defining specific enemy type with its unique properties and behaviors
//Will be renamed for actual enemy name later
//Implements IEnemy interface
//Provides concrete implementations for Attack and TakeDamage methods
//Includes properties for Name, Health, AttackPower, and IsDefeated status
