class Program
{
    public static void InsertItem(ref int[] arr, int value, int index)
    {
        if (index < 0 || index > arr.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        int[] newArray = new int[arr.Length + 1];

        for (int i = 0; i < index; i++)
        {
            newArray[i] = arr[i];
        }
        newArray[index] = value;

        for (int i = index; i < arr.Length; i++)
        {
            newArray[i + 1] = arr[i];
        }
        arr = newArray;
    }

    public static void DeleteItem(ref int[] arr, int index)
    {
        if (index < 0 || index > arr.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
        }
        int[] newArr = new int[arr.Length - 1];

        for (int i = 0; i < index; i++)
        {
            newArr[i] = arr[i];
        }
        for (int i = index + 1; i < arr.Length; i++)
        {
            newArr[i - 1] = arr[i];
        }
        arr = newArr;
    }

    static void Main(string[] args)
    {
        int[] arr = [1, 2, 3, 4, 5];
        InsertItem(ref arr, 0, 2);
        InsertItem(ref arr, 7, 3);
        InsertItem(ref arr, 9, 6);
        InsertItem(ref arr, 11, 1);

        DeleteItem(ref arr, 0);

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}