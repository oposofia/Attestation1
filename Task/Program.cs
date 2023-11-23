// // Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] CreateArray(int size)
{
    Console.WriteLine("Введите элементы массива (строки)");
    string[] arr = new string[size];
    for (int i=0; i<size; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("] ");
}

string[] NewArray(string[] arr)
{
    int sizeNew = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)  sizeNew++;
    }
    string[] arrNew = new string[sizeNew];
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)  
        {
            arrNew[n] = arr[i];
            n++;
        }
    }
    return arrNew;
}

Console.WriteLine("Введите количество элементов массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] stringArray = CreateArray(sizeArray);
PrintArray(stringArray);
Console.Write($" -> ");
PrintArray(NewArray(stringArray));
Console.WriteLine();
