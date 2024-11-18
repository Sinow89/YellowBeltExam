using System.Net.Sockets;

namespace YellowBeltExam;

public class Merchant : Character, IDialogue
{
    public Merchant(string name, int health) : base(name, health)
    {
    }
    
    public void Speak(string name, string dialogue)
    {
        Console.WriteLine($"{name} says: {dialogue}");
        Trade();
    }
    
    List<string> MerchantInventoryList = new List<string> { "Sword - 100 gold", "Shield - 50 gold", "Potion - 20 gold" };

    public void Trade() 
    {
        {
            int playerGold = 200;
            while (true)
            {
                Console.WriteLine("Merchant's inventory:");
                foreach (var item in MerchantInventoryList)
                {
                    Console.WriteLine($"- {item}");
                }

                Console.WriteLine("Do you want to buy?(Quit to leave) Specify what you want to buy:");
                string response = Console.ReadLine();

                if (response == "sword"|| response == "Sword")
                {
                    MerchantInventoryList.Remove("Sword - 100 gold");
                    playerGold -= 100;
                    Console.WriteLine($"You have {playerGold} gold left.");
                }
                else if (response == "shield"|| response == "Shield")
                {
                    MerchantInventoryList.Remove("Shield - 50 gold");
                    playerGold -= 50;
                    Console.WriteLine($"You have {playerGold} gold left.");
                }
                else if (response == "potion" || response == "Potion")
                {
                    MerchantInventoryList.Remove("Potion - 20 gold");
                    playerGold -= 20;
                    Console.WriteLine($"You have {playerGold} gold left.");
                }
                else if (response == "quit" || response == "Quit")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid selection or item not available.");
                }

                if (MerchantInventoryList.Count == 0)
                {
                    Console.WriteLine("Merchant's inventory is now empty.");
                    Console.WriteLine("Thanks for buying all of my inventory!");
                    break;
                }
            }
        }
    }
}