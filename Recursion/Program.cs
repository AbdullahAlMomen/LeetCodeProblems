// See https://aka.ms/new-console-template for more information
using RecursionPractise;

//Console.WriteLine("Hello, World!");
//Console.WriteLine(Recursion.factorialNumber(5)); ;
string s="A man, a plan, a canal: Panama";
var result = string.Concat(s.ToLower().Where(char.IsLetterOrDigit));
Console.WriteLine(result);

frequencyCount(new int[]{ 2, 3, 2, 3, 5 });

List<int> frequencyCount(int[] arr)
{
    // code here

    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (map.ContainsKey(arr[i]))
        {
            map[arr[i]]++;
        }
        else
        {
            map[arr[i]] = 1;
        }
    }

    List<int> result = new List<int>();

    for (int i = 1; i <= arr.Length; i++)
    {
        if (map.ContainsKey(i))
        {
            result.Add(map[i]);
        }
        else result.Add(0);
    }
    return result;
}