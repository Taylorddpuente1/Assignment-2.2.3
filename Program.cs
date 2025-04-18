// Week 2 Assignment 2.2.3
// MON, April 14, 2025
//Write Abstract Base Class , add properties, name, and color, 'calculate area'



using System;
using System.Security.Cryptography.X509Certificates;
abstract class Shape
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public Shape(string id, string name, string color)
    {

        Id = id;
        Name = name;
        Color = color;
    }

    public abstract double CalculateArea();
}
