using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment1.sorting
{
	public static class InsertionSort
	{
		public static List<T> Sort<T>(List<T> sequence) where T : IComparable
		{
			// Clone the list to a new list
			var sortedList = new List<T>(sequence);

			// Perform the sort, starting at the second element
			for (int i = 1; i < sortedList.Count(); i++)
			{
				// Keep a reference to the current element
				var key = sortedList[i];
				// Initialize j to the element behind the current element
				var j = i - 1;

				// Loop backwards through the list starting at j while the element is greater than the key
				while (j >= 0 && sortedList[j].CompareTo(key) > 0)
				{
					// Shift up the element to make room for either the key or a following element
					sortedList[j + 1] = sortedList[j];
					// Update the value of j
					j = j - 1;
				}
				// Insert the key into its proper position
				sortedList[j + 1] = key;
			}

			// Return the sorted list
			return sortedList;
		}
	}
}
