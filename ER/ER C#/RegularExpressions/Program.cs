/*
 * Manipular Expressões Regulares com C#
 * lufer & Oscar
 * ISI
 * 
 * Validar emails   
 * * */
using System;
using System.Text;
using System.Text.RegularExpressions;


namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //\w = palavra
            //string reg = @"^([a-z]*)$";
            string reg = @"^((([\w]+\.[\w]+)+)|([\w]+))@(([\w]+\.)+)([A-Za-z]{1,3})$";

            if (Regex.IsMatch(text, reg))
            {
                Console.WriteLine("Email.");
            }
            else
            {
                Console.WriteLine("Not email.");
            }
        }
    }
}
