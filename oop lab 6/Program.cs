// See https://aka.ms/new-console-template for more information
// Коляда Олександра
using System;
// Оголошення класу
class Calculator
{
    // Метод, який додає два числа
    public double Add(double a, double b)
    {
        return a + b;
    }
    // Метод, який віднімає одне число від іншого
    public double Subtract(double a, double b)
    {
        return a - b;
    }
    // Метод, який множить два числа
    public double Multiply(double a, double b)
    {
        return a * b;
    }
    // Метод, який ділить перше число на друге
    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Помилка: Ділення на нуль неможливе.");
        return 0;
        }
        return a / b;
    }
    //Метод, який підносить число a до степення b
    public double Power(double a, double b)
    {
        return Math.Pow(a,b);
    }
    //Метод, який знаходить остачу від ділення числа a на b
    public double Modulus(double a, double b)
    {
        return a % b;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта класу Calculator
        Calculator myCalculator = new Calculator();
        Console.WriteLine("Виберіть операцію:");
        Console.WriteLine("1. Додавання");
        Console.WriteLine("2. Віднімання");
        Console.WriteLine("3. Множення");
        Console.WriteLine("4. Ділення");
        Console.WriteLine("5. Піднесення до степення");
        Console.WriteLine("6. Остача від ділення");
        // Вибір операції
        Console.Write("Ваш вибір: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        // Введення операндів
        Console.Write("Введіть перший операнд: ");
        double operand1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть другий операнд: ");
        double operand2 = Convert.ToDouble(Console.ReadLine());
        // Виконання обраної операції
        switch (choice)
        {
            case 1:
                double sumResult = myCalculator.Add(operand1,
               operand2);
                Console.WriteLine("Результат: " + sumResult);
                break;
            case 2:
                double subResult = myCalculator.Subtract(operand1,
               operand2);
                Console.WriteLine("Результат: " + subResult);
                break;
            case 3:
                double mulResult = myCalculator.Multiply(operand1,
               operand2);
                Console.WriteLine("Результат: " + mulResult);
                break;
            case 4:
                double divResult = myCalculator.Divide(operand1,
               operand2);
                Console.WriteLine("Результат: " + divResult);
                break;
            case 5:
                double powResult = myCalculator.Power(operand1,
               operand2);
                Console.WriteLine("Результат: " + powResult);
                break;
            case 6:
                double modResult = myCalculator.Modulus(operand1,
               operand2);
                Console.WriteLine("Результат: " + modResult);
                break;
            default:
                Console.WriteLine("Неправильний вибір операції.");
                break;
        }
    }
}
