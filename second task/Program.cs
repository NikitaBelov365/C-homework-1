//Задача 2: Напишите программу, которая принимает на 
//вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Input three numbers and i'll find a bigger number of them \nEnter first number:");
double firstNumber = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Enter second number:");
double secondNumber = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Enter third number:");
double thirdNumber = Convert.ToDouble(Console.ReadLine());

double max = firstNumber;

if(secondNumber > max)
{
    max = secondNumber;
}
if(thirdNumber > max)
{
    max = thirdNumber;
}

System.Console.WriteLine($"{max} is the biggest value!");