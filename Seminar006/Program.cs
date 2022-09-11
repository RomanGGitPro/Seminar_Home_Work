//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
 //а первый - на последнем и т.д.)
/*
int [] CreatRandomArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);

    return newArray;   
}
//вывод массива
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
         Console.Write (array[i] + " ");
    Console.WriteLine();    

}


int[] ReversArray (int[]array)
{
    //for (int i = 0; i < array.Length / 2; i++)
    for (int i = 0, j = array.Length - 1; i < j ; i++, j--) //можно записать вот так
    {
        int temp = array[i];
        //array[i] = array[array.Length - 1 - i];// индекс последнего элемента со смещением в право -i
        array[i] = array[j];// соответственно делаем вот такую запись, тк 25 заменили на 26 стр.
        array[j] = temp;
    }
    return array;


}

Console.WriteLine (" Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" Input min posible Value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" Input max posible Value ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreatRandomArray (size, minValue, maxValue); //создали массив
ShowArray (myArray);//продеманстрировали массив (показать)
myArray = ReversArray (myArray);
ShowArray (myArray);


//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//a < b + c 

bool Triangle ( int num1, int num2, int num3)
{
    if( num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
    {
        return true;
    } 
    return false;
}
Console.WriteLine("Первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Третье число");
int third = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Может ли существовать треугольник {Triangle(first,second,third)}");





// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//F(n) = F(n-1) + F(n-2)

void Fibonachi (int a, int b, int n)
{ 
    Console.Write($"{a} {b} ");
    int temp = 0;

    for (int i = 0; i < n; i++)
    {
        temp = a + b;
        a = b;
        b = temp;
        Console.Write($"{b} ");
    }   
}
Console.WriteLine("Первое число Фибоначи");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число Фибоначи");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Количество элементов Фибоначи ");
int n = Convert.ToInt32(Console.ReadLine());

Fibonachi (first, second, n);


//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

string Binary (int num)
{
    string elem = string.Empty;
    while (num > 0)
    {
       int n = num % 2;
       elem = Convert.ToString(n) + elem;
       num = num / 2;
    }
    return elem;
}

Console.WriteLine("Ведите число");
int n = Convert.ToInt32(Console.ReadLine());
string result = Binary (n);
Console.WriteLine(result);


//ДОМАШНЕЕ ЗАДАНИЕ к СЕМИНАРУ 006

//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введи {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double[,] coeff = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients(){
  for (int i = 0; i < coeff.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < coeff.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      coeff[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] coeff)
{
  crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
  crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
  return crossPoint;
}

void OutputResponse(double[,] coeff)
{
  if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(coeff);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResponse(coeff);
*/