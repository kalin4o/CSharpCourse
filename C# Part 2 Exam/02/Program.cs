using System;
using System.Collections.Generic;


class Midget
{
    static int Sum(int[] valley, int[] pattern, int index, int sum, List<int> indexes)
    {


        for (int i = 0; i < pattern.Length; i++)
        {
            index += pattern[i];
            if (index >= valley.Length || index < 0)
            {
                return sum;
            }
            else
            {
                if (indexes.Contains(index))
                {
                    return sum;
                }
                else
                {
                    indexes.Add(index);
                }
                sum += valley[index];
            }
        }

        return Sum(valley, pattern, index, sum, indexes);

    }



    static int[] StringToInt(string numbers)
    {
        string[] newString = numbers.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] result = new int[newString.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = int.Parse(newString[i]);
        }
        return result;

    }
    static void Main()
    {
        string theValley = Console.ReadLine(); //"1, 3, -6, 7, 4, 1, 12"
        int[] valley = StringToInt(theValley);
        int bestSum = int.MinValue;
        int numberOfPatterns = int.Parse(Console.ReadLine());
        string[] patterns = new string[numberOfPatterns];

        List<int> indexes = new List<int> { 0 };
        for (int i = 0; i < patterns.Length; i++)
        {

            patterns[i] = Console.ReadLine();
            int sum = Sum(valley, StringToInt(patterns[i]), 0, valley[0], indexes);
            indexes.Clear();
            if (sum > bestSum)
            {
                bestSum = sum;
            }
        }
        Console.WriteLine(bestSum);
    }
}