// Контрольная работа

void MethodCreateInputArray(string[] InputArray)
{
    Console.Write($"Input array: ");
    for (int i = 0; i < InputArray.Length; i++) Console.Write($"{InputArray[i]} ");
    Console.WriteLine();
}

void MethodCreateOutputArray(string[] OutputArray)
{
    Console.Write($"Output array: ");
    string[] newarr = new string[OutputArray.Length];
    for (int i = 0; i < OutputArray.Length; i++)
    {
        if (OutputArray[i].Length <= 3)
        {
            newarr[i] = OutputArray[i];
            Console.Write($"{newarr[i]} ");
        }
    }
    Console.WriteLine();
}

string[] array = { "hello", "2", "world", ":-)"};
Console.WriteLine ("Тест 1");
Console.WriteLine();
MethodCreateInputArray(array);
Console.WriteLine();
MethodCreateOutputArray(array);
Console.WriteLine();

string[] arrayА = { "12345", "1567", "-2", "computer science"};
Console.WriteLine ("Тест 2");
Console.WriteLine();
MethodCreateInputArray(arrayА);
Console.WriteLine();
MethodCreateOutputArray(arrayА);
Console.WriteLine();


string[] arrayB = { "Russia", "Denmark", "Kazan"};
Console.WriteLine ("Тест 3");
Console.WriteLine();
MethodCreateInputArray(arrayB);
Console.WriteLine();
MethodCreateOutputArray(arrayB);
Console.WriteLine();