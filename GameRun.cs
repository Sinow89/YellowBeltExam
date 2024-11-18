namespace YellowBeltExam;

class GameRun
{
    static void Main()
    {
        Console.WriteLine("Please input your name!");
        string input = Console.ReadLine();
        
        Enemy enemy = new ("Goblin", 50);
        var player = new Player(input, 50);
        NPC npc = new("NPC", 50);
        Merchant merchant = new("Merchant", 50);
        Combat combat = new();
        bool playerAlive = true;
        
        while (playerAlive)
        {
            var randomEncounter = new Random();
            int randomNumber = randomEncounter.Next(1, 4);

            const int EnemyEncounter = 1;
            const int NpcEncounter = 2;
            const int MerchantEncounter = 3;
            
            switch (randomNumber)
            {
                case EnemyEncounter:
                    Console.WriteLine($"{input} says: Ready for battle!");
                    Console.WriteLine($"A wild {enemy.Name} with {enemy.Health} health!");
                    combat.Fight(player, enemy);
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    break;
                case NpcEncounter:
                    npc.Speak("Villager", "Hello stranger!");
                    npc.Speak("Villager", "Don't get lost in the woods");
                    Console.WriteLine("");
                    Thread.Sleep(1000);
                    break;
                case MerchantEncounter:
                    merchant.Speak("Merchant", "Hello stranger!");
                    break;
            }
            
            if (player.Health <= 0)
            {
                playerAlive = false;
            }

        }
        
    }
}