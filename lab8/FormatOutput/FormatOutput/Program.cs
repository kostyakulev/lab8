using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 15;
                Console.WriteLine("{0}", i);

                int x = 23, y = 4, z = 5, j = 20, v = 40;
                Console.WriteLine("переменная x = {0}, переменная y = {1}, переменная z = {2}, переменная j = {3}, переменная v = {4}", x, y, z, j, v);

                int a = 38;
                //Результат  0038
                Console.WriteLine("a={0:d4}", a);

                double pi = 3.1415926;
                //Результат 3.14
                Console.WriteLine("pi={0:f2}", pi);

                int b = 255;
                //Результат FF.
                Console.WriteLine("b={0:X}", b);

                int c = 255;
                //Результат ff.
                Console.WriteLine("c={0:x}", c);

                double d = 1003.214;
                //Результат $1, 003.14 в английской версии Windows (или при выборе 
                //английского языка (США) на вкладке "Региональные параметры" инструмента 
                //"Язык и региональные параметры")
                //1 003,14 р. в русской.	
                Console.WriteLine("d={0:c}", d);
                
                double e = 213.1;
                //Результат 2.131000e+002	   
                Console.WriteLine("e={0:e}", e);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }
    }
}
