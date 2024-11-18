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
    
    List<string> MerchantInventoryList = new List<string> { "Sword", "Shield", "Potion" };

    public void Trade() 
    {
        {
            Console.WriteLine($"Merchant's inventory: {MerchantInventoryList[0]}, {MerchantInventoryList[1]}, {MerchantInventoryList[2]}");
        }
    }
}