namespace ConsoleApp1;

public class RefrencesAndValues
{
    public void Main(string[]args)
    // public static void Main(string[]args)
    {
        int a = 10;
        int b = a;
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        b = 15;
        Console.WriteLine($"b: {b}");

        ShowValue(a);
        Console.WriteLine($"a: {a}");
        ShowReferences(ref a);
        Console.WriteLine($"a: {a}");


        // array itu by refrences

        var numbers = new int[]{1,2,3,4};
        // var anotherNumber = number; // alamat memory yg di copy (pass by refrences)
        var anotherNumbers = new int[numbers.Length];
        Array.Copy(numbers, anotherNumbers, numbers.Length);

        anotherNumbers[0] = 10;

        Console.WriteLine(numbers.GetHashCode());
        Console.WriteLine(anotherNumbers.GetHashCode());

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    Console.WriteLine();
        foreach (var number in anotherNumbers)
        {
            Console.Write(number + " ");
        }
    }

// Passing by Value
    public static void ShowValue( int a) 
    {
        a*=a;
        Console.WriteLine($"variavle a di dalam method: {a}");
    }
// Passing by Refrence
    public static void ShowReferences(ref int a) 
    {
        a*=a;
        Console.WriteLine($"variavle a di dalam method: {a}");
    }
}
