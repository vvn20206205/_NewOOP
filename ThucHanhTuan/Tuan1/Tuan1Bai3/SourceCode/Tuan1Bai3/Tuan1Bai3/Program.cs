using System;
using System.Text;
namespace Tuan1Bai3 {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding=Encoding.UTF8;

            Console.WriteLine("Chương trình tính tổng từ a đến b:");

            Console.Write("Nhập giá trị a = ");
            int a = Int32.Parse(Console.ReadLine());

            Console.Write("Nhập giá trị b = ");
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\tKết quả: Tổng từ {0} đến {1} là: {2}",a,b,Sum(a,b));

            Console.WriteLine("Nhấn phím bất kì!");
            Console.ReadKey();
        }
        public static int Sum(int ibat_dau,int iket_thuc) {
            return (ibat_dau+iket_thuc)*(iket_thuc-ibat_dau+1)/2;
        }
    }
}