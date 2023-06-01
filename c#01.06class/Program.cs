using System;
using System.Diagnostics.SymbolStore;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //byte t1 = 254;
            //byte t2 = 254;
            //int t3 = t1 + t2;

            //Console.WriteLine(t3);
            //Console.WriteLine(t1 + t2);

            sbyte sb1 = 125; 
            sbyte sb2 = 100;

            //int y = 812123123;
            //int yy = 812123123;

            //float ff = 65465f;
            //double dd = 6875463;
            //decimal ddd = 654456m;

            //string str = "dfgdghfhfhfh";
            //string str1 = "dfgdghfhfhfh";
            //Console.WriteLine(str + str1);

            //char c = 'a';
            //char cc = 'c';
            //Console.WriteLine('a' + 'c');

            //bool bb = true;
            //bool bbb = false;
            //Console.WriteLine(bb + bbb);

            //if (sb1 > sb2)
            //{
            //    Console.WriteLine("aaaaaaaaaa");
            //}
            //else
            //{
            //    Console.WriteLine("dddddddd");
            //}

            Console.Write("X= ");
            string ads = Console.ReadLine();
            Console.Write("Y= ");
            string ads1 = Console.ReadLine();
            Console.Write("Sum= "+ads + ads1);

        }
    }
}
