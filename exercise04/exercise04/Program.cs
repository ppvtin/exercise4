using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                try
                {
                    Console.WriteLine("xin mời nhập n");
                    long n = long.Parse(Console.ReadLine());
                    Console.WriteLine("xin mời nhập x");
                    double x = double.Parse(Console.ReadLine());
                    Console.WriteLine("xin mời nhập y");
                    double y = double.Parse(Console.ReadLine());
                    UserInput(n, x, y);
                }
                catch (Exception)
                {
                    Console.WriteLine("bạn đã nhập dữ liệu sai: ");
                    Console.WriteLine("n thuộc kiểu long ");
                    Console.WriteLine("x thuộc kiểu double");
                    Console.WriteLine("y thuộc kiểu double");
                    Console.WriteLine("vui lòng nhập lại");
                    Console.WriteLine("----------------------------------------------------------------");
                }
            }
            Console.ReadLine();

        }
        public static void UserInput(long n, double x, double y)
        {
            Console.WriteLine(IsEven((int) n));
            Console.WriteLine(IsPrime((int)n));
            Console.WriteLine(Square((int) n));
            Console.WriteLine(Cube((int) n));
            Console.WriteLine(pow((int)x, (int)y));
            Console.WriteLine(Abs((int)n));
            Console.WriteLine(Ceil((float)x));
            Console.WriteLine(Floor((float)x));
            Console.WriteLine(Rand1());
            Console.WriteLine(Rand2());
            Console.WriteLine(Factorial(n));
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static bool IsOdd(int n)
        {
            if (n % 2 != 0)
                return true;
            else return false;
        }
        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            else return false;
        }

        public static bool IsPrime(int n)
        {
            if (n == 1) return true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public static int Square(int n)
        {

            return n * n;
        }

        public static int Cube(int n)
        {
            return n * n * n;
        }

        public static int pow(int x, int y)
        {
            Console.Write("pow của {0} và {1}: ", x, y);
            int kq = x;
            if (y < 0)
            {
                return 0;
            }
            if (y == 0)
            {
                return 1;
            }
            if (y == 1) return kq;
            for (int i = 2; i <= y; i++)
            {
                kq *= x;
            }
            return kq;
        }

        public static int Abs(int n)
        {
            Console.Write("Abs của {0}: ", n);
            if (n < 0)
            {
                return -n;
            }
            else return n;
        }
        //int: float x
        //Action: x > kq --> kp+=1
        //out: kp+=1 else int x
        public static int Ceil(float x)
        {
            Console.Write("Ceil của {0}: ", x);
            int kq = (int)x;
            if (x > kq) return kq += 1;
            else return kq;

        }

        public static int Floor(float x)
        {
            Console.Write("Floor của {0}: ", x);
            int kq = (int)x;
            if (x >= kq) return kq;
            else return kq - 1;
        }

        public static int Rand1()
        {
            int kq = 2;
            int kq2;
            for (int i = 2; i <= 31; i++)
            {
                kq *= 2;
            }
            Random rd = new Random();
            Console.Write("random từ 0 đến (2^31)-1: ");
            return kq2 = rd.Next(0, kq - 1);
        }

        public static float Rand2()
        {
            Random rd = new Random();
            float f = (float)rd.NextDouble();
            Console.Write("random từ giữa 0 đến 1: ");
            return f;

        }
        public static long Factorial(long n)
        {
            Console.Write("Factorial của {0}: ", n);
            long kq = 1;
            if (n == 0) return 1;
            else if (n < 0)
            {
                Console.Write("kq ra 0 => vô nghiệm ,");
                return 0;
            }
            else
            {
                for (long i = 1; i <= n; i++)
                {
                    kq *= i;
                }
                return kq;
            }
        }
       
    }

}