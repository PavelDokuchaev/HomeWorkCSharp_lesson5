/* Задача 37(сложная необязательная): Найдите произведение 
пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

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
    Console.Write("]");
}

int[] findSumStartEndElements(int[] incomingArray)
{
    int newArrayLength = (int)Math.Ceiling(incomingArray.Length / 2.0);
    int[] resultArray = new int[newArrayLength];
    for (int i = 0; i < newArrayLength; i++)
    {
        resultArray[i] = incomingArray[i] * incomingArray[incomingArray.Length - 1 - i];
    }
    return resultArray;
}

Console.WriteLine("Задайте длинну массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] currentArray = getRandomArray(userNumber, 1, 10);
printArray(currentArray);
Console.Write(" -> ");
int[] sumStartEndElementsArray = findSumStartEndElements(currentArray);
printArray(sumStartEndElementsArray);
Console.WriteLine();
