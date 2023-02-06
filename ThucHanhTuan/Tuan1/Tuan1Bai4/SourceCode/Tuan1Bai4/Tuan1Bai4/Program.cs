using System;
using System.Text;

namespace Tuan1Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Chương trình giải phương trình bậc hai");
            Console.WriteLine("ax^2 + bx + c = 0");
            float a, b, c;

            Console.Write("Nhập hệ số a = ");
            a = float.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số b = ");
            b = float.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số c = ");
            c = float.Parse(Console.ReadLine());
            giaiPTBac2(a, b, c);

            Console.WriteLine("\nNhấn phím bất kì!");
            Console.ReadKey();
        }
        public static void giaiPTBac2(float ia, float ib, float ic)
        {
            if (ia == 0)
            {
                if (ib == 0)
                {
                    if (ic == 0)
                    {
                        Console.WriteLine("Phương trình vô số nghiệm!");
                    }
                    else
                    {
                        Console.WriteLine("Phương trình vô nghiệm!");
                    }
                }
                else
                {
                    Console.WriteLine("Phương trình có 1 nghiệm: x = {0}", (-ic / ib));
                }
                return;
            }
            else
            {

                float _delta = ib * ib - 4 * ia * ic;
                float ox1;
                float ox2;
                if (_delta > 0)
                {
                    ox1 = (float)((-ib + Math.Sqrt(_delta)) / (2 * ia));
                    ox2 = (float)((-ib - Math.Sqrt(_delta)) / (2 * ia));
                    Console.Write("Phương trình có 2 nghiệm: x1 = {0} và x2 = {1}", ox1, ox2);
                }
                else if (_delta == 0)
                {
                    ox1 = (-ib / (2 * ia));
                    Console.Write("Phương trình có nghiệm kép: x1 = x2 = {0}", ox1);
                }
                else
                {
                    Console.WriteLine("Phương trình vô nghiệm!");
                }
            }
        }

    }
}