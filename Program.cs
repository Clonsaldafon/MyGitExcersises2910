using System;

namespace MyNewGitProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            foreach (char c in str)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}