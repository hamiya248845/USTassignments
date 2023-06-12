using System.Linq;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

class Solution
{
    static int scoreString(String str)
    {
        // Write your code here
        int score1 = 0, score2 = 0;
        string substring = "";
        string reverse = "";
        for (int i = 0; i < str.Length - 4; i++)
        {
            substring = str.Substring(i, 5);
            reverse = new string(substring.ToCharArray().Reverse().ToArray());
            if (substring.Equals(reverse))
            {
                score1 += 10;
            }
        }
        for (int j = 0; j < str.Length - 3; j++)
        {
            substring = str.Substring(j, 4);
            reverse = new string(substring.ToCharArray().Reverse().ToArray());
            if (substring.Equals(reverse))
            {
                score2 += 5;
            }
        }
        return score1 + score2;
    }

    static void Main(string[] args)
    {
        string str;
        str = Console.ReadLine();
        int result;
        result = scoreString(str);
        Console.Write(result + "\n");
    }
}