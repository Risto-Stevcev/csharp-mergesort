using System;

namespace mergesort
{
	public static class Sub 
	{
		public static T[] SubArray<T>(this T[] data, int index, int length)
		{
			T[] result = new T[length];
			Array.Copy(data, index, result, 0, length);
			return result;
		}
	}

	public class MergeSort<T>
	{
		public MergeSort ()
		{
		}

		public T[] merge( T[] left, T[] right )
		{
			T[] list = new T[left.Length + right.Length];

			for (int i = 0, l = 0, r = 0; l < left.Length || r < right.Length; i++) {
				if (l < left.Length && r < right.Length) {
					if (System.Collections.Generic.Comparer<T>.Default.Compare(left [l], right [r]) < 0)
						list [i] = left [l++];
					else
						list [i] = right [r++];
				} 
				else if (l < left.Length)
					list [i] = left [l++];
				else if (r < right.Length)
					list [i] = right [r++];
			}
			return list;
		}

		public T[] mergesort( T[] list )
		{
			if (list.Length == 1)
				return list;

			int mid = list.Length / 2;
			T[] left = mergesort (list.SubArray (0, mid));
			T[] right = mergesort (list.SubArray (mid, list.Length - mid));

			return merge( left, right );
		}
	}
}