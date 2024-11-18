namespace YellowBeltExam;

public class NPC : Character, IDialogue
{
    public NPC(string name, int health) : base(name, health)
    {
    }
    
    public void Speak(string name, string dialogue)
    {
        Console.WriteLine($"{name} says: {dialogue}");
    }
    
}