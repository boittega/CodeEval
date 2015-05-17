using System;
using System.IO;

namespace ReverseAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                int cont = 0;
                while (true)
                {
                    long one = Convert.ToInt64(line);
                    string rev = "";
                    for (int i = line.Length - 1; i >= 0; i--)
                    {
                        rev += line.Substring(i, 1);
                    }
                    long two = Convert.ToInt64(rev);
                    if (one == two) break;
                    line = Convert.ToString(one + two);
                    cont++;
                }
                Console.WriteLine(Convert.ToString(cont) + " " + line);
            }
        }
    }
}
