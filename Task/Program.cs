//Написать программу,которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
string[] array = new string[] { "hello", "233", ";-)", "1234", "-2", "computer siense",
"Russia", "cat" };
string[] myArray = new string[array.Length];
void GetArrayLess3(string[] array, string[] myArray)
{
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            myArray[j] = array[i];
            j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
GetArrayLess3(array, myArray);
PrintArray(myArray);
