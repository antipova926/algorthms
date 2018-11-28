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
    static void staircase(int n)
    {
        int i;
        int j;
        for (i = 0; i < n; i++)
        {for (j = 0; j < n; j++)
            {
                if (i + j >= n - 1)
                  {
                    System.Console.Write("#");
                  }
                else
                 {
                    System.Console.Write(" ");
                 }
            }
            System.Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        staircase(n);
        Console.ReadKey();
    }
}
