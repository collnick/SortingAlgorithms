using System;

public class InsertionSorting
{
    public static void Main(string[] args)
    {
        var values = InitValues(12);
        
        var swappedCount = InsertionSort(ref values);
        
        Console.WriteLine($"Swapped count: {swappedCount};");
        Console.Write("sorted: ");
        for(int i = 0; i < values.Length; i++)
        {
            Console.Write($"{values[i]} ");
        }
    }
    
    private static int[] InitValues(int count)
    {
        var random = new System.Random();
        var arr = new int[count];
        Console.Write("unsorted: ");
        for(int i=0; i<count; i++)
        {
            arr[i]=random.Next(50);
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
        
        return arr;
    }
    
    private static int InsertionSort(ref int[] src)
    {
        var swappedIndex = 0;
        var maxIndex = src.Length;
        
        for(var i = 1; i < maxIndex; i++)
        {
            for(var j = i - 1; j >= 0; j--)
            {
                if(src[j] > src[j + 1])
                {
                    var temp = src[j];
                    src[j] = src[j + 1];
                    src[j + 1] = temp;
                    swappedIndex++;
                }
            }
        }
        
        return swappedIndex;
    }
}
