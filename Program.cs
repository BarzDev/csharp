namespace ConsoleApp1;

public class Program
{
    public void Main(string[]args)
    // public static void Main(string[]args)
    {

    // cara 1 anonymous method
    var sayHello = delegate()
    {
        Console.WriteLine("Hello, Word");
    };

    // cara 2 mirip js
    var sayHello2 = (string nama) =>
    {
        Console.WriteLine($"Hello, {nama}");
    };


    sayHello();
    sayHello2("akbar");
    }
}

