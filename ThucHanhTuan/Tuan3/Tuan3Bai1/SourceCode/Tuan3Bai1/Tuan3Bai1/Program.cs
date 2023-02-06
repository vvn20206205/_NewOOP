using System;
using System.Text;

namespace Tuan3Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("2. Viết một chương trình Test để kiểm tra tất cả các hành vi của  Circle class!\n");
            Circle test1 = new Circle(5.5);
            Console.WriteLine(test1.ToString());
            Circle test2 = new Circle(5.5, "green", 6.6);
            Console.WriteLine(test2.ToString());
            Console.WriteLine("3. Viết một chương trình test đọc radius, color và weight từ dòng lệnh và bắt lỗi");
            Console.WriteLine("\tKhi các tham số dòng lệnh không được cung cấp hoặc không đủ:");
            Circle test3 = new Circle( );
            test3.inputCircle();
            Console.WriteLine(test3.ToString());
            Console.WriteLine("\tKhi giá trị bán kính không phải là giá trị số:\n");
            Circle test4 = new Circle();
            test4.inputCircle();
            Console.WriteLine(test4.ToString());



            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
        }
    }
}