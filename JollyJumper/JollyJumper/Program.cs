using System;
using System.IO;

namespace JollyJumper
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] val = line.Split(default(char[]), StringSplitOptions.RemoveEmptyEntries);
                    int[] res = new int[val.Length-1];
                    if (val.Length == 1)
                    {
                        Console.WriteLine("Jolly");
                        continue;
                    }
                    for (int i = 0; i < val.Length - 1; i++)
                    {
                        res[i] = Math.Abs(Math.Abs(Convert.ToInt32(val[i])) - Math.Abs(Convert.ToInt32(val[i + 1])));
                    }
                    if (res.Length == 1)
                    {
                        Console.WriteLine("Jolly");
                        continue;
                    }
                    for (int i = 0; i < res.Length - 1; i++)
                    {
                        if (res[i] - 1 != res[i + 1])
                        {
                            Console.WriteLine("Not jolly");
                            break;
                        }
                        else if (i == res.Length - 2) Console.WriteLine("Jolly");
                    }
                }
        }
    }
}
