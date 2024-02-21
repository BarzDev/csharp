namespace ConsoleApp1;
/*
Perbedaan "virtual" dan "abstract"
--> virtual , pewarisan sebuah method/atribute tapi tidak wajib di override
--> abstact , harus bodynya kosong dan wajib di override
*/

public abstract class Shape
{
    public abstract double GetSurface();
}

public class Rectangle : Shape
{
    public double Width { get; set;}
    public double Length { get; set;}

    public override double GetSurface()
    {
      return Width * Length;
    }
}