namespace YellowBeltExam;

public class Combat
{
    private int Experience;
    void GainExperience(int experience)
    {
        Experience += experience;
    }

    public Combat()
    {
        Random rnd = new Random();
        Experience = rnd.Next(10, 50);
    }
    
    public void Fight(Player player, Enemy enemy)
    {
        var random = new Random();
        
        while (true)
        {
            int playerDamage = random.Next(5, 20);
            int enemyDamage = random.Next(1, 10);

            Console.WriteLine("Choose an action:\n1. Attack\n2. Heal\n3. Defend");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                player.Attack(enemy, playerDamage);
                enemy.Health -= playerDamage;
                Console.WriteLine($"{enemy.Name} {enemy.Health} health");
                Console.WriteLine("");
                Thread.Sleep(1000);
            }

            else if (userInput == "2")
            {
                {
                    player.Heal(random.Next(1, 20));
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                }
            }
            else if (userInput == "3")
            {
                player.Health -= enemyDamage;
                Console.WriteLine("");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine($"You fumbled and now you missed the {enemy.Name}...");
                Thread.Sleep(1000);
                Console.WriteLine("Don't do it again!!!");
                Thread.Sleep(1000);
            }
            
            if (player.Health <= 0)
            {
                Console.WriteLine("No you died!");
                Console.WriteLine("Game Over");
                break;
            }
            
            if (enemy.Health <= 0)
            {
                Console.WriteLine($"Victory, you defeated the Goblin!");
                Console.WriteLine($"{player.Name} gained {Experience} experience point");
                enemy.Health = 50;
                break;
            }
            
            player.Health -= enemyDamage;
            Console.WriteLine($"{enemy.Name} attacks the {player.Name} with {enemyDamage} damage");
            Console.WriteLine($"{player.Name}'s health: {player.Health}");
            
        }
    }
}


