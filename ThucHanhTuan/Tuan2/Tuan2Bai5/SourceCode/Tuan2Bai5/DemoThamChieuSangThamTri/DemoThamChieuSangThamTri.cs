
using System;
using System.Text;
namespace Tuan2Bai5
{
    internal class Tuan2Bai5
    {
        static void Main(string[] args)
        {
            try {
               
          
            Console.OutputEncoding = Encoding.UTF8;
            DemoThamChieuSangThamTri();
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
      
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
         }

        public static void SwapThamChieu(ref int a, ref int b)
        {
            //tạo biến copy => tham trị
            int aCopy = a;
            int bCopy = b;
            int temp = aCopy;
            aCopy = bCopy;
            bCopy = temp;
        }

        public static void DemoThamChieuSangThamTri()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("- Demo tham chiếu sang tham trị");
            Console.WriteLine("Giá trị của a trước khi Swap là: " + a);
            Console.WriteLine("Giá trị của b trước khi Swap là: " + b);
            SwapThamChieu(ref a, ref b);
            Console.WriteLine("Giá trị của a sau khi Swap là: " + a);
            Console.WriteLine("Giá trị của b sau khi Swap là: " + b);
        }

    }
}