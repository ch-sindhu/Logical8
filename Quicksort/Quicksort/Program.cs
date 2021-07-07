using System;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            Console.WriteLine("Before sorting");
            foreach (var item in ar)
                Console.Write(item + " ");
            Console.WriteLine(" ");
            Quick_sort(ar, 0, ar.Length - 1);
            Console.Write("After sorting");
            Console.WriteLine(" ");
            foreach (var item in ar)
                Console.Write(item + " ");
                

        }
        public static void Quick_sort(int[] ar,int left,int right)
        {
            if(left<right)
            {
                int pivot = partition(ar, left, right);
                if (pivot > 1)
                    Quick_sort(ar, left, pivot - 1);
                if(pivot+1 < right)
                {
                    Quick_sort(ar, pivot + 1, right);
                }

                
            }
        }
        public static int partition(int[] ar,int left,int right)
        {
            int pivot = ar[left];
            while(true)
            {
                while(ar[left]<pivot)
                {
                    left++;
                }
                while(ar[right]>pivot)
                {
                    right--;
                }
                if(left<right)
                {
                    if (ar[left] == ar[right])
                        return right;
                    int temp = ar[left];
                    ar[left] = ar[right];
                    ar[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
           
    }
}
