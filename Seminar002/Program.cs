/*
ПРАКТИКА!!

Напишите программу, которая выводит случайное число из отрезка [10, 99] и
 показывает наибольшую цифру числа.


int FindBiggerDigit (int number)
{
    int ed = number % 10;
    int dec= number /10;
    int max;
    if (ed > dec) max = ed;
    else max= dec;
    return max;
}
int randNumber = new Random().Next(10,100);
int biggerDigit = FindBiggerDigit(randNumber);
Console.WriteLine($"В числе {randNumber} наибольшее число {biggerDigit}");

Напишите программу, которая выводит случайное трёхзначное число и 
удаляет вторую цифру этого числа.


int FindRandnumber (int number)
{
    int ed = number % 10;
    int dec = number / 100;
    int result = (dec * 10) + ed;
   
    return result;

}
int randNumber = new Random().Next(10,1000);
int chengnumber = FindRandnumber(randNumber);
Console.WriteLine($"Число {randNumber} изменилось на {chengnumber}");





/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.



ДОМАШНЕЕ ЗАДАНИЕ семинар 2.

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.


int FindRandnumber (int number)
{
    int ed = number % 100;
    int mid = ed / 10;
    int result = mid;
   
    return result;

}
Console.WriteLine("Ведите число ");
int number1 = Convert.ToInt32(Console.ReadLine());
int chengnumber = FindRandnumber(number1);
Console.WriteLine($"Второе число из числа {number1} это {chengnumber}");

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.


void ThirdDigit (int number)
{
   
   if ( anyNumberText.Length > 2)
   {
     Console.WriteLine("третья цифра -> " + anyNumberText[2]);

   }
  
   else
    {
        Console.WriteLine("-> третьей цифры нет");
  
    }
}
Console.Write("Введи число: ");    
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
ThirdDigit (anyNumber);
/*

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
проверяет, является ли этот день выходным.

void Whatisdayoftheweek (int daynumber)
{

   if (daynumber == 6 || daynumber == 7)
   Console.WriteLine (" ДА выходной! ");
   
   
   else if (daynumber < 1 || daynumber > 7)
   {
    Console.WriteLine(" Нет такого дня ");
   }
   
   

   else Console.WriteLine("Этот день НЕ выходной! ");
   
         
}

Console.WriteLine("Ведите число дня недели ");
int daynumber = Convert.ToInt32(Console.ReadLine());
Whatisdayoftheweek(daynumber);
*/