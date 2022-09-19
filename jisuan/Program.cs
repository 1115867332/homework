using System;
namespace jisuan
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int kg = 0, sz = 0, zm = 0,qt=0;
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ') kg++;
                else if (Char.IsLetter(s[i])) zm++;
                else if (Char.IsDigit(s[i])) sz++;
                else qt++;
            }
            Console.WriteLine("数字有：" + sz + "字母有：" + zm + "空格有：" + kg + "其他有：" + qt);
        }
    }
} 