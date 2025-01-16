using Practice_Polymorphism;

Square square = new Square()
{
    Height = 4,
    Width = 4
};

Rectangle rectangle = new Rectangle()
{
    Height = 8,
    Width = 4,
};

Triangle triangle = new Triangle()
{
    Height = 6,
    Width = 4
};

Console.WriteLine("Square Area: " + square.CalculateArea());
Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());
Console.WriteLine("Triangle Area: " + triangle.CalculateArea());

