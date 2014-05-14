using NUnit.Framework;
using System;

namespace mergesort
{
	[TestFixture ()]
	public class Test
	{
		private MergeSort<int> ms;

		[SetUp]
		public void SetUp()
		{
			ms = new MergeSort<int> ();
		}

		[Test ()]
		public void TestMerge ()
		{
			int[] left = new int[] { 1, 3, 5 };
			int[] right = new int[] { 2, 4, 6 };
			int[] expected = new int[] { 1, 2, 3, 4, 5, 6 };
			CollectionAssert.AreEqual( expected, ms.merge(left, right) );
		}

		[Test ()]
		public void TestMergeSort ()
		{
			int[] unsorted = new int[] { 1, 21, 4, 8, 7, 15, 3 };
			int[] expected = new int[] { 1, 3, 4, 7, 8, 15, 21 };
			CollectionAssert.AreEqual (expected, ms.mergesort (unsorted));
		}
	}
}

