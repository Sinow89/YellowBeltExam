namespace YellowBeltExam;

public class Character
{
    public string CharacterName { get; private set; }
    public int CharacterHealth { get; private set; }

    public Character(string name, int health)
    {
        CharacterName = name;
        CharacterHealth = health;
    }
    

    public void Attack()
    {
        
    }
}