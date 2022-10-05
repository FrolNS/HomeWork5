/* 
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] getRandomArray(int length, double startPoint, double endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] finalArray)
{
    Console.Write("[");
    for (int i = 0; i < finalArray.Length; i++)
    {
        Console.Write(finalArray[i]);
        if (i < finalArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

int getSumOfUnevenNumbers(int[] finalArray)
{
    int sumOfUneven = 0;
    for (int i = 1; i < finalArray.Length; i += 2)
    {
        sumOfUneven = sumOfUneven + finalArray[i];
    }
    return sumOfUneven;
}

int[] currentArray = getRandomArray(5, -10, 10);
printArray(currentArray);
int result = getSumOfUnevenNumbers(currentArray);
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях равна {result}");