// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] InputArray (int length)
{
    string[] array = new string[length];
    string s ="";
    for (int i = 0; i<length; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент");
        s = Console.ReadLine();
        array[i] = s;
    }
    return array;

}


void PrintArray (string[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


string[] CreateNewArray (string[] array)
{
     string[] newArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i]="";
    }

    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref newArray, j);
    return newArray;
}

Console.WriteLine("Заполните массив из слов");
string [] A = InputArray(8);
PrintArray(A);
string [] B = CreateNewArray(A);
Console.WriteLine("Полученый массив");
PrintArray(B);
Console.WriteLine();

