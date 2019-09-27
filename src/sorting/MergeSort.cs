using System;
using System.Collections.Generic;

namespace assignment1.sorting
{
	public static class MergeSort<T> where T : IComparable
	{
		// Field to keep track of the sorted list of values
	    private static List<T> sortedList;

		// Method to start the sort by splitting and sorting the list before merging
		public static List<T> Sort(List<T> seq)
		{
			// Calculate the middle index
			int mid = (seq.Count - 1) / 2;

			// Copy the original list into the sorted list field
			sortedList = new List<T>(seq);

			// Sort the first half of the list
			Sort(0, mid);

			// Sort the second half of the list
			Sort(mid+1, seq.Count - 1);

			// Merge the two sorted halves
			Merge(0, mid, seq.Count - 1);

			// Return the completely sorted list
			return sortedList;
		}

		// Method to recursively split and sort the list before merging again
		private static void Sort(int start, int end)
		{
			// If the starting index is less than the ending index
			if (start < end)
			{
				// Calculate the middle of this portion of the list
				int mid = (end + start) / 2;

				// Sort the first half of the current portion
				Sort(start, mid);

				// Sort the second half of the current portion
				Sort(mid+1, end);

				// Merge the two sorted halves
				Merge(start, mid, end);
			}
		}

		// Method to perform the merging of the first and second halves of each portion
		private static void Merge(int start, int mid, int end)
		{
			// Create the size of the left and right arrays
			int sizeL = mid - start + 1;
			int sizeR = end - mid;

			// Initialize the starting values before the loops
			int currL = 0;
			int currR = 0;
			int k = start;

			// Create two empty arrays to represent each half
			T[] left = new T[sizeL];
			T[] right = new T[sizeR];;

			// Populate the left array with the left side of the list
			for (int i = 0; i < sizeL; i++)
			{
				left[i] = sortedList[start + i];
			}

			// Populate the right array with the right side of the list
			for (int j = 0; j < sizeR; j++)
			{
				right[j] = sortedList[mid + 1 + j];
			}

			// While the iterators do not exceed the size of their arrays
			while (currL < sizeL && currR < sizeR) 
			{ 
				// If the current value of left is less than or equal to the 
				// current value of right
				if (left[currL].CompareTo(right[currR]) <= 0) 
				{ 
					// Set the current value of the sorted list equal to 
					// the current value of the left array
					sortedList[k] = left[currL];

					// Increment the current index of the left array
					currL++;
				} 
				else
				{ 
					// Set the current value of the sorted list equal to 
					// the current value of the right array
					sortedList[k] = right[currR];

					// Increment the current index of the right array
					currR++;
				} 

				// Increment the current value of the sorted list
				k++; 
			} 

			// While there are still elements left in the left array
			while (currL < sizeL) 
			{ 
				// Set the current value of the sorted list equal to 
				// the current value of the left array
				sortedList[k] = left[currL]; 

				// Increment the current index of both the left array and the sorted list
				currL++; 
				k++; 
			} 
			
			// While therer are still elements left in the right array
			while (currR < sizeR) 
			{ 
				// Set the current value of the sorted list equal to 
				// the current value of the right array
				sortedList[k] = right[currR]; 

				// Increment the current index of both the right array and the sorted list
				currR++; 
				k++; 
			}
		}
	}
}
