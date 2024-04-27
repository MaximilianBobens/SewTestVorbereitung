using System.Diagnostics;
namespace SewTestExeLast.Sortings;

public class InsertionSort
{
    public string InsertionSort(int[] array)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();

        int n = array.Length;
        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }

        sw.Stop();
        return "InsertionSort: " + sw.ElapsedMilliseconds + "ms";
    }
}