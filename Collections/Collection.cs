namespace SewTestExeLast.Collections;

class Program
{
    static void Collections(string[] args)
    {
        /*--------------------------------------------------------------------------------------------*/
        // Queue erstellen und testen
        Queue<int> queue = new Queue<int>();
        for (int i = 1; i <= 10; i++)
        {
            queue.Enqueue(i);
        }
        
        foreach (int item in queue)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nSuche in Queue: " + (queue.Contains(5) ? "gefunden" : "nicht gefunden"));
        int dequeueItem = queue.Dequeue();
        Console.WriteLine("Element aus der Queue entfernt: " + dequeueItem);
        Console.WriteLine("Queue nach Entfernen:");
        foreach (int item in queue)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");
/*--------------------------------------------------------------------------------------------*/
        // Stack erstellen und testen
        Stack<int> stack = new Stack<int>();
        for (int i = 1; i <= 10; i++)
        {
            stack.Push(i);
        }
        
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nSuche im Stack: " + (stack.Contains(5) ? "gefunden" : "nicht gefunden"));
        int popItem = stack.Pop();
        Console.WriteLine("Element aus dem Stack entfernt: " + popItem);
        Console.WriteLine("Stack nach Entfernen:");
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");
/*--------------------------------------------------------------------------------------------*/
        // List erstellen und testen
        List<int> list = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            list.Add(i);
        }

     
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\nSuche in der Liste: " + (list.Contains(5) ? "gefunden" : "nicht gefunden"));
        list.Remove(5);
        Console.WriteLine("Element aus der Liste entfernt.");
        Console.WriteLine("Liste nach Entfernen:");
        foreach (int item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");
/*--------------------------------------------------------------------------------------------*/
        // Dictionary erstellen und testen
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        for (int i = 1; i <= 5; i++)
        {
            dictionary.Add(i, "Value" + i);
        }
        
        foreach (var kvp in dictionary)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
        Console.WriteLine("Suche im Dictionary: " + (dictionary.ContainsKey(3) ? "gefunden" : "nicht gefunden"));
        dictionary.Remove(3);
        Console.WriteLine("Element aus dem Dictionary entfernt.");
        Console.WriteLine("Dictionary nach Entfernen:");
        
        foreach (var kvp in dictionary)
        {
            Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value);
        }
        Console.WriteLine("\n");
    }
}


