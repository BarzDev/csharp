namespace ConsoleApp1;

/*
Naming convention interface di C# menggunakan huruf I sebelum nama Interface
*/

public interface IHitAble
{
    // public void GetHit();
    void GetHit(int damage);  // tidak perlu menambahkan acces modifier public, karena sudah auto public
}