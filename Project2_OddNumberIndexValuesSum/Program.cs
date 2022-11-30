// Программа, определяющая сумму элементов на нечётных позициях 
// в одномерном массиве случайных чисел. 
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void CreateRandomNumbersArray(int[] array)
{
    Console.Write("Введите начальное значение диапазона элементов массива: ");
    int startElementValue = int.Parse(Console.ReadLine()!);
    Console.Write("Введите конечное значение диапазона элементов массива: ");
    int endElementValue = int.Parse(Console.ReadLine()!);
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(startElementValue, endElementValue + 1);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int GetOddIndexValuesSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
Console.WriteLine();
Console.WriteLine("Программа определения суммы элементов на нечётных позициях массива");
Console.WriteLine("(для одномерного массива случайных чисел).");
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
    CreateRandomNumbersArray(array);
    Console.WriteLine("Массив:");
    PrintArray(array);
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов на нечётных позициях массива: {GetOddIndexValuesSum(array)}");
    Console.WriteLine();
}