/*
 * Manipular Expressões Regulares
 * 
 * Extrair os endreços de email de página HTML
 * lufer & Oscar
 * ISI
 * 
 * Adaptado de:
 * http://en.csharp-online.net/CSharp_Regular_Expression_Recipes%E2%80%94Returning_the_Entire_Line_in_Which_a_Match_Is_Found
 * http://www.codeproject.com/KB/cs/UsingRegularExpressions.aspx
 * */
using System;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

namespace RegExpFilesII
{
    class Program
    {
        static void Main(string[] args)
        {

            TestGetLine();
            Console.ReadKey();
        }

        public static void TestGetLine()
        {
            
            //Leitura simples de um ficheiro...e procura a expressão ":"
            ArrayList lines = GetLines(@"..\..\index.txt", ":", true);
            foreach (string s in lines)
                Console.WriteLine("Linha lida: " + s);

            //Analisa uma string
            Console.WriteLine();
            lines = GetLines("Line1\r\nLine2\r\nLine3\nLine4", "Line", false);
            foreach (string s in lines)
                Console.WriteLine("MatchedLine: " + s);
        }

        /// <summary>
        /// Aplica ER para encontrar pattern (expressão)
        /// </summary>
        /// <param name="source"></param>
        /// <param name="pattern"></param>
        /// <param name="isFileName"></param>
        /// <returns></returns>
        public static ArrayList GetLines(string source,string pattern, bool isFileName)
        {
            string text = source;
            ArrayList matchedLines = new ArrayList();

            //se é ficheiro
            if (isFileName)
            {
                FileStream FS = new FileStream(source, FileMode.Open,
                FileAccess.Read, FileShare.Read);
                StreamReader SR = new StreamReader(FS);
                while (text != null)
                {
                    text = SR.ReadLine();
                    if (text != null)
                    {
                        // Aplica o regex em cada linha da string
                        Regex RE = new Regex(pattern, RegexOptions.Multiline);
                        MatchCollection theMatches = RE.Matches(text);
                        if (theMatches.Count > 0)
                        {
                            // Armazena a linha se fez matching
                            matchedLines.Add(text);
                        }
                    }
                }
                SR.Close();
                FS.Close();
            }
            else // Se não for ficheiro
            {
                // Aplica a regex uma vez em toda a string
                Regex RE = new Regex(pattern, RegexOptions.Multiline);
                MatchCollection theMatches = RE.Matches(text);
                // Para cada linha que faz matching
                foreach (Match m in theMatches)
                {
                    int lineStartPos = GetBeginningOfLine(text, m.Index);
                    int lineEndPos = GetEndOfLine(text, (m.Index + m.Length - 1));
                    string line = text.Substring(lineStartPos,
                    lineEndPos - lineStartPos);
                    matchedLines.Add(line);
                }
            }
            return (matchedLines);
        }

        public static int GetBeginningOfLine(string text, int startPointOfMatch)
        {
            if (startPointOfMatch > 0)
            {
                --startPointOfMatch;
            }
            if (startPointOfMatch >= 0 && startPointOfMatch < text.Length)
            {
                // Move to the left until the first '\n char is found
                for (int index = startPointOfMatch; index >= 0; index--)
                {
                    if (text[index] == '\n')
                    {
                        return (index + 1);
                    }
                }
                return (0);
            }
            return (startPointOfMatch);
        }

        public static int GetEndOfLine(string text, int endPointOfMatch)
        {
            if (endPointOfMatch >= 0 && endPointOfMatch < text.Length)
            {
                // Move to the right until the first '\n char is found
                for (int index = endPointOfMatch; index < text.Length; index++)
                {
                    if (text[index] == '\n')
                    {
                        return (index);
                    }
                }
                return (text.Length);
            }
            return (endPointOfMatch);
        }
    }
}
