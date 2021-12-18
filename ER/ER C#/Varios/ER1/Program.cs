/*
*	<copyright file="ER1.cs" company="IPCA">
*		Copyright (c) 2021 All Rights Reserved
*	</copyright>
* 	<author>lufer</author>
*   <date>10/22/2021 9:18:46 PM</date>
*	<description>
*	Regular Expressions in C#
*	</description>
**/

using System;
using System.Text.RegularExpressions;

namespace ER1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo1
            // Input strings for Match
            // E-mail address.
            string[] str = {"parth@gmail.com",
                  "lufer@ipca.pt",
                            "@gmail.com"};

            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid E-mail address.", s,
                                    RegularExpression.isValidEmail(s) ? "is" : "is not");
            }
            #endregion

            Console.WriteLine();

            #region Exemplo2

            // Input strings to Match
            // mobile numbers
            string[] str1 = {"992561282_","8238783138", "02812451830"};

            foreach (string s in str1)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s,
                            RegularExpression.isValidMobileNumber(s) ? "is" : "is not");
            }

            #endregion

            Console.WriteLine();

            #region Exemplo3

            // This will return any
            // pattern b, ab, aab, ...
            Regex regex = new Regex(@"a*b");

            Match match = regex.Match("aaaabcd");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
            #endregion

            Console.WriteLine();

            #region Example4

            // this will return any pattern
            // like ab, aab, aaab, ....
            regex = new Regex(@"a+b");
            match = regex.Match("aaabcd");
            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }

            #endregion

            Console.WriteLine();

            #region Example5
            // This return any pattern like b, ab
            regex = new Regex(@"a?b");

            match = regex.Match("aaaabcd");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
            #endregion

            Console.WriteLine();

            #region Example6

            // This will return if shyam exist
            // at the beginning of the line
            regex = new Regex(@"^Passos");

            match = regex.Match("Passos Dias Aguiar Mota");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }

            #endregion

            Console.WriteLine();

            #region Example7

            // This return parth if it
            // exist at the end of the line
            regex = new Regex(@"Parth$");

            match = regex.Match("My name is Parth");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
            #endregion

            Console.WriteLine();

            #region Example8
            // This will return any word which
            // contains only one letter between
            // s and t
            regex = new Regex(@"s..t");

            match = regex.Match("This is my seat");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
            #endregion

            Console.WriteLine();

            #region Example9
            // This will the return
            // the one digit character
            regex = new Regex(@"\d");

            MatchCollection match1 = regex.Matches("Benfica 0 - Bayern 4");

            if (match1.Count>0)
            {
                foreach(Match m in match1)
                    Console.WriteLine("Matched Value: " + m.Value);
            }
            #endregion

            Console.WriteLine();

            #region Example10

            // This will return one character either
            // a or b or c which will come first
            regex = new Regex(@"[abc]");

            match = regex.Match("abcdef");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }

            #endregion

            Console.WriteLine();

            #region Example11

            // This will return any character
            // between x and z inclusive
            regex = new Regex(@"[x-z]");

            match = regex.Match("xmax");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }

            #endregion

            Console.WriteLine();

            #region Example12

            // This will return other x,
            // y and z character
            regex = new Regex(@"[^x-z]");

            match = regex.Match("xmax");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }

            #endregion

            Console.WriteLine();

            #region Example13

            // This will return pattern
            // will cd, cdcd, cdcdcd, ...
            regex = new Regex(@"(cd)+");

            match = regex.Match("cdcdde");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }

            #endregion

            Console.WriteLine();

            #region Example14

            // This will either d or e
            // which ever comes first
            regex = new Regex(@"d|e");

            match = regex.Match("edge");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
            #endregion


            Console.ReadKey();

        }
    }
}
