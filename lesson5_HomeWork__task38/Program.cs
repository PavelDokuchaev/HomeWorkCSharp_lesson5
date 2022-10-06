/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] getRandomArray(int length, int startPoint, int endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}

void PrintArray(double[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(Math.Round(incomingArray[i], 2));
        if (i < incomingArray.Length - 1)
        {

            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

double findDifferenceMaxMinElementsArray(double[] incomingArray)
{
    double result = new double();
    double maxNumber = incomingArray[0];
    double minNumber = incomingArray[0];
    for (int i = 1; i < incomingArray.Length; i++)
    {
        if (incomingArray[i] > maxNumber)
        {
            maxNumber = incomingArray[i];
        }
        if (incomingArray[i] < minNumber)
        {
            minNumber = incomingArray[i];
        }
        result = maxNumber - minNumber;
    }
    return result;
}

Console.WriteLine("Задайте длинну массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
double[] currentArray = getRandomArray(userNumber, 1, 100);
PrintArray(currentArray);
double DifferenceMaxMinElementsArray = findDifferenceMaxMinElementsArray(currentArray);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {DifferenceMaxMinElementsArray}");
