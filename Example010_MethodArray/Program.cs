int[] array = { 11, 22, 31, 4, 15, 16, 4, 81 };

int n = array.Length;
int find = 4;

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