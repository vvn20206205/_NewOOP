using System;
using System.Text;
namespace Tuan4Bai5 {

    internal class Program {
        static void Main(string[] args) {

            try {

                Console.OutputEncoding=Encoding.UTF8;
                Console.WriteLine("Viết một chương trình _Test để kiểm tra tất cả các hành vi (phương thức, toán tử) của lớp này.\n");
                Console.WriteLine("ĐA THỨC:");

                Console.Write("(Default constructor) Đa thức _Test0 (đa thức đơn vị 0) là: ");
                Polynomial _Test0 = new Polynomial();
                Console.WriteLine(_Test0.ToString());

                Console.Write("(Default constructor) Đa thức _Test1 (đa thức đơn vị 1) là: ");
                List<Complex> input1 = new List<Complex>() { new Complex(1,0),new Complex(1,0),new Complex(1,0) };
                Polynomial _Test1 = new Polynomial(input1);
                Console.WriteLine(_Test1.ToString());

                Console.Write("(Constructor int BacDaThuc) Đa thức _Test2 là: ");
                Complex a = new Complex(1,2);
                Polynomial _Test2 = new Polynomial(5,a);
                Console.WriteLine(_Test2.ToString());

                Console.Write("(Constructor List hệ số) Đa thức _Test3 là: ");
                List<Complex> input2 = new List<Complex>() { new Complex(1,2),new Complex(3,4),new Complex(5,6) };
                Polynomial _Test3 = new Polynomial(input2);
                Console.WriteLine(_Test3.ToString());

                Console.WriteLine("\nCác toán tử:  cộng, trừ, nhân: ");
                Console.WriteLine(" _Test2 + _Test3 =  "+(_Test2+_Test3).ToString());
                Console.WriteLine(" _Test2 - _Test3 = "+(_Test2-_Test3).ToString());
                Console.WriteLine(" _Test2 * _Test3 = "+(_Test2*_Test3).ToString());


                Console.Write("Giá trị đa thức _Test3 tại (3+0i) là: ");
                Console.WriteLine(_Test3.GetValue(new Complex(3,0)));

                Console.Write("Bình phương đa thức _Test3 là: ");
                Console.WriteLine(_Test3.Square().ToString());


                Console.Write("Đạo hàm đa thức _Test3 là: ");
                Console.WriteLine(_Test3.Derivative().ToString());

                Console.Write("Nguyên hàm đa thức _Test3 là: ");
                Console.WriteLine(_Test3.Primitive().ToString()); 


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