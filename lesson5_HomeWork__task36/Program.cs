/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
        if(i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int calculateSumElementsOddPositins(int[] incomingArray)
{
    int sum = 0;
    for (int i = 1; i < incomingArray.Length; i += 2)
    {
        sum += incomingArray[i]; 
    }
    return sum;
}

Console.WriteLine("Задайте длинну массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] currentArray = getRandomArray(userNumber, -10, 10);
printArray(currentArray);
int sumElementsOddPositins = calculateSumElementsOddPositins(currentArray);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {sumElementsOddPositins}");
