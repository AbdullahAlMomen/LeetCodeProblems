using System.ComponentModel;

int n = 1001;
int x = n;
int rem = 1;
int num = 0;
while (x != 0)
{
    Console.WriteLine(x);
    rem = x % 10;
    num = num * 10 + rem;
    x = x / 10;
}
Console.WriteLine(num);