namespace YellowBeltExam;

public class Merchant : Character, IDialogue
{
    public Merchant(string name, int health) : base(name, health)
    {
    }
    
    public void Speak(string name, string dialogue)
    {
        Console.WriteLine($"{name} says: {dialogue}");
    }
}