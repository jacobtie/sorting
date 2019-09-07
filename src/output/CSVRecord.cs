namespace assignment1.output
{
	public sealed class CSVRecord
	{
		public int Iteration { get; set; }
		public int NumElements { get; set; }
		public long InsertionSortTime { get; set; }
		public long MergeSortTime { get; set; }
		public long HeapSortTime { get; set; }
		public long QuickSortInPlaceTime { get; set; }
		public long QuickSortModifiedTime { get; set; }
	}
}
