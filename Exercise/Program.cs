/*Задача: Написать программу, которая из 
имеющегося массива строк формирует новый 
массив из строк, длина которых меньше, либо 
равна 3 символам. Первоначальный массив 
можно ввести с клавиатуры, либо задать на 
старте выполнения алгоритма. При решении не 
рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

Console.WriteLine("Введите значения через пробел: ");
string[] stringArr = Console.ReadLine().Split();


PrintArray(CharSize(stringArr));

string[] CharSize(string[] array)
{
    string[] arr = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) arr[i] = array[i];

    }
    return arr;

}


void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($" {inArray[i]} ");
    }
    Console.WriteLine();
}