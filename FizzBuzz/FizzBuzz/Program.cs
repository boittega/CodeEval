using System;
using System.IO;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    int[] param = Array.ConvertAll(line.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries),int.Parse);
                    for (int i = 1; i <= param[2]; i++)
                    {
                        if (i % param[0] == 0) {
                            Console.Write("F");
                        }
                        if (i % param[1] == 0) {
                            Console.Write("B");
                        }
                        if ((i % param[0] != 0) && (i % param[1] != 0)) Console.Write(i);
                        Console.Write(" ");
                        
                    }
                    Console.WriteLine();
                }
        }
    }
}
