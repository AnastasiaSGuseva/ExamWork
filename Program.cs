string[] array = { "one", "two", "three", "four", "five", "six", "seven" };
Console.WriteLine("[" + string.Join(", ", array) + "]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
        count++;
}

string[] finalArray = new string[count];