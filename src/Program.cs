using System;
using assignment1.sorting;

namespace assignment1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("In-Place Quick Sort: ");
			
			int[] arr = {10, 4, 5, 2, 7, 9, 6, 1, 3, 8};

			IPQuickSort.sort(arr, 0, arr.Length-1);

			foreach (int num in arr)
			{
				Console.Write(num);
				Console.Write("  ");
			}

			Console.WriteLine();
		}
	}
}
