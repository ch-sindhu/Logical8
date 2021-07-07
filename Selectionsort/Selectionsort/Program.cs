using System;

namespace Selectionsort
{
    class Program
    {
        public static void Selection_sort(int[] ar)
        {
            for(int i=0;i<ar.Length;i++)
            {
                var min = i;
                for(int j=i+1;j<ar.Length;j++)
                {
                    if(ar[min]>ar[i])
                    {
                        min = j;
                    }
                }
                if(min!=i)
                {
                    var lowervalue = ar[min];
                    ar[min] = ar[i];
                    ar[i] = lowervalue; 
                }
            }
        }
            
        static void Main(string[] args)
        {
            int[] ar = new int[] { 50 ,70 ,50, 80 ,89, 25, 78 ,58 ,83 ,73 };
            Console.WriteLine("Before sorting");
            foreach (var item in ar)
                Console.Write(item + " ");
            Console.WriteLine(" ");
            Console.WriteLine("After sorting");
            foreach (var item in ar)
                Console.Write(item + " ");
        }
    }
}
