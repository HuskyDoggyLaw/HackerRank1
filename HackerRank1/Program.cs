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
using System.Text;
using System;
using System.Media;
using System.Runtime.InteropServices;
using System.CodeDom;

class Result
{
    public static void minimumBribes(List<int> q)
    {
        int minb = 0;

        foreach (int item in q)
        {
            int placeOfItem = q.IndexOf(item);

            if ((item - placeOfItem) > 4)
            {
                minb = -1; break;
            }

            minb = item - placeOfItem - 1;
        }

        if (minb == -1)
        {
            Console.WriteLine("Too chaotic");
        }
        else
        {
            Console.WriteLine(minb);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //int t = Convert.ToInt32(Console.ReadLine().Trim());

        //for (int tItr = 0; tItr < t; tItr++)
        //{
        //    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        //    int n = Convert.ToInt32(firstMultipleInput[0]);

        //    int m = Convert.ToInt32(firstMultipleInput[1]);

        Result.minimumBribes(new List<int>{ 2, 5, 1, 3, 4 });       
                

        //Console.WriteLine(result.ToString());
        Console.ReadLine();

        //    textWriter.WriteLine(result);
        //}

        //textWriter.Flush();
        //textWriter.Close();
    }
}
