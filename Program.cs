using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int c = 1;
            int d = 2;
            int e = 3;
            int f = 5;
            int g = 8;
            int h = 13;
            int i = 21;
            int j = 34;
            int k = 55;
            int l = 89;
            int m = 144;
            int n = 233;
            int o = 377;
            int p = 610;
            int q = 987;
            int r = 1597;
            int s = 2584;
            int t = 4181;
            int u = 6765;
            int v = 10946;
            int w = 17711;
            int x = 28657;
            int y = 46368;
            int z = 75025;
            string word=Console.ReadLine();
            int sum = 0;
            
            foreach (char C in word)
            {
                if (C == 'a')
                {
                    sum= sum + 0;
                    

                }
                else if (C == 'b')
                {

                    sum= sum + 1;
                }
                else if(C=='c')
                {
                    sum= sum + 1;
                }
                else if(C=='d')
                {
                    sum = sum +2 ;
                }
                else if(C=='e')
                {
                    sum = sum + 3;
                }
                else if(C=='f')
                {
                    sum = sum + 5;
                }
                else if(C=='g')
                {
                    sum = sum + 8;
                }
                else if(C=='h')
                {
                    sum = sum + 13;
                }
                else if(C=='i')
                {
                    sum = sum + 21;
                }
                else if(C=='j')
                {
                    sum = sum + 34;
                }
                else if(C=='k')
                {
                    sum = sum + 55;
                }
                else if(C=='l')
                {
                    sum = sum + 89;
                }
                else if(C=='m')
                {
                    sum = sum + 144;
                }
                else if(C=='n')
                {
                    sum = sum + 233;
                }
                else if(C=='o')
                {
                    sum = sum + 377;
                }
                else if(C=='p')
                {
                    sum = sum + 610;
                }
                else if(C=='q')
                {
                    sum = sum + 987;
                }
                else if(C=='r')
                {
                    sum = sum + 1597;
                }
                else if(C=='s')
                {
                    sum = sum + 2584;
                }
                else if(C=='t')
                {
                    sum = sum + 4181;
                }
               else if(C=='u')
                {
                    sum = sum + 6765;
                }
                else if(C=='v')
                {
                    sum = sum + 10946;
                }
                else if(C=='w')
                {
                    sum = sum + 17711;
                }
                else if(C=='x')
                {
                    sum = sum + 28657;
                }
                else if(C=='y')
                {
                    sum = sum + 46368;
                }
                else if(C=='z')
                {
                    sum = sum + 75025;
                }
            }



            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
