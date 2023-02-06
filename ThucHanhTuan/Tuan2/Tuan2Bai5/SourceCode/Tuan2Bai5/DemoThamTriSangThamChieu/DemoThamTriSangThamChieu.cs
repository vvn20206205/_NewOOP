
using System;
using System.Text;
namespace Tuan2Bai5
{
    internal class Tuan2Bai5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DemoThamTriSangThamChieu();
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
        }

        public static int DemoThamTriSangThamChieu(int a)
        {

            //ref int temp = ref a;
            //ref int a  = ref int b;
            //b = temp;
            a += 1;
            return a;
        }

        public static void DemoThamTriSangThamChieu()
        {
            int a = 1;
            //int b = 2;
            Console.WriteLine("- Demo tham trị sang tham chiếu");
            Console.WriteLine("Giá trị của a ban đầu là: " + a);
            //Console.WriteLine("Giá trị của b trước khi Swap là: " + b);
            a = DemoThamTriSangThamChieu(a);
            Console.WriteLine("Giá trị của a sau là: " + a);
            //Console.WriteLine("Giá trị của b sau khi Swap là: " + b);
        }

    }
}