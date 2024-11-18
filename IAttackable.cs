namespace YellowBeltExam;

public interface IAttackable
{
    int Health { get; set; }
    string Name { get; }
    void TakeDamage(int damage);
}