using System;
using System.Collections.Generic;

namespace assignment1.sorting
{
	public static class IPQuickSort<T> where T : IComparable
	{
		private static List<T> sortedList;

		public static List<T> Sort(List<T> seq)
		{
			sortedList = new List<T>(seq);

			int[] index = partition(0, sortedList.Count - 1);

			Sort(0, index[1]);
			Sort(index[0], sortedList.Count - 1);

			return sortedList;
		}

		public static void Sort(int start, int end)
		{
			if (start < end)
			{
				int[] index = partition(start, end);

				Sort(start, index[1]);
				Sort(index[0], end);
			}
		}

		private static int[] partition(int start, int end)
		{
			Random rnd = new Random();

			var pivot = sortedList[rnd.Next(start, end+1)];
			int left = start;
			int right = end;

			while (left <= right)
			{
				while (sortedList[left].CompareTo(pivot) < 0)
				{
					left++;
				}

				while (sortedList[right].CompareTo(pivot) > 0)
				{
					right--;
				}

				if (left <= right)
				{
					swap(left, right);
					left++;
					right--;
				}
			}

			return new int[2] {left, right};
		}

		private static void swap(int index1, int index2)
		{
			var temp = sortedList[index1];
			sortedList[index1] = sortedList[index2];
			sortedList[index2] = temp;
		}
	}
}
