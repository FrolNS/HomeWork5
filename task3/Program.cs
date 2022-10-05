/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] getRandomArray(int length, int startPoint, int endPoint)
{
    double[] resultArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1) + new Random().NextDouble();
    }
    return resultArray;
}
void printArray(double[] finalArray)
{
    Console.Write("[");
    for (int i = 0; i < finalArray.Length; i++)
    {
        Console.Write(finalArray[i]);
        if (i < finalArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

double maxNumberOfArray(double[] finalArray)
{
    double maximum = finalArray[0];
    for (int i = 0; i < finalArray.Length; i++)
    {
        if (maximum < finalArray[i])
        {
            maximum = finalArray[i];
        }
    }
    return maximum;
}
double minNumberOfArray(double[] finalArray)
{
    double minimum = finalArray[0];
    for (int i = 0; i < finalArray.Length; i++)
    {
        if (minimum > finalArray[i])
        {
            minimum = finalArray[i];
        }
    }
    return minimum;
}

double[] currentArray = getRandomArray(5, -10, 10);
printArray(currentArray);
double max = maxNumberOfArray(currentArray);
double min = minNumberOfArray(currentArray);
Console.WriteLine($"Максимальное значение - {max}.");
Console.WriteLine($"Минимальное значение - {min}.");
Console.WriteLine($"Разница между максимальным и минимальным значениями равна {max - min}");
