using System;
using assignment1.sorting;

namespace assignment1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = {10, 3, 6, 2, 5, 4, 9, 8, 7, 1};

			ModQuickSort.quickSort(arr, 0, arr.Length-1);

			foreach (int num in arr)
			{
				Console.WriteLine(num);
			}
		}
	}
}
