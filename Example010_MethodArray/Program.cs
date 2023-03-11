int[] array = { 1, 92, 83, 45, 5, 56, 97, 83, 9 };
int n = array.Length;
int find = 83;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}