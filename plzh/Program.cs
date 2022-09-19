using System;
namespace plzh
{
    class plzh
    {
        static void Main(string[] args)
        {
            int []a = new int[5];
            for (int i = 0; i < a.Length; i++) a[i] = 0;
            for(int i = 1; i <= 4; i++)
            {
                a[i] = 1;
                for (int j = 1; j <= 4; j++)
                {
                    if (a[j] == 0)
                    {
                        a[j] = 1;
                            for (int k = 1; k <= 4; k++)
                        {
                            if (a[k] == 0)
                            {
                                a[k] = 1;
                                Console.WriteLine(i + " " + j + " " + k);
                                a[k] = 0;
                            }
                        }
                            a[j] = 0;
                    }
                }
                a[i] = 0;
                Console.WriteLine();
            }
        }
    }
}
