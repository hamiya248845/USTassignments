using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System;

class Solution
{
    static int pyramidSum(int array_length, List<int> arr)
    {
        // Write your code here
        while (array_length > 1)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < array_length - 1; i++)
            {
                int sum = arr[i] + arr[i + 1];
                temp.Add(sum);
            }
            arr = temp;
            array_length = temp.Count;
        }
        return arr[0];
    }

    static void Main(string[] args)
    {
        int array_length = Int32.Parse(Console.ReadLine().Trim());
        List<int> arr = new List<int>();
        for (int j = 0; j < array_length; j++)
        {
            arr.Add(Int32.Parse(Console.ReadLine().Trim()));
        }
        int result = pyramidSum(array_length, arr);
        Console.WriteLine(result);
    }
}

