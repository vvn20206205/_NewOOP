using System;
using System.Text;
namespace Tuan1Bai3 {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding=Encoding.UTF8;

            Console.WriteLine("Chương trình tính tổng từ begin đến end:");

            Console.Write("Nhập giá trị begin = ");
            int _begin = Int32.Parse(Console.ReadLine());

            Console.Write("Nhập giá trị end = ");
            int _end = Int32.Parse(Console.ReadLine());

            Sum _sum = new Sum(_begin,_end);
            Console.WriteLine(_sum.FindSum());

            Console.WriteLine("Nhấn phím bất kì!");
            Console.ReadKey();
        }
    }
}