// Программа, позволяющая задавать массив вещественных чисел и
// вычисляющая разницу между максимальным и минимальным элементами массива.
float[] CreateRealNumbersArray(int numberOfElements)
{
    float[] array = new float[numberOfElements];
    Console.WriteLine("Введите значения элементов массива");
    Console.WriteLine("(после ввода каждого элемента нажимайте клавишу Enter): ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = float.Parse(Console.ReadLine()!);
    }
    return array;
}
void PrintArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
float GetMinimumValue(float[] array)
{
    float minimumValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimumValue) minimumValue = array[i];
    }
    return minimumValue;
}
float GetMaximumValue(float[] array)
{
    float maximumValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maximumValue) maximumValue = array[i];
    }
    return maximumValue;
}
float GetMaximumAndMinimumValuesDifference(float maximumValue, float minimumValue)
{
    float difference = maximumValue - minimumValue;
    return difference;
}
Console.WriteLine();
Console.WriteLine("Программа определения разницы между максимальным и минимальным элементами массива");
Console.WriteLine("(программа позволяет задать массив вещественных чисел).");
Console.WriteLine();
Console.Write("Введите количество элементов массива: ");
int numberOfElements = int.Parse(Console.ReadLine()!);
if (numberOfElements < 2)
{
    Console.WriteLine("Неверный ввод");
}
else
{
    float[] array = CreateRealNumbersArray(numberOfElements);
    Console.WriteLine("Массив:");
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {GetMaximumAndMinimumValuesDifference(GetMaximumValue(array), GetMinimumValue(array))}");
    Console.WriteLine();
}