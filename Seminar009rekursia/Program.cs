//Задайте значение N. Напишите программу, которая выведет все 
//натуральные числа в промежутке от 1 до N.
/*
void ShowNums (int n)
{
   if (n > 1) ShowNums (n-1);

   Console.Write(n +" ");
}
ShowNums(5);

void ShowNums (int n)
{
   if (n > 1) 
   {
     Console.Write(n +" ");
     ShowNums (n-1);
   }
   Console.Write(n +" ");
   

   
}
ShowNums(5);

//Напишите программу, которая будет принимать на вход число и 
//возвращать сумму его цифр.

int SumOfDigits (int n)
{
  if (n > 0) return SumOfDigits (n / 10) + n %10;
  else return 0;
}
Console.WriteLine(SumOfDigits(5364));


//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNums (int m, int n)
{
   if (m < n ) 
   {
    ShowNums (m,n-1);
   }

   Console.Write(n +" ");

}
int M = 1;
int N = 55;
ShowNums(M, N);

//Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.


int PowerAtoB (int A, int B)
{
    if (B > 1) return PowerAtoB (A,B -1) * A;
    else  return A;
}

int numA =6;
int numB = 2;
Console.WriteLine(PowerAtoB(numA,numB));




// ДОМАШНЕЕ ЗАДАНИЕ СЕМИНАР 009



//Задача 64: 
//Задайте значения M и N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.


void ShowNums (int n, int m)
{
   if (n < m)
   {
    ShowNums (n,m-1);
   }
   Console.Write(m +" ");

}
Console.WriteLine("Введите число N ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число M ");
int m1 = Convert.ToInt32(Console.ReadLine());

ShowNums(n1,m1);


//Задача 66: 
//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.


void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите начальное число M:");
int numberN = Convert.ToInt32(Console.ReadLine());
GapNumberSum(numberM, numberN, 0);

//Задача 68: 
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.


int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}
Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");

*/

