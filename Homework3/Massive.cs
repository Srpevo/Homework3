namespace Arrays;

internal class Arr
{
    private int[] arr = new int[100];

    public void SetElements()
    {
        for (int Index = 0; Index < arr.Length; Index++)
        {
            arr[Index] = Int32.Parse(Console.ReadLine());
        }
        return;
    }

    public void FillArray()
    {
        for (int Index = 0; Index < arr.Length; Index++)
        {
            arr[Index] = Index;
        }
        return;
    }

    public void PrintElements()
    {
        foreach(var Index in arr)
        {
            Console.Write(Index + " ");
        }
    }

    public int[] GetArray()
    {
        if (arr == null)
        {
            Console.WriteLine("Array is NULL!");
            return null; 
        }

        return arr;
    }


}
