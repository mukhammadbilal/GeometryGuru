Console.WriteLine("This application calculates the surface area of different geometric shapes.");
Console.WriteLine();

int option = default;

ShowMenu();

ChooseShape();

switch (option)
{
    case 1:
        Console.WriteLine($"Triangle area = {CalculateTriangleArea()}");
        break;
    case 2:
        Console.WriteLine($"Rectangle area = {CalculateRectangleArea()}");
        break;
    case 3:
        Console.WriteLine($"Square area = {CalculateSquareArea()}");
        break;
    case 4:
        Console.WriteLine($"Circle area = {CalculateCircleArea()}");
        break;
    default:
        Console.WriteLine("We only have 4 shapes");
        break;
}

static void ShowMenu()
{
    Console.WriteLine("1. Triangle");
    Console.WriteLine("2. Rectangle");
    Console.WriteLine("3. Square");
    Console.WriteLine("4. Circle");
}

void ChooseShape()
{
    Console.Write("Select shape number: ");

    int number = int.Parse(Console.ReadLine());

    if (1 > number || number > 4)
    {
        Console.WriteLine("Enter number between 1 and 4");
    }
    else
    {
        option = number;
    }
}

double CalculateTriangleArea()
{
    double areaTriangle = 0;

    Console.WriteLine("\nThe formula Area = base * height / 2, where you multiply the base by the perpendicular height and then divide by two");
    Console.WriteLine("Enter the sides and height of the triangle.");

    Console.Write("a = ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("c = ");
    double c = Convert.ToDouble(Console.ReadLine());
    Console.Write("h = ");
    double h = Convert.ToDouble(Console.ReadLine());

    if (a + b < c || a + c < b || b + c < a)
    {
        Console.WriteLine("There is no such triangle");
    }
    else
    {
        areaTriangle = a * h / 2;
    }

    return areaTriangle;
}

int CalculateRectangleArea()
{
    Console.WriteLine("\nTo find a rectangle's area, multiply its length by its width: Area = Length * Width");
    Console.WriteLine("Enter length and width of the rectangle.");

    Console.Write("length = ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("width = ");
    int width = Convert.ToInt32(Console.ReadLine());

    int areaRectangle = length * width;

    return areaRectangle;
}

int CalculateSquareArea()
{
    Console.WriteLine("\nTo count the area of a square, simply multiply the length of one side by itself: Area = side * side");
    Console.Write("Enter side of the square: ");
    int side = Convert.ToInt32(Console.ReadLine());

    int areaSquare = side * side;

    return areaSquare;
}

double CalculateCircleArea()
{
    Console.WriteLine("To count a circle's area, use the formula A = πr²");
    Console.Write("Enter radius of the circle: ");
    double r = Convert.ToInt32(Console.ReadLine());

    double areaCircle = Math.PI * Math.Pow(r, 2);

    return areaCircle;
}