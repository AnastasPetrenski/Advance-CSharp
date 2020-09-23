using System;
using System.Linq;
using System.Collections.Generic;

public class LegoBlocks
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		// Create the matrix.
		List<List<int>> matrix = new List<List<int>>();
		List<int> row = new List<int>();

		for (int j = 1; j <= 2 * n; j++)
		{
			row = Console
				.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList(); // Each row is a list.

			matrix.Add(row); // Add each row to a nested list named matrix.
		}

		// Check if two blocks fit together.
		bool fit = true;

		for (int i = 1; i < n; i++)
		{
			if ((matrix[i].Count + matrix[i + n].Count) != (matrix[i - 1].Count + matrix[i - 1 + n].Count))
			{
				fit = false;
				break;
			}
		}

		// Print results.
		if (fit)
		{
			for (int i = 0; i < n; i++)
			{
				matrix[i + n].Reverse();
				Console.WriteLine("[" + string.Join(", ", matrix[i]) + ", " + string.Join(", ", matrix[i + n].ToList()) + "]");
			}
		}
		else
		{
			int sum = 0;

			// Sum of cells calculation.
			for (int i = 0; i < (2 * n); i++)
			{
				sum += matrix[i].Count;
			}

			Console.WriteLine("The total number of cells is: {0}", sum);
		}
	}
}