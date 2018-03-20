using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1._6_strings
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            String a = "Mama25";
            String res = "";
            foreach (char c in a)
            {
                if (c >= '0' && c <= '9')
                    res += c;
            }

            foreach (char c in a)
            {
                if (c <= '0' || c >= '9')
                    res += c;
            }

            Console.WriteLine(res);

            a = "Helloxorw";
            int posX = a.IndexOf('x'), posW = a.IndexOf('w');

            if (posX == -1 || posW == -1)
            {
                Console.WriteLine("X or W not exists in inputed word");
            } else
            {
                if (posX < posW)
                    Console.WriteLine("symbol X befoe W");
                else
                    Console.WriteLine("symbol W befoe X");
            }

            a = "hello my dear friend";
            string[] arr = a.Split(' ');
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i][0] > arr[i + 1][0])
                        Swap(ref arr[i], ref arr[i + 1]);
                }
            }

            a = String.Join(" ", arr);
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}