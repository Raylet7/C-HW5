// Программа, показывающая количество чётных чисел в массиве,
// заполненном случайными положительными трёхзначными числами.
// [345, 897, 568, 234] -> 2
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
void CountArrayEvenNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result++;
    }
    Console.WriteLine($"Количество чётных чисел в массиве: {result}");
}
Console.WriteLine();
Console.WriteLine("Программа определения количества чётных чисел в массиве");
Console.WriteLine("(для массива случайных положительных трёхзначных чисел).");
Console.WriteLine();
Console.Write("Введите количество элементов массива: ");
int numberOfElements = int.Parse(Console.ReadLine()!);
if (numberOfElements <= 0)
{
    Console.WriteLine("Неверный ввод");
}
else
{
    int[] array = new int[numberOfElements];
    FillArray(array);
    Console.WriteLine("Массив:");
    PrintArray(array);
    Console.WriteLine();
    CountArrayEvenNumbers(array);
    Console.WriteLine();
}