using System;

class Square : Shape
{
    public double Side { get; set; }

    public Square(string id, string color, double side)
    : base(id, "Square", color)
  {
        Side = Side;
  }

   public override double CalculateArea()
    {
        return Side * Side; 
    }
}