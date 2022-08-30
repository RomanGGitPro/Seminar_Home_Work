/*
ЗАДАЧА (Семинар 3).
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuadrant (double x, double y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
Console.Write ("Input x coordinat ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write ("Input y coordinat ");
double yA = Convert.ToDouble(Console.ReadLine());
int quandrant = FindQuadrant (xA, yA);
Console.WriteLine ("Num of Quad is " + quandrant); 

ЗАДАЧА (Семинар 3).
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).

void FindXandY(int number);
{
    if (number == 1)
    Console.WriteLine("x > 0 and y > 0 ");
    if (number == 2)
    Console.WriteLine("x > 0 and y < 0 ");
    if (number == 3)
    Console.WriteLine("x < 0 and y < 0 ");
    if (number == 4)
    Console.WriteLine("x > 0 and y < 0 ");
    if (number > 4 || number < 1);
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
FindXandY (num);

Напишите программу, которая принимает на вход число (n) и выдаёт квадраты чисел от 1 до n


void Squar(int number)
{
    int current = 1 ;
    while (current <= number)
    {
        Console.WriteLine(current * current + " ");
        current ++;

    }
}
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Squar(num);


Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 2D пространстве.
Math.Sqrt()


double Distance (double xA, double yA, double xB, double yB)
{
    double catit1 = xA - xB;
    double catit2 = yA - yB;
    double dis = Math.Sqrt(catit1 * catit1 + catit2 * catit2);
    return dis;

}
Console.WriteLine (" Вод первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine (" Вод второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

double dist = Distance (x1,y1,x2,y2);
Console.WriteLine(" Дистанция " + dist);  


ДОМАШНЕЕ ЗАДАНИЕ СЕМИНАР 3 !!!

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.



void Polindrom (int number)
{
    
    int num1left = number / 10;
    int num2right = number % 10;
    int num3 = number % 100;
    int num3left = num3 / 10;
    int num4 = number / 100;
    int num4right = num4 % 10;
    

    if (num1left == num2right || num3left == num4right)
    
        Console.Write (" -> Да ");

    
    
    else Console.Write(" -> Нет ");
    

}

Console.WriteLine("Ведите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
Polindrom(number);



 
Задача 21

Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.


double Distance (double xA, double yA, double zA, double xB, double yB, double zB)
{
    double catit1 = xA - xB;
    double catit2 = yA - yB;
    double catit3 = zA - zB;
    double dis = Math.Sqrt(catit1 * catit1 + catit2 * catit2 + catit3 * catit3);
    return dis;

}
Console.WriteLine (" Вод первой точки ");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine (" Вод второй точки ");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double z2 = Convert.ToDouble(Console.ReadLine());


double dist = Distance (x1,y1,z1,x2,y2,z2);
Console.WriteLine(" Дистанция " + dist);  


Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void Cube (int number)
{
    int current = 1 ;
    while (current <= number)
    {
        Console.WriteLine(current * current * current + " ");
        current ++;

    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Cube(num);

*/

