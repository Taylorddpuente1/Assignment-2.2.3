using System.Reflection.Metadata.Ecma335;

class Circle : Shape
{
    public double Radius { get; set; }


    public Circle(string id, string color, double radius)
           : base(id, "Circle", color)
    {
        Radius = radius;
    }


    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}