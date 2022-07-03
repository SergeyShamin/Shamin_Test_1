/* 
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части,
 если вы выделяете ее в отдельный метод) 
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так,
что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина 
которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше
обойтись исключительно массивами.
*/
int ReadInt()
{
    string input = Console.ReadLine();

    return Convert.ToInt32(input);
}

string[] FirstArray()
{
    int length = ReadInt();
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine("Введите значения для массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] SecondArray(string[] array)
{
    string[] result = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string text = array[i];
        if (text.Length <= 3)
        {
            result[i] = text;
        }
    }
    return result;
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++) 
    {
        Console.WriteLine($"{array[i]}");
    }
}

string[] array = FirstArray();
SecondArray(array);
PrintArray(array);