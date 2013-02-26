using System;
using System.Text;

static class ExtensionMethod
{
    public static StringBuilder Substring(this StringBuilder builder, int index, int length) 
    {
        string str = builder.ToString();
        StringBuilder result = new StringBuilder(str.Substring(index, length));
        return result;
    }
    static void Main()
    {
        StringBuilder test = new StringBuilder("This_is_simple_test!");
        Console.WriteLine(test.Substring(4, 8));
    }
}