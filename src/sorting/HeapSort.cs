using System;
using System.Collections.Generic;
using assignment1.structures;

namespace assignment1.sorting
{
	public static class HeapSort
	{
		public static List<T> Sort<T>(List<T> sequence) where T : IComparable
		{
			var sortedList = new List<T>();

			var minHeap = new MinHeap<T>(sequence);

			while (!minHeap.isEmpty())
			{
				sortedList.Add(minHeap.RemoveMin());
			}

			return sortedList;
		}
	}
}
