using System;
using System.Collections.Specialized;

namespace HelloWorldOne
{
    class HelloWorld
    {
        static int gcdd(int n,int m)
        {
            int t;
            if (n < m)
            {
                
                t = n;
                n = m;
                m = t;
            }
            t = n % m;
            while (t!=0)
            {
                t = n % m;
                n = m;
                m = t;
            }
            return n;
        }


        static void Main(string[] args)
        {
            int n,m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("最大公约数是："+gcdd(n,m)+"最小公倍数是："+n*m/(gcdd(n,m)));
            
        }
    }
}