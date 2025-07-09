class Stack
{
    private readonly List<int> stack = [];
    public int Count => stack.Count;
    public int Peek => stack[Count - 1];

    public void Push(int value)
    {
        stack.Add(value);
    }
    public int Pop()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        int last = stack[^1];
        stack.RemoveAt(Count - 1);
        return last;
    }

    public bool Contains(int x)
    {
        for (int i = 0; i < Count; i++)
        {
            if (x == stack[i])
            {
                return true;
            }
        }
        return false;
    }

    public IEnumerable<int> Items => stack;
}

class Program
{
    public static void Main(string[] args)
    {
        Stack stack = new();

        stack.Push(1);
        stack.Push(3);
        stack.Push(5);
        stack.Push(7);
        stack.Push(9);
        stack.Push(11);

        Console.WriteLine("Removed item: " + stack.Pop());
        Console.WriteLine("Item count: " + stack.Count);
        Console.WriteLine("Peek: " + stack.Peek);

        bool found = stack.Contains(7);
        if (found)
        {
            Console.WriteLine("Item found");
        }
        else
        {
            Console.WriteLine("Not found");
        }

        foreach (int i in stack.Items)
            {
                Console.WriteLine(i);
            }
    }
}