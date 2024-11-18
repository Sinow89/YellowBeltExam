namespace YellowBeltExam;

class GameRun
{
    static void Main()
    {
        var player = new Player("Arin", 100);
        var enemy = new Enemy("Orc", 50);
        var npc = new NPC("NPC", 50);
        var merchant = new Merchant("Merchant", 50);

        player.Attack(enemy, 50);
        enemy.Attack(player, 30);
        npc.Speak("NPC", "Hello stranger!");
        merchant.Speak("Merchant", "Hello stranger!");
        
        

    }
}