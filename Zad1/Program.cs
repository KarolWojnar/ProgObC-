// See https://aka.ms/new-console-template for more information
using Zad1;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Triangle triangle = new Triangle();
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        shapes.Add(circle);
        shapes.Add(rectangle);
        shapes.Add(triangle);
        for(int i = 0; i < shapes.Count; i++) shapes[iss].Draw();
    }
}