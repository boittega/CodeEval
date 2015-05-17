using System;
using System.Collections.Generic;
using System.IO;

namespace DataRecovery
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
                    string linhaNumeros = line.Substring(line.IndexOf(';') + 1);
                    string linhaWords = line.Substring(0,line.IndexOf(';'));
                    string[] numeros = linhaNumeros.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                    string[] words = linhaWords.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
                    int[] num = Array.ConvertAll(numeros, int.Parse);
                    int[] Ord = (int[])num.Clone();
                    Array.Sort(Ord);
                    int r = 1;
                    foreach (int i in Ord)
                    {
                        if (i != r) break;
                        r++;
                    }
                    Array.Resize(ref num, num.Length + 1);
                    num[num.Length - 1] = r;
                    Array.Sort(num, words);
                    foreach (string s in words)
                    {
                        Console.Write(s + ' ');
                    }
                    Console.WriteLine();
                }
        }
    }
}
