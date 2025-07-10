// Binary Search Tree
// 1. Insert
// 2. Delete
// 3. Check is BST or Not
// 4. Tree Traversal (Level Order)
// 5. Tree Traversal (In, Pre, Post Order)
// 6. Height of a BST
// 7. Is BST balanced

class BSTNode
{
    public BSTNode? Left { get; set; }
    public BSTNode? Right { get; set; }
    public int Data { get; set; }

    public BSTNode(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

class Program
{
    public static BSTNode Insert(BSTNode? root, int value)
    {
        if (root == null)
        {
            BSTNode newNode = new BSTNode(value);
            root = newNode;
            return root;
        }
        if (value < root.Data)
        {
            root.Left = Insert(root.Left, value);
        }
        else
        {
            root.Right = Insert(root.Right, value);
        }
        return root;
    }

    public static BSTNode? Delete(BSTNode? root, int x)
    {
        if (root == null)
        {
            return root;
        }
        else if (x < root.Data)
        {
            root.Left = Delete(root.Left, x);
        }
        else if (x > root.Data)
        {
            root.Right = Delete(root.Right, x);
        }
        else
        {
            if (root.Data == x && root.Left == null && root.Right == null)
            {
                root = null;
            }
            else if (root.Data == x && root.Left == null && root.Right != null)
            {
                return root.Right;
            }
            else if (root.Data == x && root.Right == null && root.Left != null)
            {
                return root.Left;
            }
            else if (root.Data == x && root.Left != null && root.Right != null)
            {
                BSTNode? minRight = FindMin(root.Right);
                if (minRight != null)
                {
                    root.Data = minRight.Data;
                    root.Right = Delete(root.Right, minRight.Data);
                }
            }
        }
        return root;
    }

    public static BSTNode? FindMin(BSTNode? root)
    {
        if (root == null || root.Left == null)
        {
            return root;
        }
        else
        {
            return FindMin(root.Left);
        }
    }

    // Method for checking is BST or Not
    public static bool IsSubTreeLesser(BSTNode? root, int data)
    {
        if (root == null || root.Data < data)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

     public static bool IsSubTreeGreater(BSTNode? root, int data)
    {
        if (root == null || root.Data > data)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool IsBST(BSTNode? root)
    {
        if (root == null)
        {
            return true;
        }
        if (IsSubTreeGreater(root.Right, root.Data) &&
            IsSubTreeLesser(root.Left, root.Data) &&
            IsBST(root.Left) &&
            IsBST(root.Right))
        {
            return true;
        }
        return false;
    }

    // BST traversal
    public static void LevelOrderTraversal(BSTNode? root)
    {
        if (root == null)
            return;

        Queue<BSTNode> Q = new Queue<BSTNode>();
        Q.Enqueue(root);

        while (Q.Count > 0)
        {
            int levelSize = Q.Count;

            for (int i = 0; i < levelSize; i++)
            {
                BSTNode front = Q.Dequeue();
                Console.Write(front.Data + " ");

                if (front.Left != null)
                    Q.Enqueue(front.Left);
                if (front.Right != null)
                    Q.Enqueue(front.Right);
            }
            Console.WriteLine();
        }
        return;
    }

    public static void InOrderTraversal(BSTNode? root)
    {
        if (root == null)
            return;
        InOrderTraversal(root.Left);
        Console.Write(root.Data + " ");
        InOrderTraversal(root.Right);
    }

    public static void PreOrderTraversal(BSTNode? root)
    {
        if (root == null)
            return;
        Console.Write(root.Data + " ");
        PreOrderTraversal(root.Left);
        PreOrderTraversal(root.Right);
    }

    public static void PostOrderTraversal(BSTNode? root)
    {
        if (root == null)
            return;
        PostOrderTraversal(root.Left);
        PostOrderTraversal(root.Right);
        Console.Write(root.Data + " ");
    }

    // Is BST balanced or not
    public static bool IsBSTBalanced(BSTNode root)
    {
        if (root == null)
        {
            return true;
        }
        return Math.Abs(FindHeightOfBST(root.Left) - FindHeightOfBST(root.Right)) <= 1;
    }

    // Find height of BST
    public static int FindHeightOfBST(BSTNode? root)
    {
        if (root == null)
        {
            return -1;
        }
        int leftHeight = FindHeightOfBST(root.Left);
        int rightHeight = FindHeightOfBST(root.Right);
        return Math.Max(leftHeight, rightHeight) + 1;
    }

    public static void Main(string[] args)
    {
        BSTNode? root = null;

        root = Insert(root, 30);
        root = Insert(root, 40);
        root = Insert(root, 50);
        root = Insert(root, 35);
        root = Insert(root, 20);
        root = Insert(root, 10);
        root = Insert(root, 25);

        // LevelOrderTraversal(root);
        InOrderTraversal(root);
        Console.WriteLine();

        // PreOrderTravarsal(root);
        // Console.WriteLine();

        // PostOrderTravarsal(root);

        // Console.WriteLine("Is BST: " + IsBST(root));
        // Console.WriteLine("Height of BST: " + FindHeightOfBST(root));
        // Console.WriteLine("Is BST Balanced? " + IsBSTBalanced(root));
        root = Delete(root, 30);
        InOrderTraversal(root);

    }
}