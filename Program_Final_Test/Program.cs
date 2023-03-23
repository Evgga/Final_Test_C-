// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] ArrayStrings = new string[] { };
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 
ArrayStrings = new string[n];
for (int i = 0; i < ArrayStrings.Length; i++)
{
    Console.Write($" Введите {i + 1} элемент: ");
    ArrayStrings[i] = Console.ReadLine();
}
Console.WriteLine();


int CheckArray(string[] array, int length)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= length) result++;
    }
    return result;
}

int length = 3;
int numbers = CheckArray(ArrayStrings, length); 
string[] newArrayStrings = new string[numbers]; 
NewArray(ArrayStrings, newArrayStrings, length);

void NewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " ]";
    return result;
}

Console.WriteLine($"{PrintArray(ArrayStrings)} -> {PrintArray(newArrayStrings)}");
Console.WriteLine();
