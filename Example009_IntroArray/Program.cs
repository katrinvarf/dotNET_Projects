int Max(int a, int b, int c)
{
    int result = a;
    if (b > result) result = b;
    if (c > result) result = c;
    return result;
}

int[] array = { 15, 21, 39, 12, 232, 33, 13, 23, 331 };

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);