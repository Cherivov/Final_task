string[] array_first = { "hel", "2", "world", "qwe", "hel", "2", "world", "qwe" };
int count = 0;
for (int i = 0; i < array_first.Length; i++)
{
    if (array_first[i].Length < 4)
    {
        count++;
    }
}

string[] array_two = new string[count];

int k = 0;
for (int j = 0; j < array_first.Length; j++)
{
    if (array_first[j].Length < 4)
    {
        array_two[k] = array_first[j];
        k++;
    }
}

for (int i = 0; i < array_two.Length; i++)
{
    Console.Write(array_two[i] + " ");
}