using System;

namespace assignment1.sorting
{
	public static class MergeSort
	{
		public static void sort(int[] arr, int start, int end)
		{
			if (start < end)
			{
				int mid = (end + start) / 2;

				sort(arr, start, mid);
				sort(arr, mid+1, end);

				merge(arr, start, mid, end);
			}
		}

		private static void merge(int[] arr, int start, int mid, int end)
		{
			int sizeL = mid - start + 1;
			int sizeR = end - mid;
			int currL = 0;
			int currR = 0;
			int k = start;

			int[] left = new int[sizeL];
			int[] right = new int[sizeR];;

			for (int i = 0; i < sizeL; i++)
			{
				left[i] = arr[start + i];
			}

			for (int j = 0; j < sizeR; j++)
			{
				right[j] = arr[mid + 1 + j];
			}

			while (currL < sizeL && currR < sizeR) 
			{ 
				if (left[currL] <= right[currR]) 
				{ 
					arr[k] = left[currL];
					currL++;
				} 
				else
				{ 
					arr[k] = right[currR];
					currR++;
				} 

				k++; 
			} 

			while (currL < sizeL) 
			{ 
				arr[k] = left[currL]; 
				currL++; 
				k++; 
			} 
			
			while (currR < sizeR) 
			{ 
				arr[k] = right[currR]; 
				currR++; 
				k++; 
			} 
		}
	}
}
