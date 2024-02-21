namespace ConsoleApp1;

public class Hero : IHitAble
{
    public string? Name { get; set;}
    public int Hp { get; set;}
    public int BaseDamage { get; set;}


    public void Attack(IHitAble hitAble)
    {
        hitAble.GetHit(BaseDamage);
    }

// implement IHitAble
    public void GetHit(int damage)
    {
        Console.WriteLine($"{Name} terkena {damage} damage");
        Hp -= damage;
    }
}