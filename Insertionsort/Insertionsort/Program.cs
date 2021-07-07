using System;

namespace Insertionsort
{
    class Program
    {
        public static void Insertionsort(int[] ar)
        {
            for(int i=0;i<ar.Length-1;i++)
            {
                var item = ar[i];
                var currentIndex = i;

                while (currentIndex > 0 && ar[currentIndex - 1] > item)
                {
                    ar[currentIndex] = ar[currentIndex - 1];
                    currentIndex--;
                }

                ar[currentIndex] = item;
            }
                
        }
        public static void Main(string[] args)
        {
            int[] ar = new int[10] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("\nBefore sorting :");
            foreach (var item in ar)
                Console.Write(item + " ");
            Insertionsort(ar);
            Console.WriteLine("\nAfter sorting :");
            foreach(var item in ar)
            Console.Write(item + " ");
            
            Console.WriteLine("\n");
        }

       

        


    }
}
