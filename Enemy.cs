namespace YellowBeltExam;

public class Enemy : Character 
{
    public Enemy(string name, int health) : base(name, health)
    {
    }

    public void EnemeySwith(string input, Combat combat, Player player, Enemy enemy)
    {
        Console.WriteLine($"{input} says: Ready for battle!");
        Console.WriteLine($"A wild {Name} with {Health} health!");
        combat.Fight(player, enemy);
        Console.WriteLine("");
        Thread.Sleep(1000);
    }
}