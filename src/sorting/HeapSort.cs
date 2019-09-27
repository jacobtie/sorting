using System;
using System.Collections.Generic;
using assignment1.structures;

namespace assignment1.sorting
{
	public static class HeapSort
	{
		public static List<T> Sort<T>(List<T> sequence) where T : IComparable
		{
			// Create a sorted list
			var sortedList = new List<T>();

			// Create a new heap using the sequence to sort
			var minHeap = new MinHeap<T>(sequence);

			// Run for every element in the heap
			while (!minHeap.isEmpty())
			{
				// Remove the minimum from the heap to the next spot in the list
				sortedList.Add(minHeap.RemoveMin());
			}

			// Return the list
			return sortedList;
		}
	}
}
