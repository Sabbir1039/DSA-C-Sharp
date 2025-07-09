class Queue
{
    private List<int> Q = [];
    public int Count => Q.Count;

    public void Enqueue(int value)
    {
        Q.Add(value);
    }

    public int Dequeue()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Queue Empty");
        }
        int front = Q[0];
        Q.RemoveAt(0);
        return front;
    }

    public int Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Queue Empty");
        }
        return Q[0];
    }

    public bool Contains(int x)
    {
        foreach (int i in Q)
        {
            if (i == x)
            {
                return true;
            }
        }
        return false;
    }

    public ICollection<int> Items => Q;
}

class Program
{
    public static void Main(string[] args)
    {
        Queue Q = new();
        Q.Enqueue(9);
        Q.Enqueue(6);
        Q.Enqueue(3);
        Q.Enqueue(1);
        Q.Enqueue(-2);

        Console.WriteLine("Peek: " + Q.Peek());
        Console.WriteLine("Count: " + Q.Count);
        Console.WriteLine("Peek removed: " + Q.Dequeue());
        Console.WriteLine("Peek after removed: " + Q.Peek());
        Console.WriteLine("Queue contains -2: " + Q.Contains(-2));
    }
}