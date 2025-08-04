// Simple Calculator Program for Basic Arithmetic Operations
// Created for educational purposes
// Created by: [Lucas Dias Ferreira - Affaled]

double firstNumber;
double secondNumber;
string operation;
double result;

Console.WriteLine("Enter first number: ");
firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number: ");
secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter operation (+ to add, - to subtract, * to multiply, / to divide): ");
operation = Console.ReadLine();

switch (operation)
{
    case "+":
        result = firstNumber + secondNumber;
        Console.WriteLine($"Result: {result}");
        break;
    case "-":
        result = firstNumber - secondNumber;
        Console.WriteLine($"Result: {result}");
        break;
    case "*":
        result = firstNumber * secondNumber;
        Console.WriteLine($"Result: {result}");
        break;
    case "/":
        if (secondNumber != 0)
        {
            result = firstNumber / secondNumber;
            Console.WriteLine($"Result: {result}");
        }
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        break;
     default:
        Console.WriteLine("Error: Invalid operation.");
        break;
}