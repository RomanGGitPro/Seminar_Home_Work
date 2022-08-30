/* Напишите программу, которая на вход принимает число и выдаёт его квадрат 
(число умноженное на само себя).
Console.Write("Ведите число ");

int namber = Convert.ToInt32(Console.ReadLine());

int kvadrat = namber * namber;

Console.WriteLine("Квадрат числа " + namber + " Это " + kvadrat);
// Можно записать тоже самое, только короче!

Console.WriteLine($"Квадрат числа {namber} это {kvadrat}");

/* Задача 1
Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.


Console.WriteLine("ведите первое число ");
int namber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("ведите второе число " );
int namber2 = Convert.ToInt32(Console.ReadLine());

int kvadrat= namber2 / 2 ;
if (namber1 == kvadrat)
{
  Console.Write("первое число является квадратом второго" );  
}
else
{
  Console.Write("первое число НЕ является квадратом второго" );   
}
/*

/*Задача 2
Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.


Console.WriteLine("Ведите число ");
int namber = Convert.ToInt32(Console.ReadLine());
int current = namber * (-1);

while (current<=namber)

{
Console.Write(current + " ");
current= current + 1;

}
*/

/* Домашнее задание, Семинар 1.
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
          какое число большее, а какое меньшее.

Console.WriteLine("Ведите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

int left = number1;
int right = number2;


if (left>right)
{
Console.WriteLine("Число " + number1 + " больше числа " + number2);
}

else

{
Console.Write(" Число " + number2 + " больше числа " + number1);
}


Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
из этих чисел.

Console.Write("Ведите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());  

Console.Write("Ведите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;


if (max < number2) 

{
    max = number2;
}

if (max < number3)

{
    max = number3;
}

Console.WriteLine("Максимальное число " + max);



Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
          является ли число чётным (делится ли оно на два без остатка).


Console.Write("Ведите число ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number%2;
if (num==0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}


Задача 8: Напишите программу, которая на вход принимает число (N), 
          а на выходе показывает все чётные числа от 1 до N.

*/
Console.WriteLine("Ведите число ");
int namber = Convert.ToInt32(Console.ReadLine());

int current = 1;

while (current<=namber)
{
     if (current % 2 == 0)
{
    Console.Write(current + " ");
    
}
current ++;
}

