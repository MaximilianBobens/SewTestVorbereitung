namespace SewTestExeLast.StrategyPattern;

public class PersonCollection : ICompareable<Person>
{
    private List<Person> people = new List<Person>();
    private ICompareable<Person> sortStrategy;

    public void SetSortStrategy(ICompareable<Person> strategy)
    {
        sortStrategy = strategy;
    }
    
    public void AddPerson(Person person)
    {
        people.Add(person);
    }

    public void Sort(List<Person> persons)
    {
        if (sortStrategy != null)
        {
            sortStrategy.Sort(people);
        }
        else
        {
            Console.WriteLine("Sort strategy not set.");
        }
    }

    public void Display()
    {
        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Age: {person.Age}");
        }
    }

    public string ToString(Person person)
    {
        return $"Name: {person.FirstName} {person.LastName}, Age: {person.Age}";
    }
}
