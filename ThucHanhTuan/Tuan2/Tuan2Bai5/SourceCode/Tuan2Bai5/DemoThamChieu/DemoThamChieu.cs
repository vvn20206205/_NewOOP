
using System;
using System.Text;
namespace Tuan2Bai5
{
    internal class Tuan2Bai5
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DemoThamChieu();
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
        }
       
        public static void SwapThamChieu(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
     
        public static void DemoThamChieu()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("- Demo tham chiếu");
            Console.WriteLine("Giá trị của a trước khi Swap là: " + a);
            Console.WriteLine("Giá trị của b trước khi Swap là: " + b);
            SwapThamChieu(ref a, ref b);
            Console.WriteLine("Giá trị của a sau khi Swap là: " + a);
            Console.WriteLine("Giá trị của b sau khi Swap là: " + b);
        }
       
    }
}