namespace Arrays;

internal class Arr
{
    private int[] arr = new int[100];

     public Arr(int Size)
     {
         arr = new int[Size];
     }

     public Arr()
     {
    
     }
    
      public void SetElements()
      {
          Console.WriteLine("Enter [q] for exit.");
          for (int index = 0; index < arr.Length; index++)
          {
              string input = Console.ReadLine();
              if (input.ToLower() == "q") break;
    
              if (Int32.TryParse(input, out int value))
              {
                  arr[index] = value; 
              }
              else
              {
                  Console.WriteLine("Try Again.");
                  index--;
              }
          }
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
