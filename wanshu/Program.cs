using System;
using System.Xml;

namespace wanshu
{
    class wanshu
    {
        static int wan(int n)
        {
            int sum = 0;
            for(int i = 1; i < n; i++)
            {
                if(n%i == 0)
                {
                    sum = i+sum;
                }
            }
            if (sum == n) return 1;
            return 0;
        }
        static void Main(string[] args)
        {
            for(int i = 1; i <= 1000; i++)
            {
                if (wan(i) == 1)
                {
                    Console.WriteLine(i + " ");
                }
            }  
        }
    }
}