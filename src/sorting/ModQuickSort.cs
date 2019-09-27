using System;
using System.Collections.Generic;

namespace assignment1.sorting
{
	public static class ModQuickSort<T> where T : IComparable
	{
		// Field to keep track of the sorted list of values
		private static List<T> sortedList;

		// Method to start the sort by partioning the list and sort each side
		public static List<T> Sort(List<T> seq)
		{
			// Copy the original list into the sorted list
			sortedList = new List<T>(seq);

			// Partition the entire list into two sides
			int[] index = partition(0, sortedList.Count - 1);

			// Sort the first side of the list before the pivot
			Sort(0, index[1]);

			// Sort the second half of the list after the pivot
			Sort(index[0], sortedList.Count - 1);

			// Return the completely sorted list
			return sortedList;
		}

		// Method to recursively partition the current portion and sort each side
		public static void Sort(int start, int end)
		{
			// If start is less than end
			if (start < end)
			{
				// If the size of the current portion is less than or equal to 10
				if (end - start <= 10)
				{
					// Use insertion sort instead
					InsertionSort(start, end);
				}
				else
				{
					// Partition the current portion into two sides
					int[] index = partition(start, end);

					// Sort the first side of the current portion before the pivot
					Sort(start, index[1]);

					// Sort the second side of the current portion before the pivot
					Sort(index[0], end);
				}
			}
		}

		// Method to perform insertion sort on small portions of the sorted list
		private static void InsertionSort(int start, int end)
		{
			// For every value after the first value in the sorted list
			for (int i = start + 1; i <= end; i++)
			{
				// Set k equal to the current index
				int k = i;

				// While k is greater than start and 
				// the value before index k is greater 
				// than the current value of the sorted list
				while (k > start && sortedList[k - 1].CompareTo(sortedList[i]) > 0)
				{ 
					// Set the value at k equal to the value before k in the sorted list
					sortedList[k] = sortedList[k - 1];

					// Decrement k
					k--;
				}

				// Set the value at k equal to the current value of the sorted list
				sortedList[k] = sortedList[i];
			}
		}

		// Method to partition the current portion using a random pivot
		private static int[] partition(int start, int end)
		{
			// Create an object to generate random values
			Random rnd = new Random();

			// Create a variable to store the pivot 
			var pivot = sortedList[findMedian(start, end)];

			// Set the left and right indices in the sorted list
			int left = start;
			int right = end;

			// While the left index is less than or equal to the right index
			while (left <= right)
			{
				// While the left value in the sorted list is less than the pivot
				while (sortedList[left].CompareTo(pivot) < 0)
				{
					// Increment the left index
					left++;
				}

				// While the right value in the sorted list is less than the pivot
				while (sortedList[right].CompareTo(pivot) > 0)
				{
					// Decrement the right index
					right--;
				}

				// If the left index is less than or equal to the right index
				if (left <= right)
				{
					// Swap the values at the left and right indices
					swap(left, right);

					// Increment the left index
					left++;

					// Decrement the right index
					right--;
				}
			}

			// Return the indices of the left and right indices after partitioning
			return new int[2] { left, right };
		}

		// Method to swap the values at two indices in the sorted list
		private static void swap(int index1, int index2)
		{
			// Set a temp variable to keep the value at index1
			var temp = sortedList[index1];

			// Set the value at index1 equal to the value at index2
			sortedList[index1] = sortedList[index2];

			// Set the value at index2 equal to the value at index1
			sortedList[index2] = temp;
		}

		// Method to find the median value of the start, mid, and end values
		private static int findMedian(int start, int end)
		{
			// Calculate the mid index
			int mid = (end + start) / 2;

			// If the start value is the median
			if ((sortedList[mid].CompareTo(sortedList[start]) < 0 &&
				sortedList[start].CompareTo(sortedList[end]) < 0) ||
				(sortedList[end].CompareTo(sortedList[start]) < 0 &&
				sortedList[start].CompareTo(sortedList[mid]) < 0))
			{
				// Return the index of the start value
				return start;
			}
			// Else if the end value is the median
			else if ((sortedList[start].CompareTo(sortedList[end]) < 0 &&
					sortedList[end].CompareTo(sortedList[mid]) < 0) ||
					(sortedList[mid].CompareTo(sortedList[end]) < 0 &&
					sortedList[end].CompareTo(sortedList[start]) < 0))
			{
				// Return the index of the end value
				return end;
			}
			else
			{
				// Return the index of the mid value
				return mid;
			}
		}
	}
}
