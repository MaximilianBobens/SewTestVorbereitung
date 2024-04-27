namespace SewTestExeLast.Sortings;

public class MergeSort
{
    private void MergeSortRecursive(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSortRecursive(array, left, mid);
            MergeSortRecursive(array, mid + 1, right);
            /*Merge(array, left, mid, right);*/
        }
    }
}