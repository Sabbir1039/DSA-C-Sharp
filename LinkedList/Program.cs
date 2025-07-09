// Linked List Data Structure
// 1. Add node at start
// 2. Add node at end
// 3. find length of the linked list
// 4. traverse the list (recursive & iterative)
// 5. remove node from start & end
// 6. remove node by key
// 7. remove node by position
// 8. reverse a linked list (recursive)
// 8. reverse a linked list (iterative)
class Node
{
    public Node? Next;
    public int Data;
    public Node(int value)
    {
        Next = null;
        Data = value;
    }
}

class Program
{
    public static Node AddStart(Node? head, int value)
    {
        var newNode = new Node(value);
        newNode.Next = head;
        head = newNode;
        return head;
    }

    public static Node AddEnd(Node? head, int value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            return head;
        }
        Node temp = head;

        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
        return head;
    }

    public static int LengthOfList(Node? head)
    {
        int len = 0;
        // Node? temp = head;
        while (head != null)
        {
            len += 1;
            head = head.Next;
        }
        return len;
    }

    public static void TraverseListIterative(Node? head)
    {
        Node? temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.Write("\n");
    }

    public static void TraverseListRecursive(Node? head)
    {
        if (head == null) return;
        Console.Write(head.Data + " -> ");
        TraverseListRecursive(head.Next);
    }

    public static Node? DeleteNodeStart(Node? head)
    {
        if (head == null) return head;
        head = head.Next;
        return head;
    }

    public static Node? DeleteNodeEnd(Node? head)
    {
        if (head == null || head.Next == null)
            return null;

        Node? temp = head;

        while (temp.Next?.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = null;
        return head;
    }

    public static Node? DeleteNodeByKey(Node? head, int x)
    {
        if (head == null) return null;
        if (head.Data == x)
        {
            head = head.Next;
            return head;
        }

        Node? current = head;

        while (current?.Next != null)
        {
            if (current.Next.Data == x)
            {
                current.Next = current.Next.Next;
                break;
            }
            current = current.Next;
        }
        return head;
    }

    public static Node? DeleteNodeByPosition(Node? head, int pos)
    {
        if (head == null || pos < 0)
            return head;
        if (pos == 0)
        {
            head = head.Next;
            return head;
        }

        Node? curr = head;

        for (int i = 0; i < pos - 1; i++)
        {
            if (curr?.Next == null)
                return head;
            curr = curr.Next;
        }
        curr.Next = curr.Next?.Next;
        return head;
    }

    public static Node? ReverseListIter(Node? head)
    {
        if (head == null || head.Next == null)
            return head;
        Node? curr = head;
        Node? next = head;
        Node? prev = null;

        while (curr != null)
        {
            next = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }

    public static Node? ReverseListRec(Node? head)
    {
        if (head == null || head.Next == null)
            return head;
        Node? last = ReverseListRec(head.Next);
        head.Next.Next = head;
        head.Next = null;
        return last;
    }

    static void Main(string[] args)
    {
        Node? head = null;
        head = AddEnd(head, 10);
        head = AddEnd(head, 20);
        head = AddEnd(head, 30);

        head = AddEnd(head, 40);
        head = AddEnd(head, 50);

        TraverseListIterative(head);
        Console.Write("\n");

        head = ReverseListRec(head);

        TraverseListIterative(head);
        Console.Write("\n");
    }
}