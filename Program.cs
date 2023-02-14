/*Задача: написат программу, которая из имеющегося массива строк сформирует массив из строк, длина которых меньше или равна 3.
*/

int getDataFromUser(string message)
{

    printInColor(message, ConsoleColor.Green);
    int data = int.Parse(Console.ReadLine()!);
    return data;
}

string getDataStringFromUser(string message)
{

    printInColor(message, ConsoleColor.Yellow);
    string data = Console.ReadLine()!;
    return data;
}

string[] insertArray(int row)
{
    string[] array = new string[row];
    for (int i = 0; i < row; i++)
    {
        array[i] = getDataStringFromUser($"Введите элемент массива a[{i}] = ");
    }
    return array;
}

int FindNumberOfElements(string[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        { number = number + 1; }
    }
    return number;
}
void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
void printArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        { Console.Write("'" + array[i] + "', "); }
        else { Console.Write("'" + array[i] + "'"); }
    }
    Console.Write("]");
    Console.WriteLine();
}
string[] generateArray(string[] array)
{
    int number = FindNumberOfElements(array);
    string[] arrayNew = new string[number];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[j] = array[i];
            j = j + 1;
        }
    }
    return arrayNew;
}

int row = getDataFromUser("Введите количество элементов массива = ");
string[] array = insertArray(row);
printInColor("Исходный массив" + "\t", ConsoleColor.DarkCyan);
printArray(array);
string[] arrayNew = generateArray(array);
printInColor("Новый массив" + "\t", ConsoleColor.DarkCyan);
printArray(arrayNew);