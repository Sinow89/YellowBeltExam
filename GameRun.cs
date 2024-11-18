namespace YellowBeltExam;

class GameRun
{
    static void Main()
    {
        Console.WriteLine("Please input your name!");
        string input = Console.ReadLine();
        Console.WriteLine($"{input} says: Ready for battle!");
        Enemy enemy = new ("Goblin", 50);
        var player = new Player(input, 100);
        var random = new Random();
        int heroDamage = random.Next(1, 20);

        Console.WriteLine($"A wild {enemy.Name} with {enemy.Health} health and 5 damage appears!");
        
        Console.WriteLine("Choose an action:\n1. Attack\n2. Heal");
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            player.Attack(enemy, 50);
        }

        else if(userInput == "2")
        {
            {
                player.Heal();
            }
        }
      
        
        var npc = new NPC("NPC", 50);
        var merchant = new Merchant("Merchant", 50);

        // player.Attack(enemy, 50);
        // enemy.Attack(player, 20);
        // npc.Speak("NPC", "Hello stranger!");
        // merchant.Speak("Merchant", "Hello stranger!");
        
        

    }
}