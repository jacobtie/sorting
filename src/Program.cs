using System;
using assignment1.sorting;

namespace assignment1
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = {10, 6, 5, 4, 7, 3, 8, 9, 1, 2};

			MergeSort.mergeSort(arr, 0, arr.Length-1);

			foreach (int num in arr)
			{
				Console.WriteLine(num);
			}
		}
	}
}
