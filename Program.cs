Console.WriteLine("This application calculates the surface area of different geometric shapes.");

bool isRepeat = false;

do
{
    Console.WriteLine();
    Console.WriteLine("1. Triangle");
    Console.WriteLine("2. Rectangle");
    Console.WriteLine("3. Square");
    Console.WriteLine("4. Circle");

    Console.Write("\nSelect shape number: ");
    int option = int.Parse(Console.ReadLine());

    if (0 < option && option < 5)
    {
        switch (option)
        {
            case 1:
                CalculateTriangleArea();
                break;
            case 2:
                Console.WriteLine($"\nRectangle area = {CalculateRectangleArea()}");
                AskToContinue();
                break;
            case 3:
                Console.WriteLine($"\nSquare area = {CalculateSquareArea()}");
                AskToContinue();
                break;
            case 4:
                Console.WriteLine($"\nCircle area = {CalculateCircleArea()}");
                AskToContinue();
                break;
        }
    }
    else
    {
        isRepeat = true;
        Console.WriteLine("Enter number between 1 and 4");
    }
} while (isRepeat);

void CalculateTriangleArea()
{
    Console.WriteLine("\nTo find triangle area, we use Heron's formula: Area = Math.Sqrt(p(p−a)(p−b)(p−c)), where p = (a + b + c) / 2");
    Console.WriteLine("First, let's check whether a triangle with such sides exists.");
    Console.WriteLine("Enter the sides of the triangle.");

    Console.Write("a = ");
    double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b = ");
    double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("c = ");
    double c = Convert.ToDouble(Console.ReadLine());

    double p = (a + b + c) / 2;

    if (a + b <= c || a + c <= b || b + c <= a)
    {
        Console.WriteLine("There is no such triangle. The sum of the lengths of any two sides must be greater than the length of the third side.");

    }
    else
    {
        double areaTriangle = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine($"\nTriangle area = {areaTriangle}");
    }
    
    AskToContinue();
}

int CalculateRectangleArea()
{
    Console.WriteLine("\nTo find a rectangle's area, multiply its length by its width: Area = Length * Width");
    Console.WriteLine("Enter length and width of the rectangle.");

    Console.Write("Length = ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("Width = ");
    int width = Convert.ToInt32(Console.ReadLine());

    return length * width;
}

double CalculateSquareArea()
{
    Console.WriteLine("\nTo count the area of a square, use the formula A = side * side");
    Console.Write("Enter side of the square: ");
    int side = Convert.ToInt32(Console.ReadLine());

    return Math.Pow(side, 2);
}

double CalculateCircleArea()
{
    Console.WriteLine("To count a circle's area, use the formula A = πr²");
    Console.Write("Enter radius of the circle: ");
    double r = Convert.ToInt32(Console.ReadLine());

    return Math.PI * Math.Pow(r, 2);
}

void AskToContinue()
{
    Console.Write("\nDo you want to continue(Yes/No, y/n): ");

    string answer = Console.ReadLine();

    if (answer == "Yes" || answer == "yes" || answer == "Y" || answer == "y")
    {
        isRepeat = true;
    }
    else
    {
        isRepeat = false;
    }

    Console.Clear();
}