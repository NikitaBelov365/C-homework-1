//Задача 1: Напишите программу, 
//которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

System.Console.WriteLine("When you input two numbers, i'll show you which is more, which is less. \nEnter first number:");
double firstNumber = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Enter second number:");
double secondNumber = Convert.ToDouble(Console.ReadLine());

if(firstNumber > secondNumber)
{
    System.Console.WriteLine($"{firstNumber} is bigger than {secondNumber}");
}
if(secondNumber > firstNumber)
{
    System.Console.WriteLine($"{firstNumber} is less than {secondNumber}");
}
if(secondNumber == firstNumber)
{
    System.Console.WriteLine($"{firstNumber} is equal to {secondNumber}");
}