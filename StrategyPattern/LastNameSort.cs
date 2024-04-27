namespace SewTestExeLast.StrategyPattern;

public class LastNameSort : ICompareable<Person>
{
    public void Sort(List<Person> items)
    {
        items.Sort((p1, p2) => p1.LastName.CompareTo(p2.LastName));
    }
}

