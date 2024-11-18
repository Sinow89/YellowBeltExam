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
    
    public void Heal(int heal)
    {
        var random = new Random();
        Console.WriteLine("Hero heals himself");
        Console.WriteLine($"{heal} points healed ");
        Health += heal;
        Console.WriteLine($"{Health} health points");
        }
    
}