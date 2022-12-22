// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"Total {numbers.Length} numbers, {count} even numbers");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
Console.WriteLine("Input array size");
 int size = Convert.ToInt32(Console.ReadLine());
 int[] numbers = new int[size];
 FillArrayRandomNumbers(numbers);
 Console.WriteLine("Array: ");
 PrintArray(numbers);
 int sum = 0;

 for (int z = 0; z < numbers.Length; z+=2)
     sum = sum + numbers[z];

     Console.WriteLine($"Total {numbers.Length} numbers, sum of elements at odd positions = {sum}");

 void FillArrayRandomNumbers(int[] numbers)
 {
     for(int i = 0; i < numbers.Length; i++)
         {
             numbers[i] = new Random().Next(1,10);
         }
 }
 void PrintArray(int[] numbers)
 {
     Console.Write("[ ");
     for(int i = 0; i < numbers.Length; i++)
         {
             Console.Write(numbers[i] + " ");
         }
     Console.Write("]");
     Console.WriteLine();
 }

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*
Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"Total {numbers.Length} numbers. Max value = {max}, Min value = {min}");
Console.WriteLine($"Difference between Max and Min value = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

*/
