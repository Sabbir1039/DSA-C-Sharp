namespace Searching_algorithms
{
    class LinearSearch
{
     public int LinearSearchIterative(int[] arr, int x)
    {
        int n = arr.Length;

        for (int i =0; i < n; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }


    public int LinearSearchRecursive(int[] arr, int x, int index = 0)
    {
        if (index >= arr.Length) return -1;
        if (arr[index] == x) return index;

        return LinearSearchRecursive(arr, x, index + 1);
    }
}
}

