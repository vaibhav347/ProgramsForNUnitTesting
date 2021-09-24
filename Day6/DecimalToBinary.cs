using System;
namespace binary
{
class DecimalToBinary
{
    // Function that convert Decimal to binary
    static void toBinary(int n)
    {
        // Size of an integer is assumed to be 32 bits
        for (int i = 31; i >= 0; i--)
        {
            int k = n >> i;
            if ((k & 1) > 0)
                Console.Write("1");
            else
                Console.Write("0");
        }
    }

    // driver code
    static void Main(string[] args)
    {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
        DecimalToBinary.toBinary(n);
        
    }
}
}