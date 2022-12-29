// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше либо равна 3 символа.

// Простой вариант

Console.WriteLine("Введите размер массива");
int Size = Convert.ToInt32(Console.ReadLine());
string[] StringArray = new string[Size];
for (int i = 0; i < Size; i++)
{
    Console.WriteLine($"Введите {i+1}-ый элемент массива");
    StringArray[i] = Console.ReadLine();
}
PrintArraySort (StringArray);


void PrintArraySort (string [] Array)
{
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        Console.WriteLine($"Элемент массива = {StringArray[i]}, соответствует условию сортировки");
    }
}
}

// Console.WriteLine("Введите размер массива");
// int Size = Convert.ToInt32(Console.ReadLine());
// string[] StringArray = new string[Size];

// StringArray = FillArray(Size);

// string[] ArraySort = FillArraySort(StringArray);

// PrintArraySort(ArraySort);

// // Функции:

// string[] FillArray(int Size)
// {
//     string[] StringArray = new string[Size];
//     for (int i = 0; i < Size; i++)
//     {
//         Console.WriteLine($"Введите {i + 1}-ый элемент массива");
//         StringArray[i] = Console.ReadLine();
//     }
//     return StringArray;
// }

// string[] FillArraySort(string[] Array)
// {
//     string[] ArraySort = new string[Array.Length];
//     for (int i = 0; i < Array.Length; i++)
//     {
//         if (Array[i].Length <= 3)
//         {
//             ArraySort[i] = Array[i];
//         }
//     }
//     return ArraySort;
// }

// void PrintArraySort(string[] Array)
// {
//     for (int i = 0; i < Array.Length; i++)
//     {
//         if (Array[i] != null)
//         {
//             Console.WriteLine($"Элемент массива = {Array[i]}, соответствует условию сортировки");
//         }
//     }
// }