using System;

namespace assignment1.sorting
{
	public static class IPQuickSort
	{
		public static void quickSort(int[] arr, int start, int end)
		{
			if (start < end)
			{
				int index = partition(arr, start, end);

				quickSort(arr, start, index - 1);
				quickSort(arr, index + 1, end);
			}
		}

		private static int partition(int[] arr, int start, int end)
		{
			Random rnd = new Random();

			int pivot = arr[start];
			int highest = end + 1;

			for (int i = end; i > start; i--)
			{
				if (arr[i] > pivot)
				{
					highest--;
					swap(arr, highest, i);
				}
			}

			swap(arr, highest - 1, start);

			return highest - 1;
		}

		private static void swap(int[] arr, int index1, int index2)
		{
			int temp = arr[index1];
			arr[index1] = arr[index2];
			arr[index2] = temp;
		}
	}
}
