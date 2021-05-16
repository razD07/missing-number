using System;

class GFG
{

    static int getMissingNo(int[] a, int n)
    {
        int total = (n + 1) * (n + 2) / 2;

        for (int i = 0; i < n; i++)
            total -= a[i];

        return total;
    }

    public static void Main()
    {
        int[] a = { 1, 2, 3, 5, 6, 7 };
        int miss = getMissingNo(a, 6);
        Console.Write(miss);
    }
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                