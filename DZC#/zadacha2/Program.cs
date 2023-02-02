// //Задача Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.2, 3, 7 -> 7


Console.WriteLine("vvedite 3 chisla");
int numberA = Convert.ToInt32 (Console.ReadLine());
int numberB= Convert.ToInt32 (Console.ReadLine());
int numberC = Convert.ToInt32 (Console.ReadLine());

int max = numberA ;
if (numberB > max) max=numberB;
if (numberC > max) max = numberC;
{
    
}
{
}
Console.WriteLine max;
