//               0   1    2   3   4   5   6  7   8    9
int[] array = { 11, 211, 31, 41, 18, 15, 61, 17, 18, 19 };

int n = array.Length;
int find = 18;
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