Console.WriteLine();
string[] array1 = { "Hello", "2", "world", ":-)" };

string result;
Console.Write($"Заданный массив: ");
for (int j = 0; j < array1.Length; j++)
{
    Console.Write($"[{array1[j]}] ");
}
Console.WriteLine();
Console.Write($"Элементы массива, где <= 3 символов: ");
for (int i = 0; i < array1.Length; i++)
{
    result = array1[i];
    if (result.Length < 4)
    {
        Console.Write($"{result} ");
    }
}
Console.WriteLine();
Console.WriteLine();
string[] array2 = { "1234", "1567", "-2", "computer science" };
Console.Write($"Заданный массив: ");
for (int j = 0; j < array2.Length; j++)
{
    Console.Write($"[{array2[j]}] ");
}
Console.WriteLine();
Console.Write($"Элементы массива, где <= 3 символов: ");
for (int i = 0; i < array2.Length; i++)
{
    result = array2[i];
    if (result.Length < 4)
    {
        Console.Write($"{result} ");
    }
}
Console.WriteLine();
Console.WriteLine();
string[] array3 = { "Russia", "Denmark", "Kazan" };
Console.WriteLine();

Console.Write($"Заданный массив: ");
for (int j = 0; j < array3.Length; j++)
{
    Console.Write($"[{array3[j]}] ");
}
Console.WriteLine();
Console.Write($"Элементы массива, где <= 3 символов: ");
for (int i = 0; i < array3.Length; i++)
{
    result = array3[i];
    if (result.Length < 4)
    {
        Console.Write($"->{result} ");
    }
 
}

