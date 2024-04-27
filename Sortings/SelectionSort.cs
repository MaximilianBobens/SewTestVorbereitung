using System.Diagnostics;

namespace SewTestExeLast.Sortings;

public class SelectionSort
{
    public string SelectionSort(int[] array)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                    minIndex = j;
            }

            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }

        sw.Stop();
        return "SelectionSort: " + sw.ElapsedMilliseconds + "ms";
    }
}