namespace Searching_algorithms
{
    class BinarySearch
    {
        public int BinarySearchIterative(int[] nums, int x)
        {
            int n = nums.Length;
            int start = 0;
            int end = n - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (nums[mid] == x)
                    return mid;
                else if
                    (nums[mid] < x) start = mid + 1;
                else
                    end = mid - 1;
            }
            return -1;
        }

        public int BinarySearchRecursive(int[] nums, int start, int end, int x)
        {
            if (end < start) return -1;
            int mid = (start + end) / 2;

            if (nums[mid] == x)
                return mid;
            else if (nums[mid] < x)
                return BinarySearchRecursive(nums, mid + 1, end, x);
            else
                return BinarySearchRecursive(nums, start, mid - 1, x);
        }
    }
}