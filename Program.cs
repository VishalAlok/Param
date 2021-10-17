using System;
namespace Examples
{

    class Geeks
    {
        public static int Add(params int[] ListNumbers)
        {
            int total = 0;
            foreach (int i in ListNumbers)
            {
                total += i;
            }
            return total;
        } 
        static void Main(string[] args)
        {
            int y = Add(12, 13, 10, 15, 56);
            Console.WriteLine(y);
        }
    }
}