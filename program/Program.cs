// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string InputString(string msg)
{
    Console.Write(msg);
    string result = Console.ReadLine() ?? "";
    return result;
}

int ArraySize()
{
    int size = -1;
    while (size < 1)
    {
        size = Convert.ToInt32(InputString("Пожалуйста, введите сколько элементов будет в массиве?: "));
        if (size < 1) ErrorMessage();
    }
    return size;
}

void ErrorMessage()
{
    Console.WriteLine("\nВведенное значение некорректно. Повторите ввод.\n");
}

string[] CreateStringArray(int size)
{
    string[] arr = new string[size];
    return arr;
}

void FillArrayCustomStrings(string[] arr)
{
    Console.WriteLine("Пожалуйста, заполните массив.");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = InputString($"Введите элемент №{i + 1}: ");
    }
}

void PrintStringArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write((i + 1 != arr.Length) ? "\"" + arr[i] + "\", " : "\"" + arr[i] + "\"");
    }
    Console.Write(" ]");
}

int CountThreeSymbolsStrings(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) count++;
    }
    return count;
}

void MoveThreeSymbolsStrings(string[] arrSource, string[] arrResult)
{
    for (int i = 0, j = 0; i < arrSource.Length; i++)
    {
        if (arrSource[i].Length < 4) arrResult[j++] = arrSource[i];
    }
}

void Output()
{
    int firstArraySize = ArraySize();
    string[] firstArray = CreateStringArray(firstArraySize);
    FillArrayCustomStrings(firstArray);
    int count = CountThreeSymbolsStrings(firstArray);
    if (count == 0)
    {
        Console.WriteLine("В данном массиве нет строк короче трёх символов.");
    }
    else
    {
        string[] secondArray = CreateStringArray(count);
        MoveThreeSymbolsStrings(firstArray, secondArray);
        PrintStringArray(firstArray);
        Console.Write(" --> ");
        PrintStringArray(secondArray);
    }
}

Output();