using System;
using System.Text;
namespace Tuan1Bai3 {
    internal class Program {
        static void Main(string[] args) {
         
            try {
               
             Console.OutputEncoding=Encoding.UTF8;

            Console.WriteLine("Chương trình tính tổng từ begin đến end:");

            Console.Write("Nhập giá trị begin = ");
            int _inputBegin = Int32.Parse(Console.ReadLine());

            Console.Write("Nhập giá trị end = ");
            int _inputEnd = Int32.Parse(Console.ReadLine());

            Sum _Sum = new Sum(_inputBegin,_inputEnd);
            Console.WriteLine(_Sum.FindSum());

         
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
     
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
          }
    }
}