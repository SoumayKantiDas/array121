using System;

namespace array121
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int N;
            s = Console.ReadLine();
            N = Convert.ToInt32(s);
            int[] a = { 1, 2, 3 };
            for (int i=0; i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            foreach(int i in a)
            {
                Console.WriteLine( "{0}",i);
            }
        }
    }
}
