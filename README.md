# C# MergeSort

MergeSort implementation in C#. It's significantly faster than Java, as expected:

    $ mcs Main.cs MergeSort.cs
    $ time mono Main.exe IntArray.txt 100000

    real	0m1.393s
    user	0m0.140s
    sys     0m0.003s
