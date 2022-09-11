/*
Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int FindSum (int num)
{

   int sum = 0;

  for (int current = 1; current <= num; current++)
       sum += current;
  return sum; 

  

}

Console.WriteLine ("Input positive integer number ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ($"Sum of numbers from 1 to {a} is {FindSum (a)}");

Задача 1 практика:
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int SizeDigit (int number)
{
 int size = 0;
 while(number > 0) 
  {
      number = number/10;
      size ++;
  }
  return size;
}

Console.WriteLine ("Ведите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sizenum = SizeDigit(num);
Console.WriteLine ($"Число {num} состоит из {sizenum} чисел");

Задача 2 практика:
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


int Multiplication (int number)
{

   int fact = 1;

    for (int current = 1; current <= number;current ++)
    {
        fact = fact * current;

    }
    return fact;
    


}

Console.WriteLine ("Ведите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine ($"Факториал числа {num} = {Multiplication (num)}");

Задача 3 практика:
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в 
случайном порядке.


int [] MakeArr (int size)
{
 int [] array = new int [size];
 return array;
}

void FillArrey (int [] array)
{
    int lenght = array.Length;
    int i =0;
    while ( i < lenght)
    {
        array [i] = new Random().Next(0,2);
        i++;
    }

}

int Sizearr = 8;
int [] array = MakeArr (Sizearr);     
FillArrey (array);


for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

ДОМАНЕЕ ЗАДАНИЕ СЕМИНАР 004

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }
    
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);



Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.

  

int SumNumber(int num)
{
    
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
    return result;
}

Console.WriteLine ("Ведите число ");
int num = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(num);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);


Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int [] numbers = new int[8];
void FillArray (int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
       numbers[i] = new Random().Next(min, max +1);

      
}
//вывод массива
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
         Console.Write (array[i] + " ");
    Console.WriteLine();   
}
FillArray (numbers, 10, 100);
ShowArray(numbers);
Console.WriteLine();

*/