// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string Input(string msg)
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
        size = Convert.ToInt32(Input("Пожалуйста, введите сколько элементов будет в массиве?: "));
        if (size < 1) ErrorMsg();
    }
    return size;
}
 
void ErrorMsg()
{
    Console.WriteLine("\nВведенное значение некорректно. Повторите ввод.\n");
}
 
string[] CreateStringArray(int size)
{
    string[] arr = new string[size];
    return arr;
}
 
void FillSourceArray(string[] arr)
{
    Console.WriteLine("Пожалуйста, заполните массив.");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Input($"Введите элемент №{i + 1}: ");
    }
    // return arr;
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
 
int CountValues(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) count++;
    }
    return count;
}
 
void FillResultArray(string[] arrSource, string[] arrResult)
{
    for (int i = 0, j = 0; i < arrSource.Length; i++)
    {
        if (arrSource[i].Length < 4) arrResult[j++] = arrSource[i];
    }
    // return arrResult;
}
 
void Output()
{
    int arrSize = ArraySize();
    string[] firstArray = CreateStringArray(arrSize);
    FillSourceArray(firstArray);
    int count = CountValues(firstArray);
    if (count == 0)
    {
        Console.WriteLine("В данном массиве нет строк короче трёх символов.");
    }
    else
    {
        string[] secondArray = CreateStringArray(count);
        FillResultArray(firstArray, secondArray);
        PrintStringArray(firstArray);
        Console.Write(" --> ");
        PrintStringArray(secondArray);
    }
}
 
Output();