
---

# 📐 Geometric Shape Area Calculator

This console application calculates the **surface area** of different geometric shapes based on user input.
The application runs in a loop and allows the user to perform multiple calculations until they choose to exit.

## 🚀 Features

The application can calculate the area of the following shapes:

1. **Triangle**
   - Uses **Heron’s formula**
   - Validates whether a triangle with given sides exists

2. **Rectangle**
   - Formula: `Area = Length × Width`

3. **Square**
   - Formula: `Area = side²`

4. **Circle**
   - Formula: `Area = π × r²`

```
The program displays a menu, allows the user to choose a shape, and then asks for the required measurements to compute the area.

## 🧮 Menu Example

1. Triangle
2. Rectangle
3. Square
4. Circle

Select shape number:
```

---

# 📂 Code Overview

The program uses **separate functions** for each shape.
Below are key parts of the code and explanations.

---

## ▶ Main Program Loop

```csharp
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
```

### 📝 What It Does

* Displays the menu
* Accepts user input
* Validates selection
* Calls the correct function
* Repeats if input is invalid
* Asks user to continue or not

---

## 🔺 Triangle Area (Heron's Formula)

```csharp
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
```

### 📝 What It Does

* Explains Heron’s formula
* Reads 3 triangle sides
* Checks triangle inequality
* Computes area using Heron’s formula
* Prints area or error message
* Asks user to continue

---

## ▭ Rectangle Area

```csharp
int CalculateRectangleArea()
{
    Console.WriteLine("\nTo find a rectangle's area, multiply its length by its width: Area = Length * Width");

    Console.Write("Length = ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("Width = ");
    int width = Convert.ToInt32(Console.ReadLine());

    return length * width;
}
```

### 📝 What It Does

* Reads length & width
* Returns `length * width`

---

## ▢ Square Area

```csharp
double CalculateSquareArea()
{
    Console.WriteLine("\nTo count the area of a square, use the formula A = side * side");

    Console.Write("Enter side of the square: ");
    int side = Convert.ToInt32(Console.ReadLine());

    return Math.Pow(side, 2);
}
```

### 📝 What It Does

* Reads side length
* Returns side²

---

## ⚪ Circle Area

```csharp
double CalculateCircleArea()
{
    Console.WriteLine("To count a circle's area, use the formula A = πr²");

    Console.Write("Enter radius of the circle: ");
    double r = Convert.ToInt32(Console.ReadLine());

    return Math.PI * Math.Pow(r, 2);
}
```

### 📝 What It Does

* Reads radius
* Computes area using πr²

---

## 📌 Requirements

* .NET SDK
* C# compiler
* Console environment

---

## 🚀 Usage

Run the program:

```bash
dotnet run
```

Choose a shape and enter the requested values.

---