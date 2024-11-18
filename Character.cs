namespace YellowBeltExam;

public class Character : IAttacker
{
    
    public string Name { get; private set; }
    public int Health { get; set; }

    public Character(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
    public void Attack(Character target, int damage)
    {
        Console.WriteLine($"{Name} attacks {target.Name} with {damage} damage");
    }
    
    private void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage and has {Health} health left.");
    }

    public void Heal()
    {
        var random = new Random();
        int heal = random.Next(1, 20);
        Console.WriteLine("Hero heals himself");
        Thread.Sleep(1000);
        Console.WriteLine($"{heal} points healed ");
        Health += heal;
        Thread.Sleep(1000);
    }
    
}