namespace YellowBeltExam;

public interface IAttacker
{
    int Health { get; set; }
    void Attack(Character target, int damage);
    
}