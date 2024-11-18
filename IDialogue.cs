namespace YellowBeltExam;

public interface IDialogue
{
    string Name { get; }
    void Speak(string dialogue);
}