int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int m = 1;
for (int i = 0;i < n; i++)
{
    int input = int.Parse(Console.ReadLine());
    arr[i] = input;
    if (arr[i] != 0)
        m = m * arr[i];
}

for(int i = 0;i < n; i++)
{
    if (arr[i] != 0)
        arr[i] = m / arr[i];
}

foreach(int i in arr)
{
    Console.WriteLine(i);
}