using System;

public class BubbleSorting
{
    public static void Main(string[] args)
    {
        var values = InitValues(12);
        
        var swappedCount = BubbleSort(ref values);
        
        Console.WriteLine(values.Length);
        
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
    
    private static int BubbleSort(ref int[] src)
    {
        var swappedIndex = 0;
        var maxIndex = src.Length - 1;
        var swapped = false;
        do
        {
            swapped = false;
            for(int i=0; i < src.Length; i++)
            {
                if(i != maxIndex && src[i] > src[i + 1])
                {
                    Console.WriteLine($"i:{i}; src[i]: {src[i]}; src[i+1]: {src[i+1]}");
                    var tempValue = src[i + 1];
                    src[i + 1] = src[i];
                    src[i] = tempValue;
                    swapped = true;
                    swappedIndex++;
                }
            }
        }
        while(swapped);
        
        return swappedIndex;
    }
}
