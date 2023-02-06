using System;
using System.Text;
namespace Tuan4Bai5
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Viết một chương trình Test để kiểm tra tất cả các hành vi (phương thức, toán tử) của lớp này.\n");
            Console.WriteLine("ĐA THỨC:");

            Console.Write("(Default constructor) Đa thức test0 (đa thức đơn vị 0) là: ");
            Polynomial test0 = new Polynomial();
            Console.WriteLine(test0.ToString());

            Console.Write("(Default constructor) Đa thức test1 (đa thức đơn vị 1) là: ");
            List<SoPhuc> input1 = new List<SoPhuc>() { new SoPhuc(1, 0), new SoPhuc(1, 0), new SoPhuc(1, 0) };
            Polynomial test1 = new Polynomial(input1);
            Console.WriteLine(test1.ToString());

            Console.Write("(Constructor int BacDaThuc) Đa thức test2 là: ");
            SoPhuc a = new SoPhuc(1, 2);
            Polynomial test2 = new Polynomial(5, a);
            Console.WriteLine(test2.ToString());

            Console.Write("(Constructor List hệ số) Đa thức test3 là: ");
            List<SoPhuc> input2 = new List<SoPhuc>() { new SoPhuc(1, 2), new SoPhuc(3, 4), new SoPhuc(5, 6) };
            Polynomial test3 = new Polynomial(input2);
            Console.WriteLine(test3.ToString());

            Console.WriteLine("\nCác toán tử:  cộng, trừ, nhân: ");
            Console.WriteLine(" test2 + test3 =  " + (test2 + test3).ToString());
            Console.WriteLine(" test2 - test3 = " + (test2 - test3).ToString());
            Console.WriteLine(" test2 * test3 = " + (test2 * test3).ToString());

           
            Console.Write("Giá trị đa thức test3 tại (3+0i) là: ");
            Console.WriteLine(test3.LayGiaTri(new SoPhuc(3, 0)));
  
            Console.Write("Bình phương đa thức test3 là: ");
            Console.WriteLine(test3.BinhPhuong().ToString());

   
            Console.Write("Đạo hàm đa thức test3 là: ");
            Console.WriteLine(test3.DaoHam().ToString());

            Console.Write("Nguyên hàm đa thức test3 là: ");
            Console.WriteLine(test3.NguyenHam().ToString());

            //Console.Write("Nghiệm đa thức test3 là: ");
            //Console.WriteLine(test3.TinhNghiem().ToString());


            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
        }
    }
}