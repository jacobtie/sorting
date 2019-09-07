using System;

namespace assignment1.sorting
{
	public static class ModQuickSort
	{
		public static void quickSort(int[] arr, int start, int end)
		{
			if (start < end)
			{
				int[] index = partition(arr, start, end);

				quickSort(arr, start, index[1]);
				quickSort(arr, index[0], end);
			}
		}

		private static int[] partition(int[] arr, int start, int end)
		{
			Random rnd = new Random();

			int pivot = arr[findMedian(arr, start, end)];
			int left = start;
			int right = end;

			while (left <= right)
			{
				while (arr[left] < pivot)
				{
					left++;
				}

				while (arr[right] > pivot)
				{
					right--;
				}

				if (left <= right)
				{
					swap(arr, left, right);
					left++;
					right--;
				}
			}

			return new int[] {left, right};
		}

		private static void swap(int[] arr, int index1, int index2)
		{
			int temp = arr[index1];
			arr[index1] = arr[index2];
			arr[index2] = temp;
		}

		private static int findMedian(int[] arr, int start, int end)
		{
			int mid = (end + start) / 2;

			if ((arr[mid] < arr[start] && arr[start] < arr[end]) || 
				(arr[end] < arr[start] && arr[start] < arr[mid]))
			{
				return start;
			}
			else if ((arr[start] < arr[end] && arr[end] < arr[mid]) || 
				(arr[mid] < arr[end] && arr[end] < arr[start]))
			{
				return end;
			}
			else
			{
				return mid;
			}
		}
	}
}
