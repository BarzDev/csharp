namespace ConsoleApp1;

public class ExceptionHandling
{
    public static void Main(string[] args)
    {
        // root class error di c# itu adalah Exception
        /*
        error dibagi menjadi 3 :
        - Runtime Error
        - Syntax Error
        - Compile Error

        contoh error
        DividedByZeroException
        NullReferenceException

        keyword yg digunakan untuk handle exception :
        try, catch, finally, throw
        */

        try
        {
            var a = 10;
            var b = 0;
            Console.WriteLine(a / b);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            Console.WriteLine("Kode setelah error");
        }
    }


    public string FindName()
    {
        List<string> names = new List<string>
        {
            "Jution",
            "Stefano",
            "Doni",
            "Sulton",
        };

        string? tempName = null;

        foreach (var name in names)
        {
            if (name is null) continue;
            tempName = name;
        }

        if(tempName is null) throw new Exception(message:"name not found");

        return tempName;
    }
}

