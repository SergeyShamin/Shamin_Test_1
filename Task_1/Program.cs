int ReadInt()
{
    string input = Console.ReadLine();

    return Convert.ToInt32(input);
}

string[] ReadArray()
{
    Console.WriteLine("Задайте длину массива: ");
    int length = ReadInt();
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите значения для массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray (string[] array, int count)
{
    for (int i = 0; i < count; i++) 
    {
        Console.WriteLine($"{array[i]}");
    }
}

// Этап 1. 
string[] array = ReadArray();

// Этап 2. 
string[] result = new string[array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    string text = array[i];
    if (text.Length <= 3)
    {
        result[count] = text;
        count = count + 1;
    }
}

// Этап 3. 
Console.WriteLine();
Console.WriteLine("Результат: ");

if (count == 0)
{
    Console.WriteLine("Нет элементов с трехзначными значениями");
}
else
{
    PrintArray(result, count);
}