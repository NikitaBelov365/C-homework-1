//Задача 4: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

System.Console.WriteLine("Enter number and i'll show you all even numbers from 1 \nEnter number:");

double number = Convert.ToDouble(Console.ReadLine());

if(number >= 2)
{
    int begin = 2;
    while(begin < number + 1)
    {
        System.Console.WriteLine($"Here you are: {begin}");
        begin = begin + 2;
    }
}
else if(number <= -2)
{
    int begin = -2;
    while(begin > number - 1)
    {
        System.Console.WriteLine($"Here you are: {begin}");
        begin = begin - 2;
    }
}
else
{
    System.Console.WriteLine($"There is no even numbers from 1 to {number}, sorry.");
}