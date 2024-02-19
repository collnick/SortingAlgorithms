using System;

public class MergeSorting
{
    public static void Main(string[] args)
    {
        var values = InitValues(12);

        var sortedArray = MergeSort(values);
        
        Console.Write("sorted: ");
        PrintValues(sortedArray);
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
    
    private static int[] MergeSort(int[] src)
    {
        var count = src.Length / 2;
        
        if(src.Length == 1)
        {
            return new[] { src[0] };
        }
        
        var leftArr = MergeSort(SplitArray(src, 0 , count));
        var rightArr = MergeSort(SplitArray(src, count, src.Length - count));
        
        var result = Merge(leftArr, rightArr);
        
        return result;
    }
    
    private static int[] Merge(int[] a, int[] b)
    {
        var result = new int[a.Length + b.Length];
        int aIx = 0, bIx = 0 , rIx = 0;
        
        while (rIx != result.Length && aIx != a.Length && bIx != b.Length)
        {
            if(a[aIx] < b[bIx])
            {
                result[rIx] = a[aIx];
                aIx++; rIx++;
            }
            else if(b[bIx] < a[aIx])
            {
                result[rIx] = b[bIx];
                bIx++; rIx++;
            }
            else if(a[aIx] == b[bIx])
            {
                result[rIx] = a[aIx];
                aIx++; rIx++; bIx++;
            }
        }
        
        while(rIx != result.Length && aIx != a.Length && bIx == b.Length)
        {
            result[rIx]=a[aIx];
            rIx++;aIx++;
        }
        
        while(rIx != result.Length && aIx == a.Length && bIx != b.Length)
        {
            result[rIx]=b[bIx];
            rIx++;bIx++;
        }
        
        return result;
    }
    
    private static int[] SplitArray(int[] src, int startIndex, int count)
    {
        var result = new int[count];
        
        for(var i=0; i < count; i++)
        {
            result[i] = src[startIndex++];
        }
        
        return result;
    }
    
    private static void PrintValues(int[] src, bool withNewLine = false)
    {
        for(int i = 0; i < src.Length; i++)
        {
            if(withNewLine)
            {
                Console.WriteLine($"{src[i]} ");
            }
            else 
            {
                Console.Write($"{src[i]} ");
            }
        }
    }
}
