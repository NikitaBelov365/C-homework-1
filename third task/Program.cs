//Задача 3: Напишите программу, которая на вход принимает число
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.WriteLine("Hello there! Give me some integer number and i'll show you is the number even or not. \nEnter number:");

int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    System.Console.WriteLine("Your number is even.");
}
else
{
    System.Console.WriteLine("Your number is not even.");
}