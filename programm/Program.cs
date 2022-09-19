string[] initialArray = {"dfghg", "er?", "34", "df#56", ",", "end", "vcbgf", "456", "<>(", "цы"};

int numberOfStrings(string[] firstArray)
{
    int result = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {    
        if (firstArray[i].Length <= 3)
        
            result ++;
    }
    return result;
}

string[] stringsArray(string[] secondArray, int dimension)
{
    string[] outputArray = new string[dimension];
    dimension = 0;
    for (int i = 0; i < secondArray.Length; i++)
    {
    if (secondArray[i].Length <= 3)
        {
        outputArray[dimension] = secondArray[i];
        dimension ++;
        }
    }
    return outputArray;
}

int number = numberOfStrings(initialArray);

string [] resultArray = stringsArray(initialArray, number);

Console.WriteLine($"Результат: [ {String.Join("; ", resultArray)} ]");