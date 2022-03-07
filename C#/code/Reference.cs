using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ref_Out
{
    class Program
    {
        static void Example1(ref int value) 
        {
            value = 1;
        }
        static void Example2(out int value) 
        {
            value = 2; 
        }


        static void Example3(int value) 
        {
            Console.WriteLine(value);
            value = 3;
            Console.WriteLine(value);
        }
        

        static void Main(string[] args)
        {
                int val1=10; 
                int val2=20; 

                Program.Example1(ref val1);
                Console.WriteLine(val1); 

                Program.Example2(out val2);
                Console.WriteLine(val2); 

                int a = 30;

                Example3(a);
                Console.WriteLine(a); 

                var v = 10;
                v = 20;
                Console.WriteLine(v);   

                var v2 = "Zeel";
                v2 = "Paterl ";
                Console.WriteLine(v2);

                Object O1 = 10;
                O1 = "Zeel";
                O1 = true;
                O1 = 20.20f;
                O1 = 'A';

            Console.ReadKey();
        }
    }
}
