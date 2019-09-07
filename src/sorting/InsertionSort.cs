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

			// Perform the sort
			for (int i = 1; i < sortedList.Count(); i++)
			{
				var key = sortedList[i];
				var j = i - 1;

				while (j >= 0 && sortedList[j].CompareTo(key) > 0)
				{
					sortedList[j + 1] = sortedList[j];
					j = j - 1;
				}
				sortedList[j + 1] = key;
			}

			return sortedList;
		}
	}
}
