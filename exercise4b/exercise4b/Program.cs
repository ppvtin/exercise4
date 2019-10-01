using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise4b
{


    public class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[10];
            InputInt(Arr);
            Console.ReadLine();
        }
        public static void InputInt(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write("A[{0}] = ", i);
                string str = Console.ReadLine();
                Arr[i] = int.Parse(str);
            }
        }
    }
}
