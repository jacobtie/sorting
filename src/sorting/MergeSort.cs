using System;
using System.Collections.Generic;

namespace assignment1.sorting
{
	public static class MergeSort<T> where T : IComparable
	{
	    private static List<T> sortedList;

		public static List<T> Sort(List<T> seq)
		{
			int mid = (seq.Count - 1) / 2;
			sortedList = new List<T>(seq);

			Sort(0, mid);
			Sort(mid+1, seq.Count - 1);

			Merge(0, mid, seq.Count - 1);

			return sortedList;
		}

		public static void Sort(int start, int end)
		{
			if (start < end)
			{
				int mid = (end + start) / 2;

				Sort(start, mid);
				Sort(mid+1, end);

				Merge(start, mid, end);
			}
		}

		private static void Merge(int start, int mid, int end)
		{
			int sizeL = mid - start + 1;
			int sizeR = end - mid;
			int currL = 0;
			int currR = 0;
			int k = start;

			T[] left = new T[sizeL];
			T[] right = new T[sizeR];;

			for (int i = 0; i < sizeL; i++)
			{
				left[i] = sortedList[start + i];
			}

			for (int j = 0; j < sizeR; j++)
			{
				right[j] = sortedList[mid + 1 + j];
			}

			while (currL < sizeL && currR < sizeR) 
			{ 
				if (left[currL].CompareTo(right[currR]) <= 0) 
				{ 
					sortedList[k] = left[currL];
					currL++;
				} 
				else
				{ 
					sortedList[k] = right[currR];
					currR++;
				} 

				k++; 
			} 

			while (currL < sizeL) 
			{ 
				sortedList[k] = left[currL]; 
				currL++; 
				k++; 
			} 
			
			while (currR < sizeR) 
			{ 
				sortedList[k] = right[currR]; 
				currR++; 
				k++; 
			}
		}
	}
}
