//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
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
//Дальше мы делаем: Найдите сумму отрицательных и положительных элементов массива.
// Положительные
int FindePositiveSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0 ) sum += array[i]; //sum = sum + array[i];

    }
    return sum;
}
// Отрицательные
int FindeNegotiveSum (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0 ) sum += array[i]; //sum = sum + array[i];

    }
    return sum;
}
Console.WriteLine (" Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" Input min posible Value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (" Input max posible Value ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [] myArray = CreatRandomArray (size, minValue, maxValue); //создали массив
ShowArray (myArray); //продеманстрировали массив (показать)

int PositiveSum = FindePositiveSum (myArray); //вызвали этот массив, чтобы отобрать положительные элементы
int NegotiveSum = FindeNegotiveSum (myArray); //вызвали этот массив, чтобы отобрать отрицательные элементы
// \n переход на следующую строку
Console.WriteLine ($" Sum of positive elements is {PositiveSum} \n Sum of negotive elements is {NegotiveSum}");

//Задача: Напишите программу замена элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.



/*
Задача: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
(на вход берет массив и заданное число и возвращает bool - да или нет)


Задача: Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения 
которых лежат в отрезке [10,99]. на вход берет 

int [] FillArray (int size, int min, int max)
{
    int [] numbers = new int[size];
    
    for (int i = 0; i < numbers.Length; i++)
        numbers[i] = new Random().Next(min, max +1);
    return numbers;
            
}
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
         Console.Write (array[i] + " ");
    Console.WriteLine();     
}

int QuantityDoble (int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 10 && array[i] < 100)
        {
            quantity++;   
        }
        
    return quantity; 
}

int [] numbers = FillArray (12, 0, 999);
ShowArray(numbers);
Console.WriteLine();

int quantity = QuantityDoble(numbers);
Console.WriteLine($"Количество двоных элементов в массиве: {quantity}");


//ДОМАШНЕЕ ЗАДАНИЕ:

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
/*
int [] numbers = new int[10];
void FillArray (int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(min, max);
            
}
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
         Console.Write (array[i] + " ");
    Console.WriteLine();     
}

int QuantityPositive (int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 ==0)
        {
            quantity++;   
        }
        
    return quantity; 
}
FillArray(numbers, 100, 1000);
ShowArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");


Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.


int [] FillArray (int size, int min, int max)
{
    int [] numbers = new int[size];
    
    for (int i = 0; i < numbers.Length; i++)
        numbers[i] = new Random().Next(min, max +1);
    return numbers;
            
}
void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
         Console.Write (array[i] + " ");
    Console.WriteLine();     
}
int SumDigit (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
     
      if(i %2 == 1 ) sum += array[i]; //sum = sum + array[i]; 
    return sum; 
}

int [] numbers = FillArray (5, 0, 10);
ShowArray(numbers);
int Sum = SumDigit(numbers);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях -> {Sum}");

Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.


double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
  */