using System;
using System.IO;

namespace FileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo f = new FileInfo(args[0]);
            Console.WriteLine(f.Length);
        }
    }
}
