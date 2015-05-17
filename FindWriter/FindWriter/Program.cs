using System;
using System.Collections.Generic;
using System.IO;

namespace FindWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                string linhaNumeros = line.Substring(line.IndexOf('|') + 1);
                string[] numeros = linhaNumeros.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in numeros)
                {
                    Console.Write(line.Substring(Convert.ToInt32(s) - 1, 1));
                }
                Console.WriteLine();
            }
        }
    }
}
