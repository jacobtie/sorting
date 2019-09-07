using System;

namespace assignment1.sorting
{
	public static class IPQuickSort
	{
		public static void sort(int[] arr, int start, int end)
		{
			if (start < end)
			{
				int[] index = partition(arr, start, end);

				sort(arr, start, index[1]);
				sort(arr, index[0], end);
			}
		}

		private static int[] partition(int[] arr, int start, int end)
		{
			Random rnd = new Random();

			int pivot = arr[rnd.Next(start, end+1)];
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
	}
}
