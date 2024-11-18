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
        // Health -= damage;
        Console.WriteLine($"{Name} attacks {target.Name} with {damage} damage");
    }
    
    private void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage and has {Health} health left.");
    }

    public void Heal(int heal)
    {
        var random = new Random();
        int heroDamage = random.Next(1, 20);
        Console.WriteLine("Hero heals himself");
        Console.WriteLine($"{heal} points healed ");
        Health += heal;
        Console.WriteLine($"{Health} health points");
        }
    
}