
string[] str = { "Volvo", "BMW", "Ford", "Mazda", "Uaz", "Kia" };

string[] Pick3symbols(string[] str)
{
    int CountSize = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
            CountSize++;
    }

    string[] StringArrayof3Symbols = new string[CountSize];
    int j = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
            StringArrayof3Symbols[j] = str[i];
            j++;
        }
    }
    return StringArrayof3Symbols;
}

void printArray(string[] str)
{
    Console.Write("[ ");
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write($"{str[i]}; ");
    }
    Console.Write("]");
    }
    
printArray(Pick3symbols(str));
