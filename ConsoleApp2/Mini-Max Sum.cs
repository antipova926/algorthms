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

    // Complete the miniMaxSum function below.
    static void miniMaxSum(int[] arr)
    {
        long minSum = 0;
        long maxSum = 0;
        long Sum = 0;
        long maxArr = arr[0];
        long minArr = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            Sum += arr[i];
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maxArr)
            { maxArr = arr[i]; }
        }
        minSum = Sum - maxArr;
        System.Console.Write(minSum);
        System.Console.Write(' ');

        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] < minArr)
            { minArr = arr[j]; }
        }
        maxSum = Sum - minArr;
        System.Console.Write(maxSum);
    }

    static void Main(string[] args)
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        miniMaxSum(arr);
        System.Console.ReadKey();
    }
    
}
