// See https://aka.ms/new-console-template for more information
using BinarySearch;

Console.WriteLine("Hello, World!");
int[] arr = new int[] { 5, 7, 7, 8, 8, 10 };
//Console.WriteLine(FindNumber.isExist(arr, 8,0,arr.Length-1));


int m =  FindNumber.isExist(arr, 8, 0, arr.Length - 1);
int first = m;
int last = m;
while (true)
{
    
    
    int x = FindNumber.isExist(arr, 8, 0, first-1);
    if (x!=-1 && x < first)
        first = x;
 
    int z = FindNumber.isExist(arr, 8, last+1, arr.Length - 1);
    if (z!=-1 && z > last)
    {
        last = z;
    }
    if (x == -1 && z == -1)
        break;
    
}

Console.WriteLine(first + " " +last);


