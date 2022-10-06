/*  *Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}

void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int determineEvenNumbers(int[] incomingArray)
{
    int result = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] % 2 == 0)
        {
            result += 1;
        }
    }
    return result;
}

Console.WriteLine("Задайте длинну массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] currentArray = getRandomArray(userNumber, 100, 999);
printArray(currentArray);
int quantityEvenNumbers = determineEvenNumbers(currentArray);
Console.WriteLine($"Количество чётных чисел в массиве равно {quantityEvenNumbers}");

