using System;
using System.IO;

namespace mergesort
{
	static class Run
	{
		static public void Main (string[] args)
		{
			if (args.Length == 2) {
				MergeSort<int> ms = new MergeSort<int> ();
				int length = Convert.ToInt32 (args [1]);
				int[] unsorted = new int[length];

				TextReader file = new StreamReader (args [0]);

				for (int i = 0; i < length; i++)
					unsorted [i] = Convert.ToInt32 (file.ReadLine ());

				Console.WriteLine (string.Join (",", ms.mergesort (unsorted)));
			} else {
				Console.WriteLine ("Usage: ./program [list file] [list length]");
			}
		}
	}
}

