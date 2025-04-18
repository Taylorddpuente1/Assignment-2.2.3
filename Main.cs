
using System.Drawing;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {

    
    Console.WriteLine("Please enter shape (Circle or Square): ");
        string Myshape = Console.ReadLine();

        Console.WriteLine("Enter shape ID: ");
        string id = Console.ReadLine();

        Console.WriteLine("Enter shape color: ");
        string color = Console.ReadLine();

        Shape shape = null;

        if (Myshape == "circle")
        {
            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine());
            shape = new Circle(id, color, radius);
        }
        else if (Myshape == "square")
        {
            Console.WriteLine("Enter side:");
            double side = double.Parse(Console.ReadLine());
            shape = new Square(id, color, side);
        }
        else
        {
            Console.WriteLine("Invalid shape type!");
            return;
        }

        Console.WriteLine($"\nShape Info:");
        Console.WriteLine($"ID: {shape.Id}");
        Console.WriteLine($"Name: {shape.Name}");
        Console.WriteLine($"Color: {shape.Color}");
        Console.WriteLine($"Area: {shape.CalculateArea():F2}");
    }
}
