namespace YellowBeltExam;

public interface IAttackable
{
    int Health { get; set; }
    void TakeDamage(int damage);
}