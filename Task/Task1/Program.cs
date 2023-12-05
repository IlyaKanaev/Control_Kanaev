string[] array = { "Hello", "2", "world", ":-)" };

int result_count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result_count++;
    }
}

string[] result = new string[result_count];

int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        result[j] = array[i];
        j++;
    }
}

for (int i = 0; i < result_count; i++)
{
    Console.WriteLine(result[i]);
}
