

string[] array = {"123","1234","qwe","qwerty","=)","@_-_@","eW2we2_@1"};

int length = GetLengthArray(array);
string[] resArray = GetResArray(array,length);
printArray(array);
Console.Write(" -> ");
printArray(resArray);



string[] GetResArray(string[] array, int length)
{
    string[] resArray = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
        {         
            string str;
            str = array[i];
            if (str.Length < 4)
            {
                resArray[j] = array[i];
                j++;
            }
            
            
        }
    return resArray;
}
//printArray(resArray);
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
        if (array.Length == 1)
            Console.Write($"[{array[i]}]");
        else if (i == 0)
            Console.Write($"[{array[i]}, ");
        else if (i == array.Length - 1)
             Console.Write($"{array[i]}]");
        else
            Console.Write($"{array[i]}, ");
    }
}






