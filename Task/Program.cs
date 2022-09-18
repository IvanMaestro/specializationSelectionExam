Console.Write("Input text: ");
string text = Console.ReadLine()
                .Replace(",","")
                .Replace(".","");

string[] data = text.Split(' ');

string[] CheckElemLenght(string[] arr)
{
    int count = 0;
    int newTextLenght = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if (arr[j].Length <= 3) newTextLenght++;
    }
    string[] newText = new string[newTextLenght];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newText[count] = arr[i];
            count++;
        }
        else continue;
    }
    return newText;
}

