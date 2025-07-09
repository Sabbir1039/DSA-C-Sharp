using Searching_algorithms;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = [1, 3, 5, 6, 7, 8, 9];
        int[] nums = [10, 11, 12, 13, 14, 15, 16];

        // LinearSearch search = new();
        // Console.WriteLine(search.LinearSearchIterative(arr, 8));
        // Console.WriteLine(search.LinearSearchRecursive(arr, 9));

        BinarySearch search = new();
        int result = search.BinarySearchRecursive(nums, 0, nums.Length - 1, 13);
        if (result == -1)
            Console.WriteLine("Not found");
        else
            Console.WriteLine(result);
    }
}