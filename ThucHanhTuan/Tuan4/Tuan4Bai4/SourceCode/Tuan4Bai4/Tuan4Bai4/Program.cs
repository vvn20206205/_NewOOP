using System;
using System.Drawing;
using System.Text;
namespace Tuan4Bai4 {

    internal class Program {
        static void Main(string[] args) {
            try {


                Console.OutputEncoding=Encoding.UTF8;
                Console.WriteLine("Viết một chương trình _Test để kiểm tra tất cả các hành vi, thuộc tính (khởi tạo, phương thức, toán tử) của lớp này.\n");
                Console.Write("Phần tử đơn vị 0 là: ");
                Complex _Test0 = new Complex();
                Console.WriteLine(_Test0.ToString());

                Console.Write("Phần tử đơn vị 1 là: ");
                Complex _Test1 = new Complex(1,0);
                Console.WriteLine(_Test1.ToString());

                Console.Write("Phần tử _Test2 = 1+2i là: ");
                Complex _Test2 = new Complex(1,2);
                Console.WriteLine(_Test2.ToString());

                Console.WriteLine("Phép toán: cộng, trừ, nhân, chia\nlà: \n");
                Console.WriteLine(" _Test1 + _Test2 =  "+(_Test1+_Test2).ToString());
                Console.WriteLine(" _Test1 - _Test2 = "+(_Test1-_Test2).ToString());
                Console.WriteLine(" _Test1 * _Test2 = "+(_Test1*_Test2).ToString());
                Console.WriteLine(" _Test1 / _Test2 = "+(_Test1/_Test2).ToString());

                Console.WriteLine("Khai căn bậc hai của _Test1 là: "+_Test1.Sqrt());
                Console.WriteLine("Bình phương của _Test2 là: "+_Test2.Exponential(2));

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