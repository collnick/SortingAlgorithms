using System;

public class SelectionSorting
{
    public static void Main(string[] args)
    {
        var values = InitValues(12);
        
        var swappedCount = SelectionSort(ref values);
        
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
            arr[i]=random.Next(100);
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
        
        return arr;
    }
    
    private static int SelectionSort(ref int[] src)
    {
        var swappedIndex = 0;
        var maxIndex = src.Length;
        
        for(int i=0; i < maxIndex; i++)
        {
            var smallValue = src[i];
            var smallValueIndex = i;
            for(int j=i+1; j < maxIndex; j++)
            {
                if(j != maxIndex && src[j] < smallValue)
                {
                    smallValue = src[j];
                    smallValueIndex= j;
                    swappedIndex++;
                }
            }
            src[smallValueIndex] = src[i];
            src[i] = smallValue;
        }
        
        return swappedIndex;
    }
}
