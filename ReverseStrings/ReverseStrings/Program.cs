using System;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "there is a cat ";
            //Console.WriteLine(string.Join("  ", s.Split(' ').Reverse()));
            char[] ch = s.ToCharArray();
            string[] ar = new string[4];
            int x = 0;
            for(int i=0;i<=ch.Length-1;i++)
            {
                if(ch[i]!=' ')
                {
                    ar[x] = ar[x] + s[i];
                }
                else
                {
                    x++;
                }
            }
            for(int j=3;j>=0;j--)
            {
                Console.Write(ar[j] + " ");
            }


        }
    }
}
