

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