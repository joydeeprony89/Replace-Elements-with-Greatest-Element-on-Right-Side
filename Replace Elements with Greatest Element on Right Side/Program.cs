using System;

namespace Replace_Elements_with_Greatest_Element_on_Right_Side
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public int[] replaceElements(int[] arr)
        {
            int max = -1;
            for(int i = arr.Length -1; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = max;
                max = temp > max ? temp : max;
            }
            return arr;
        }
    }
}
