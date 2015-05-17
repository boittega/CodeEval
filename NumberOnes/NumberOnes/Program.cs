using System;
using System.IO;

namespace NumberOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = Convert.ToString(Convert.ToInt32(reader.ReadLine(), 10), 2);
                int bin = line.Length - line.Replace("1","").Length;
                Console.WriteLine(bin);
            }
        }
    }
}
