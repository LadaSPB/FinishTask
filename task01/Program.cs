void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Введите " + i + " элемент массива: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}
void NewArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
            Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}

Console.WriteLine("Введите первоначальный размер элементов массива");
int massif = Convert.ToInt32(Console.ReadLine());
string[] array = new string[massif];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Введённый первоначальный массив: [{string.Join(", ", array)}]");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Полученный массив: ");
NewArray(array);
Console.ResetColor();