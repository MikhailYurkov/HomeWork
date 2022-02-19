
using static System.Console;

void PrintStringArray(string[] stringArray)
{
    Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Write($"\"{stringArray[i]}\"");
        if (i != stringArray.Length - 1)
        {
            Write(", ");
        }
    }
    Write("]");
}

int CreateArrayWithSizeLessOrEqual3(string[] stringArray)
{
    int numberOfString = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <4) 
        {
            numberOfString++;
    
        }
    }
    return numberOfString;
}


string[] stringArray = { "Hello", "world", "2", ":-)" };


PrintStringArray(stringArray);
//WriteLine(CreateArrayWithSizeLessOrEqual3(stringArray));