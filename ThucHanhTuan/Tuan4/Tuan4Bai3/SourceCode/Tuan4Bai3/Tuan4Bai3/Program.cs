using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace Tuan4Bai3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Viết một chương trình Test để kiểm tra tất cả các hành vi (phương thức, toán tử) của lớp này.\n");
            Console.Write("(Default constructor) test0 là: ");
            KhongGianNChieu test0 = new KhongGianNChieu();
            Console.WriteLine(test0.ToString());

            Console.Write("(Constructor int SoChieu) Gốc tọa độ test1 5 chiều là: ");
            KhongGianNChieu test1 = new KhongGianNChieu(5);
            Console.WriteLine(test1.ToString());

            List<double> input = new List<double>() { 1,2,3,4,5}; 
            KhongGianNChieu test2 = new KhongGianNChieu(input);
            Console.Write("(Constructor List tọa độ) Gốc tọa độ test2 là: ");
            Console.WriteLine(test2.ToString());


            Console.WriteLine("Điểm test2 có khoảng cách với gốc tọa độ là: " + test2.KhoangCachGocToaDo());
            Console.WriteLine("Điểm test2 có điểm đối xứng qua gốc tọa độ là: " + test2.DiemDoiXungToaDo());

            Console.WriteLine("\nCác toán tử:  cộng, trừ, nhân: ");
            Console.WriteLine(" test2 + test1 =  " + (test2 + test1).ToString());
            Console.WriteLine(" test2 - test1 = " + (test2 - test1).ToString());
            Console.WriteLine(" test2 * test1 = " + (test2 * test1).ToString());


            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
        }
    }
}