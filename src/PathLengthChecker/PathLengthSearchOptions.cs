﻿namespace PathLengthChecker
{
	/// <summary>
	/// Options used when retrieving paths with their lengths.
	/// </summary>
	public class PathLengthSearchOptions : PathSearchOptions
	{
		/// <summary>
		/// The Minimum Length that a Path must have to be included in the search results.
		/// Specify a value of -1 to ignore the minimum path length.
		/// </summary>
		public int MinimumPathLength = -1;

		/// <summary>
		/// The Maximum Length that a Path must have to be included in the search results.
		/// Specify a value of -1 to ignore the maximum path length.
		/// </summary>
		public int MaximumPathLength = -1;

		/// <summary>
		/// Indicates the type of result that is output once the search completes.
		/// Valid values are MinLength, MaxLength, or All. Default is All
		/// </summary>
		public string OutputType = "All";
	}
}
