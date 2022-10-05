/*  
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] getRandomArray(int length)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {   
        resultArray[i] = new Random().Next(100, 1000);
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
int getAmountOfEvenNumbers(int[] finalArray)
{
    int amountOfEven = 0;
    for (int i = 0; i < finalArray.Length; i++)
    {
        if (finalArray[i] % 2 == 0)
        {
            amountOfEven++;
        }
    }
    return amountOfEven;
}


int[] currentArray = getRandomArray(10);
printArray(currentArray);
int result = getAmountOfEvenNumbers(currentArray);
Console.WriteLine($"Количество четных чисел равно {result}");