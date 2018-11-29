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

class Solution
{

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        int neg = 0;
        int poz = 0;
        int z = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
                poz++;
            if (arr[i] < 0)
                neg++;
            if (arr[i] == 0)
                z++;
        }
             
        Console.WriteLine("{0:F6}", poz / Convert.ToDouble(arr.Length));
        Console.WriteLine("{0:F6}", neg / Convert.ToDouble(arr.Length));
        Console.WriteLine("{0:F6}", z / Convert.ToDouble(arr.Length));
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
