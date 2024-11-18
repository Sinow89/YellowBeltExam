﻿namespace YellowBeltExam;

class GameRun
{
    static void Main()
    {
        // Console.WriteLine("Please input your name!");
        string input = Console.ReadLine();
        Console.WriteLine($"{input} says: Ready for battle!");
        Enemy enemy = new ("Goblin", 50);
        var player = new Player(input, 1000);
        Combat combat = new();
        NPC npc = new("NPC", 50);
        Merchant merchant = new("Merchant", 50);


        Console.WriteLine($"A wild {enemy.Name} with {enemy.Health} health!");

        
        var randomEncounter = new Random();
        int randomNumber = randomEncounter.Next(1, 4);

        const int EnemyEncounter = 1;
        const int NpcEncounter = 2;
        const int MerchantEncounter = 3;

        switch (randomNumber)
        {
            case EnemyEncounter:
                combat.Fight(player, enemy);
                break;
            case NpcEncounter:
                npc.Speak("NPC", "Hello stranger!");
                break;
            case MerchantEncounter:
                merchant.Speak("Merchant", "Hello stranger!");
                break;
        }







    }
}