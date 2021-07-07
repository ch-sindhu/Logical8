using System;

namespace LowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            for(int i=0;i<=s.Length-1;i++)
            {
                int x = Convert.ToInt32(s[i]);
                x = x + 32;
                char ch = Convert.ToChar(x);
                Console.Write(ch);

            }
            Console.WriteLine();
        }
    }
}
