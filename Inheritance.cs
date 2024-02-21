namespace ConsoleApp1;

public class Employee
{
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? Division { get; set; }

// disebut METHOD
    public virtual void sayHi(Employee employee)
    {
        Console.WriteLine($"Hi, {employee.Name}");
    }
}

    /*
    Inheritance : pewarisan yang menurunkan attribute ataupun method di OOP
    Keyword untuk inheritance di C# menggunakan titik dua (:)

    base keyword itu adalah cara kita untuk mengakses parent class yg sudah di inherit
    overload --> membuat method dengan nama yg sama namun parameternya berbeda
    override --> overwrite, menuliskan ulang kode method dari parent dan dituliskan ulang di child class
    */

public class Manager : Employee
{
    public override void sayHi(Employee employee)
    {
        Console.WriteLine($"Hi, {employee.Name}, ini manager {Name}");
    }
}

public class Supervisor : Employee
{
    public override void sayHi(Employee employee)
    {
        Console.WriteLine($"Hi, {employee.Name}, ini supervisor {Name}");
    }
    public void sayHello()
    {}
}


public class Inheritance
{
    // public static void Main(string[]args)
    public void Main(string[]args)
    {
/*
    Contoh 1 ----------------⤵⤵⤵
        var manager = new Manager();
        manager.Name = "Akbar";

        var budi = new Employee{
            Name = "Budi"
        };

        manager.sayHi(budi);
*/
/* contoh 2 */

    Supervisor andi = new Supervisor();  // Supervisor yg awal dijadikan variabel
    andi.Name = "Andi";
    andi.sayHello();    // memiliki method dari supervisor karena tipe supervisor
    Employee andi2 = new Supervisor();  // menjadikan parent Employee ke supervisor (masih bisa)
    andi2.Name = "Andi2";
    // andi2.sayHello();   // tidak memiliki methode sayHello karena tipe employee


    andi.sayHi(andi2);

    // Supervisor andi3 = new Employee();  // dari child ke parent tidak bisa

    }

}
