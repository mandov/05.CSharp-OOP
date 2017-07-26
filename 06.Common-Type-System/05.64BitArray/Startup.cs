using System;
using BitArray;

public class Startup
{
    public static void Main()
    {
        BitArray64 bitArr = new BitArray64();
        BitArray64 secondBitArr = new BitArray64();
        for (ulong i = 0; i < 5; i++)
        {
            bitArr.Add(i);
            secondBitArr.Add(i);
        }
       
        Console.WriteLine(bitArr.Equals(secondBitArr));
        Console.WriteLine(secondBitArr.GetHashCode());
        Console.WriteLine(bitArr.GetHashCode());
    }
}