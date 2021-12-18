/*
 * Manipular Expressões Regulares
 * 
 * Extrair os endreços de email de página HTML
 * lufer & Oscar Ribeiro
 * ISI
 * 
 * Adaptado de:
 * http://www.informit.com/articles/article.aspx?p=27313&seqNum=5
 * */

using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExpFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = File.OpenRead(@"..\..\..\index.txt");
            byte[] text = new byte[stream.Length];
            stream.Read(text, 0, (int)stream.Length);

            ASCIIEncoding encoding = new ASCIIEncoding();

            string content = encoding.GetString(text);
            
            /*ER lida do teclado
            Console.Write("ER=");
            string er = Console.ReadLine();
            try
            {
                Regex regexObj = new Regex(er);
            }
            catch (ArgumentException ex)
            {
                // erro sintáctico
            }
             
              MatchCollection matches = Regex.Matches(content,er);             
             */
            MatchCollection matches = Regex.Matches(content, @"mailto:\w+@(\w.)*ipca.pt");

            //Encontrar expressão no ínício
            //MatchCollection matches = Regex.Matches(content,@"^mailto:\w+@(\w.)*ipca.pt");
            
            //Encontrar frase só com a expressão em várias linhas
            //MatchCollection matches = Regex.Matches(content, @"^mailto:\w+@(\w.)*ipca.pt$", RegexOptions.Multiline);

            foreach (Match match in matches)
            {
                Console.WriteLine("Match: " + match.Value);
            }

            
            //Mostrar o valor matched
            string s = "Olá mundo como está o ano de 2021?";
            string er1="(.*?)([0-9]+)\\?$";
            Regex r = new Regex(er1);
            
            if (r.IsMatch(s)){
                Console.WriteLine("Match Value: " + r.Match(s).Value);
                Console.WriteLine("Match Group Value: " + r.Match(s).Groups[2].Value);
            };

            //Memorização ou Agrupamento
            s = "http//www.ipca.pt";
            string resultString = Regex.Match(s,"http://([a-z0-9.-]+)").Groups[1].Value;
            Console.WriteLine("Match http: " + resultString);

            //Split de string

            s = "ola;ole;oli;olo;olu";
            r = new Regex(";");
            string[] splits = r.Split(s);

            Console.ReadKey();

        }
    }
}
