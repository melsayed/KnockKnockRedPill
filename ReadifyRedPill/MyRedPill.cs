﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using knockknock.readify.net;

namespace ReadifyRedPill
{
    public class MyRedPill : IRedPill
    {
        /// <summary>
        /// Get Token
        /// </summary>
        /// <returns>Token Guid</returns>
        public Guid WhatIsYourToken()
        {
            return new Guid("7c6340e5-44d3-4114-82c7-8786db460245");
        }

        public long Fib(long n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Fib(n - 1) + Fib(n - 2);
        }
       
        public long Fib2(long n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            if (n == 2)
                return 1;

            long first = 1;
            long second = 1;
            for (int i = 3; i <= n; i++)
            {
                long sum = first + second;
                first = second;
                second = sum;
            }
            return second;
        }

        /// <summary>
        /// find the Nth term in the Fibonacci sequence
        /// </summary>
        /// <param name="n">Fibonacci sequence</param>
        /// <returns>Return Fibonacci number in the Fibonacci sequence</returns>
        public long FibonacciNumber(long n)
        {
            if (Math.Abs(n) > 92)
                throw new ArgumentOutOfRangeException();

            if (n < 0)
            {
                long positiveN = Math.Abs(n);
                return (long)(Math.Pow(-1, positiveN + 1) * Fib2(positiveN));
            }
            return Fib2(n);

        }

        /// <summary>
        /// Get Type of triangle 
        /// </summary>
        /// <param name="a">A</param>
        /// <param name="b">B</param>
        /// <param name="c">C</param>
        /// <returns>Type of triangle</returns>
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                return TriangleType.Error;

            int[] values = new int[3] { a, b, c };
            if (values.Distinct().Count() == 1) //There is only one distinct value in the set, therefore all sides are of equal length
                return TriangleType.Equilateral;
            else if (values.Distinct().Count() == 2) //There are only two distinct values in the set, therefore two sides are equal and one is not
                return TriangleType.Isosceles;
            else if (values.Distinct().Count() == 3) // There are three distinct values in the set, therefore no sides are equal
                return TriangleType.Scalene;
            else
                return TriangleType.Error;
        }

        /// <summary>
        /// reverse words 
        /// </summary>
        /// <param name="s">Words needed to be reversed</param>
        /// <returns>reversed word</returns>
        public string ReverseWords(string s)
        {
            if(string.IsNullOrEmpty(s))
                throw new  ArgumentNullException();

            if (!string.IsNullOrEmpty(s))
            {
                string[] words = s.Split(' ');
                int len = words.Length;
                string[] reverseWords=new string[len];

                for (int i=0;i<len;i++)
                {
                    char[] chars = words[i].ToCharArray();
                    Array.Reverse(chars);
                    reverseWords[i] = new string(chars).ToString();
                }

                return string.Join(" ", reverseWords);
            }
            return "";
        }
    }
}
