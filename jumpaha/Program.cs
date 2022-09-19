using System;
namespace jump
{
    class jump
    {
        static void Main(string[] args)
        {
            Double h = 100,len = 100;
            for(int i = 2;i<= 10; i++)
            {
                h = h / 2 * 1.0;
                len = len + h*2;
            }
            Console.WriteLine("经过："+len+"米，第十次反弹"+h/2 + "高");
        }
    }
}
