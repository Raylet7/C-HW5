// Программа, задающая массив случайных целых чисел 
// и создающая отдельный массив из: 
// максимального элемента первоначалального массива и его индекса, 
// минимального элемента и его индекса, 
// среднего арифметического всех элементов (с пояснениями). 
// Программа определяет также медианное значение первоначалального массива. 
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
void PrintNewArray(string[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write(newArray[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
int GetMaximumValue(int[] array)
{
    int maximumValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maximumValue) maximumValue = array[i];
    }
    return maximumValue;
}
int GetMaximumValueIndex(int[] array)
{
    int maximumValueIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == GetMaximumValue(array))
        {
            maximumValueIndex = i;
            break;
        }
    }
    return maximumValueIndex;
}
int GetMinimumValue(int[] array)
{
    int minimumValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimumValue) minimumValue = array[i];
    }
    return minimumValue;
}
int GetMinimumValueIndex(int[] array)
{
    int minimumValueIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == GetMinimumValue(array))
        {
            minimumValueIndex = i;
            break;
        }
    }
    return minimumValueIndex;
}
double GetAverageValue(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    double averageValue = sum / array.Length;
    return averageValue;
}
string DoubleToStringValues(double value)
{
    string result = value.ToString();
    return result;
}
double[] FillNewValuesArray(int[] array)
{
    double[] newArray = new double[5];
    newArray[0] = GetMaximumValue(array);
    newArray[1] = GetMaximumValueIndex(array);
    newArray[2] = GetMinimumValue(array);
    newArray[3] = GetMinimumValueIndex(array);
    newArray[4] = GetAverageValue(array);
    return newArray;
}
double GetMedianValue(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    int index = 0;
    double result = -1;
    if (array.Length % 2 == 0)
    {
        int beforeCenter = array.Length / 2;
        int afterCenter = beforeCenter - 1;
        double aValue = array[beforeCenter];
        double bValue = array[afterCenter];
        result = (aValue + bValue) / 2;
    }
    else
    {
        index = array.Length / 2;
        result = array[index];
    }
    return result;
}
Console.WriteLine();
Console.WriteLine("Программа вычисления медианного значения массива целых чисел и");
Console.WriteLine("создания отдельного массива из следующих элементов:");
Console.WriteLine("максимального и минимального элементов первоначального массива,");
Console.WriteLine("их индексов и среднего арифметического всех элементов");
Console.WriteLine("(с пояснениями).");
Console.WriteLine();
Console.Write("Введите количество элементов массива: ");
int numberOfElements = int.Parse(Console.ReadLine()!);
if (numberOfElements < 2)
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
    double[] newArray = FillNewValuesArray(array);
    string maximumValue = DoubleToStringValues(newArray[0]);
    string maximumValueIndex = DoubleToStringValues(newArray[1]);
    string minimumValue = DoubleToStringValues(newArray[2]);
    string minimumValueIndex = DoubleToStringValues(newArray[3]);
    string averageValue = DoubleToStringValues(newArray[4]);
    Console.WriteLine();
    string[,] matrix = { { "максимальное значение:", maximumValue },
                         { "индекс максимального значения:", maximumValueIndex },
                         { "минимальное значение:", minimumValue },
                         { "индекс минимального значения:", minimumValueIndex },
                         { "среднее арифметическое:", averageValue } };
    Console.WriteLine("Массив из полученных значений:");
    PrintNewArray(matrix);
    Console.WriteLine($"Медианное значение первоначалального массива: {GetMedianValue(array)}");
    Console.WriteLine();
}