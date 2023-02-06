
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
            DemoThamTri();
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
    
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
           }

        public static void SwapThamTri( int a,  int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void DemoThamTri()
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("- Demo tham trị");
            Console.WriteLine("Giá trị của a trước khi Swap là: " + a);
            Console.WriteLine("Giá trị của b trước khi Swap là: " + b);
            SwapThamTri( a,  b);
            Console.WriteLine("Giá trị của a sau khi Swap là: " + a);
            Console.WriteLine("Giá trị của b sau khi Swap là: " + b);
        }

    }
}