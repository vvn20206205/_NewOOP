using System;
using System.Drawing;
using System.Text;
namespace Tuan4Bai4
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Viết một chương trình Test để kiểm tra tất cả các hành vi, thuộc tính (khởi tạo, phương thức, toán tử) của lớp này.\n");
            Console.Write("Phần tử đơn vị 0 là: ");
            ComplexNumbers test0 = new ComplexNumbers();
            Console.WriteLine(test0.ToString());

            Console.Write("Phần tử đơn vị 1 là: ");
            ComplexNumbers test1 = new ComplexNumbers(1, 0);
            Console.WriteLine(test1.ToString());

            Console.Write("Phần tử test2 = 1+2i là: ");
            ComplexNumbers test2 = new ComplexNumbers(1, 2);
            Console.WriteLine(test2.ToString());

            Console.WriteLine("Phép toán: cộng, trừ, nhân, chia\nlà: \n");
            Console.WriteLine(" test1 + test2 =  " + (test1 + test2).ToString());
            Console.WriteLine(" test1 - test2 = " + (test1 - test2).ToString());
            Console.WriteLine(" test1 * test2 = " + (test1 * test2).ToString());
            Console.WriteLine(" test1 / test2 = " + (test1 / test2).ToString());

            Console.WriteLine("Khai căn bậc hai của test1 là: "+test1.CanBacHai());
            Console.WriteLine("Bình phương của test2 là: "+test2.Square());

            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
        }
    }
}