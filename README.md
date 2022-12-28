# Контрольная работа. #

## Задача

    Написать программу, которая из имеюшегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


# Блок схемы основного алгоритма #
    Находится в папке:  block_diagram

<image src="block_diagram\Control_work.png" alt="Алгоритм">
  
# Код #
```cs
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
```
# Тесты #

   1.   [ "hello", "2", "world", ":-)"] -> [ 2, :-)]
   2.   ["12345", "1567", "-2", "computer science"] -> [-2]
   3.   ["Russia", "Denmark", "Kazan"] -> []

## Работу выполнин: студент GeekBrains направления <<Инженер по тестированию>> Беленов Николай Алексеевич.