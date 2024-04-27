namespace SewTestExeLast.Collections;

class Program
{
    static void Main(string[] args)
    {
      //PrintQueue();
      //PrintList();
      //PrintStack();
      //PrintDictionary();
        void PrintList()
        {
            List<int> list = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                list.Add(i);
            }

            if (list.Contains(3))
            {
                list.Remove(3);
            }
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        void PrintStack()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i <= 10; i++)
            {
                stack.Push(i);
            }
            
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            
            if (stack.Contains(4))
            {
                stack.Pop();
            }
            
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
          
        }

        void PrintQueue()
        {
            Queue<int> queue = new Queue<int>();
            for (int i = 0; i <= 10; i++)
            {
                queue.Enqueue(i);
             
            }
            
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            
            if (queue.Contains(3))
            {
                queue.Dequeue();
            }
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        void PrintDictionary()
        {
            Dictionary<string, int> books = new Dictionary<string, int>();
            Random r = new Random();
            
            for (int i = 1; i <= 10; i++)
            {
                int randomBookNumber = r.Next(100, 500);
                string bookTitle = string.Format("Test book {0}", i);
                books.Add(bookTitle, randomBookNumber);
            }

            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
            
        }

    }
}


