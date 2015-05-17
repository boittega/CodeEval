using System;
using System.IO;

namespace RemoveCharacteres
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] val2 = line.Split(new char[] {','});
                    val2[1] = val2[1].Trim();
                    char[] val = val2[1].ToCharArray();
                    for (int i = 0; i < val.Length; i++)
                    {
                        while (val2[0].IndexOf(val[i])>-1)
                        {
                            val2[0] = val2[0].Substring(0, val2[0].IndexOf(val[i])) + val2[0].Substring(val2[0].IndexOf(val[i]) + 1);
                        }
                    }
                    Console.WriteLine(val2[0]);
                }           
        }
    }
}

