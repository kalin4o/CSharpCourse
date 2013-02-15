using System;
using System.Collections.Generic;

class ProvadiaNumbers
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        List<ulong> result = new List<ulong>();
        while (number > 0)
        {
            result.Add(number % 256);
            number = number / 256;
        }
        result.Reverse();
        foreach (var item in result)
        {
            ulong check = item / 26;
            if (check > 0)
            {
                Console.Write((char)(96 + check));
            }
            Console.Write((char)(item + 65 - (26*check)));
        }
    }
}