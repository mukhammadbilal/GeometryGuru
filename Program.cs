
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("This application calculates the surface area of different geometric shapes");
Console.WriteLine("--------------------------------------------------------------------------");
Console.ResetColor();

do
{
    ShowMenu();

    int option = SelectMenuOption(0, 5);

    switch (option)
    {
        case 1:
            HandleTriangle();
            break;
        case 2:
            HandRectangle();
            break;
        case 3:
            HandleSquare();
            break;
        case 4:
            HandleCircle();
            break;
    }
} while (AskToContinue());

void ShowMenu()
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Main Menu");
    Console.WriteLine("1. Triangle");
    Console.WriteLine("2. Rectangle");
    Console.WriteLine("3. Square");
    Console.WriteLine("4. Circle");
    Console.ResetColor();
}

int SelectMenuOption(int min, int max)
{
    Console.Write("\nSelect shape number: ");

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int option) &&
            min < option && option < max)
        {
            return option;
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Enter number between 1 and 4: ");
        Console.ResetColor();
    }
}

bool AskToContinue()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("\nDo you want to continue(y/n): ");

    string answer = Console.ReadLine().ToLower();
    Console.ResetColor();

    return answer == "y" || answer == "yes";
}

void HandleTriangle()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nTo find triangle area, we use Heron's formula: A = Math.Sqrt(p(p−a)(p−b)(p−c)), where p = (a + b + c) / 2");
    Console.WriteLine("Enter the sides of the triangle:");

    Console.Write("a = ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("c = ");
    double c = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();

    if (!IsValidTriangle(a, b, c))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("There is no such triangle. The sum of the lengths of any two sides must be greater than the length of the third side");
        Console.ResetColor();
        return;
    }

    double areaTriangle = CalculateTriangleArea(a, b, c);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nTriangle area = {areaTriangle}");
    Console.ResetColor();
}

void HandRectangle()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\nFormula for Rectangle area: A = Length * Width");
    Console.WriteLine("Enter length and width of the rectangle.");

    Console.Write("Length = ");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.Write("Width = ");
    double width = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();

    double areaRectangle = CalculateRectangleArea(length, width);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nRectangle area = {areaRectangle}");
    Console.ResetColor();
}

void HandleSquare()
{
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("\nFormula for Square area: A = side * side");

    Console.Write("Enter side of the square: side = ");
    double side = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();

    double areaSquare = CalculateSquareArea(side);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nSquare area = {areaSquare}");
    Console.ResetColor();

}

void HandleCircle()
{
    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.WriteLine("\nFormula for Circle area: A = πr²");

    Console.Write("Enter radius of the circle: r = ");
    double radius = Convert.ToDouble(Console.ReadLine());
    Console.ResetColor();

    double areaCircle = CalculateCircleArea(radius);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"\nCircle area = {areaCircle}");
    Console.ResetColor();

}

bool IsValidTriangle(double sideA, double sideB, double sideC)
{
    return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
}

double CalculateTriangleArea(double a, double b, double c)
{
    double p = (a + b + c) / 2;

    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
}

double CalculateRectangleArea(double length, double width) => length * width;

double CalculateSquareArea(double side) => side * side;

double CalculateCircleArea(double radius) => Math.PI * radius * radius;