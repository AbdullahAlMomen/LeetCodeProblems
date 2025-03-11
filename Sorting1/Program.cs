// See https://aka.ms/new-console-template for more information
using Sorting1;

Console.WriteLine("Hello, World!");


//var data = BubbleSort.Sorting(new int[]{ 41, 9, 9, 48, 11, 2, 11, 12, 28, 10, 15, 4, 16, 48 });
var data = InsertionSort.Sorting(new int[]{ 4, 1, 3, 9, 7 });

foreach (var item in data) {  Console.WriteLine(item); }