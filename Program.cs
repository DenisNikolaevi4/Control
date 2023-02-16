string[] array1 = { "Hello", "2", "world", ":-)", "кто ", "пи" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

void PrintArray(string[] array)
{
    Console.Write($"Заданный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}
void ResultArray(string[] array)
{
    Console.Write($"Элементы массива, где <= 3 символов: ");
    for (int i = 0; i < array.Length; i++)
    {
        int length = 4;
        string result = array[i];
        if (result.Length < length)
        {
            Console.Write($"{result} ");
        }
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();
PrintArray(array1);
ResultArray(array1);
PrintArray(array2);
ResultArray(array2);
PrintArray(array3);
ResultArray(array3);



// Console.WriteLine();
// string[] array1 = { "Hello", "2", "world", ":-)" };

// string result;
// Console.Write($"Заданный массив: ");
// for (int j = 0; j < array1.Length; j++)
// {
//     Console.Write($"[{array1[j]}] ");
// }
// Console.WriteLine();
// Console.Write($"Элементы массива, где <= 3 символов: ");
// for (int i = 0; i < array1.Length; i++)
// {
//     result = array1[i];
//     if (result.Length < 4)
//     {
//         Console.Write($"{result} ");
//     }
// }
// Console.WriteLine();
// Console.WriteLine();
// string[] array2 = { "1234", "1567", "-2", "computer science" };
// Console.Write($"Заданный массив: ");
// for (int j = 0; j < array2.Length; j++)
// {
//     Console.Write($"[{array2[j]}] ");
// }
// Console.WriteLine();
// Console.Write($"Элементы массива, где <= 3 символов: ");
// for (int i = 0; i < array2.Length; i++)
// {
//     result = array2[i];
//     if (result.Length < 4)
//     {
//         Console.Write($"{result} ");
//     }
// }
// Console.WriteLine();
// Console.WriteLine();
// string[] array3 = { "Russia", "Denmark", "Kazan" };
// Console.WriteLine();

// Console.Write($"Заданный массив: ");
// for (int j = 0; j < array3.Length; j++)
// {
//     Console.Write($"[{array3[j]}] ");
// }
// Console.WriteLine();
// Console.Write($"Элементы массива, где <= 3 символов: ");
// for (int i = 0; i < array3.Length; i++)
// {
//     result = array3[i];
//     if (result.Length < 4)
//     {
//         Console.Write($"->{result} ");
//     }
 
// }

