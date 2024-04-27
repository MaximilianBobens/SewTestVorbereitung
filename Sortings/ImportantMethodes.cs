namespace SewTestExeLast.Sortings;

public class ImportantMethodes
{
    public const int Size = 10000;
    private static Random r = new Random();

    public int[] Create()
    {
        int[] arr = new int[Size];
        for (int i = 0; i < Size; i++)
        {
            arr[i] = r.Next(1,100);
        }
        return arr;
    }
}