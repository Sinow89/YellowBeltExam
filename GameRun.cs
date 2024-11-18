namespace YellowBeltExam;

class GameRun
{
    static void Main()
    {
        Console.WriteLine("Please input your name!");
        string input = Console.ReadLine();
        
        Enemy enemy = new ("Goblin", 50);
        var player = new Player(input, 1000);
        Combat combat = new();
        NPC npc = new("NPC", 50);
        Merchant merchant = new("Merchant", 50);
        

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
                    break;
                case NpcEncounter:
                    npc.Speak("NPC", "Hello stranger!");
                    break;
                case MerchantEncounter:
                    merchant.Speak("Merchant", "Hello stranger!");
                    break;
            }

            if (player.Health == 0)
            {
                playerAlive = false;
            }
        }
        

        
    }
}