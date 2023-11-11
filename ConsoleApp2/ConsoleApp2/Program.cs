using ConsoleApp2;

Circle circle1 = new Circle("Circle 1", 5);
Circle circle2 = new Circle("Circle 2", 7);

Square square1 = new Square("Square 1", 4);
Square square2 = new Square("Square 2", 6);



string DisplayLargestArea(params Shape[] shapes)
{
    Shape largestAreaShape = shapes[0];

    foreach (var shape in shapes)
    {
        if (shape.Area() > largestAreaShape.Area())
        {
            largestAreaShape = shape;
        }
    }
    return largestAreaShape.Name;
}

Console.WriteLine(DisplayLargestArea(circle1, circle2));
Console.WriteLine(DisplayLargestArea(square1, square2)); 

