
int PromptInt(string message)
{
    Console.Write($"{message} >");              // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

string PromptString(string message)
{
    Console.Write($"{message} >");                  // Вывод приглашения
    return Convert.ToString(Console.ReadLine());    // ввод текста
}

string[] FillCreateArray(int cnt)
{
    string[] array = new string[cnt];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = PromptString($"Input {i + 1} word > ");
    }
    return array;
}

string[] ArrayFilter(string[] array, int countOfSymbols)
{
    int countOfElemets = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= countOfSymbols)
        {
            countOfElemets++;
        }
    }
    string[] filter = new string[countOfElemets];
    int cnt = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= countOfSymbols)
        {
            filter[cnt] = array[i];
            cnt++;
        }
    }
    return filter;
}

int Count = PromptInt("Input number of words >");
int CountSymbols = PromptInt("Input maximum number of symbols >");
string[] Array = FillCreateArray(Count);
string[] Filter = new string[Count];
Console.WriteLine("Main Array >>>");
Console.WriteLine($"[{string.Join(", ", Array)}]");
Console.Write("Filter Array>>>");
string[] FilterArray = ArrayFilter(Array, CountSymbols);
Console.WriteLine();
Console.Write($"[{string.Join(", ", FilterArray)}]");