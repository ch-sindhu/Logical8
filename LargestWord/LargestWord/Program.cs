using System;

namespace LargestWord
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string text;
            string[] stringList;
            int ni = 0;
            int max=0;
            Console.Write("Enter a string :");
            text = Console.ReadLine();
            stringList = text.Split(' ');
            int  len = stringList.Length;

            //finding index of longest string
            for (int i = 0; i < len; i++)
            {
                if (stringList[i].Length > max)
                {
                    max = stringList[i].Length;
                    ni = i;
                }
            }

            //Output
            Console.WriteLine("Longest string:{0} \n Count of count of chrackter:{1}", stringList[ni], max);
            Console.ReadLine();

        }
    }
}
