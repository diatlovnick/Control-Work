

string[] array =  {"12", "23", "-1111", "dd", "=)_"};

printArray(array);



int GetLengthArray(string[] array)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string str;
        str = array[i];
        if (str.Length < 4)
        {
            length++;
        }
    }
    return length;
}

void printArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
 int length = GetLengthArray(array);
 Console.WriteLine(length);





