int CountLengths(string[] array)
{
    int lenght = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) lenght++;
    }
    return lenght;
}

string[] NewArray(string[] array, int length)
{
    string[] ResultArray = new string[length];
    int t = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            ResultArray[t] = array[i];
            t++;
            if(t >= length) break;
        }
    }
    return ResultArray;
}

string ArrayUp3(string[] Three)
{
    string result = "[";

    for (int i = 0; i < Three.Length; i++)
    {
        result += "\""+ Three[i] + "\", ";
    }
    result += "]";
    return result;
}

string[] MyArray = new string[4] {"один", "два", "три", ":)"};
Console.WriteLine($"Массив из строк, длина которых меньше, либо равна 3 символам: {ArrayUp3(NewArray(MyArray, CountLengths(MyArray)))}"); 