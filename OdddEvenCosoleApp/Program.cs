﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdddEvenCosoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            PrintNumbers("Numbers ", numbers);
            PrintNumbers("Numbers Even ",numbers.Where(x=>IsEven(x)));
            PrintNumbers("Numbers Odd ", numbers.Where(x => IsOdd(x)));

            Console.ReadKey();

        }
        static void PrintNumbers (string title , IEnumerable<int> numbers)
        {
            Console.WriteLine();
            Console.Write($" {title} : [ ");
            foreach (var n in numbers) 
            {
                Console.Write($"{n} ");
            }
            Console.Write($"]");
            Console.WriteLine();
        }
        static bool IsEven (int number) => number % 2 == 0;
        static bool IsOdd(int number) => !IsEven(number);

        
            
        


    }
}
