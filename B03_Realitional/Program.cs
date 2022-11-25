using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B03_Realitional
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("x를 입력하세요 : ");
            x = int.Parse(Console.ReadLine());

            Console.Write("y를 입력하세요 : ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} > {1} = {2}", x, y, x > y);
            Console.WriteLine("{0} >= {1} = {2}", x, y, x >= y);
            Console.WriteLine("{0} < {1} = {2}", x, y, x < y);
            Console.WriteLine("{0} <= {1} = {2}", x, y, x <= y);
            Console.WriteLine("{0} == {1} = {2}", x, y, x == y);
            Console.WriteLine("{0} != {1} = {2}", x, y, x != y);
        }
    }
}
