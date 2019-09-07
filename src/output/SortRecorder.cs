using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using assignment1.sorting;
using CsvHelper;

namespace assignment1.output
{
	public static class SortRecorder
	{
		public static void Run()
		{
			Console.WriteLine("ITCS 6114 Algorithms & Data Structures Assignment 1");
			Console.WriteLine("This will take a while! When this program finishes execution, a CSV will be produced in this directory displaying the outputs.");

			var csvRecords = new List<CSVRecord>();
			var inputSizes = new int[] { 10, 100, 1000, 2000, 4000, 5000, 10000, 20000, 30000, 40000, 50000 };
			var stopWatch = new Stopwatch();
			var rand = new Random();
			for (int i = 1; i <= 3; i++)
			{
				Console.WriteLine($"Starting Test Iteration {i}");
				foreach (var n in inputSizes)
				{
					var record = new CSVRecord { Iteration = i, NumElements = n };
					Console.WriteLine($"\tInput Size n = {n}");
					Console.WriteLine($"\tGenerating {n} random numbers");

					// Test Insertion Sort
					Console.WriteLine($"\t\tStarting Insertion Sort with n = {n}");
					Console.WriteLine("\t\t\tRunning...");
					stopWatch.Restart();

					Console.WriteLine("\t\t\tNot implemented.");

					stopWatch.Stop();
					record.InsertionSortTime = stopWatch.ElapsedMilliseconds;
					Console.WriteLine($"\t\t\tCompleted Insertion Sort with n = {n} with {stopWatch.ElapsedMilliseconds}ms");

					// Test Merge Sort
					Console.WriteLine($"\t\tStarting Merge Sort with n = {n}");
					Console.WriteLine("\t\t\tRunning...");
					stopWatch.Restart();

					Console.WriteLine("\t\t\tNot implemented.");

					stopWatch.Stop();
					record.MergeSortTime = stopWatch.ElapsedMilliseconds;
					Console.WriteLine($"\t\t\tCompleted Merge Sort with n = {n} with {stopWatch.ElapsedMilliseconds}ms");

					// Test Heap Sort
					Console.WriteLine($"\t\tStarting Heap Sort with n = {n}");
					Console.WriteLine("\t\t\tRunning...");
					stopWatch.Restart();

					Console.WriteLine("\t\t\tNot implemented.");

					stopWatch.Stop();
					record.HeapSortTime = stopWatch.ElapsedMilliseconds;
					Console.WriteLine($"\t\t\tCompleted Heap Sort with n = {n} with {stopWatch.ElapsedMilliseconds}ms");

					// Test Quick Sort (In-Place)
					Console.WriteLine($"\t\tStarting Quick Sort (In-Place) with n = {n}");
					Console.WriteLine("\t\t\tRunning...");
					stopWatch.Restart();

					Console.WriteLine("\t\t\tNot implemented.");

					stopWatch.Stop();
					record.QuickSortInPlaceTime = stopWatch.ElapsedMilliseconds;
					Console.WriteLine($"\t\t\tCompleted Quick Sort (In-Place) with n = {n} with {stopWatch.ElapsedMilliseconds}ms");

					// Test Quick Sort (Modified)
					Console.WriteLine($"\t\tStarting Quick Sort (Modified) with n = {n}");
					Console.WriteLine("\t\t\tRunning...");
					stopWatch.Restart();

					Console.WriteLine("\t\t\tNot implemented.");

					stopWatch.Stop();
					record.QuickSortModifiedTime = stopWatch.ElapsedMilliseconds;
					Console.WriteLine($"\t\t\tCompleted Quick Sort (Modified) with n = {n} with {stopWatch.ElapsedMilliseconds}ms");

					csvRecords.Add(record);
				}
				Console.WriteLine($"Concluded Test Iteration {i}");
			}

			// Write results to CSV
			using (var writer = new StreamWriter("sorting_results.csv"))
			using (var csv = new CsvWriter(writer))
			{
				csv.WriteRecords<CSVRecord>(csvRecords);
			}

			Console.WriteLine("All sorting tests concluded! Please check the project directory for the sorting_results.csv file.");
		}
	}
}
