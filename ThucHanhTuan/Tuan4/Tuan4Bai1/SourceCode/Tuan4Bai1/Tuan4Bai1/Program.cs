using System;
using System.Text;
namespace Tuan4Bai1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Constructor – không tham số:");
            CSinhVien test1 = new CSinhVien();
            Console.WriteLine(test1.ToString());
            Console.WriteLine("Constructor – Có 2 tham số: họ tên, tuổi");
            CSinhVien test2 = new CSinhVien("Sinh viên A", 22);
            Console.WriteLine(test2.ToString());

            Console.WriteLine("test3");
            CSinhVien test3 = new CSinhVien("Sinh viên A", 22, "Nam", 9.5, 9.5, 9.5);
            Console.WriteLine(test3.ToString());

            Console.WriteLine("test4");
            CSinhVien test4 = new CSinhVien("Sinh viên A", 22, "Nam", 8.5, 8.5, 8.5);
            Console.WriteLine(test4.ToString());

            Console.WriteLine("test5");
            CSinhVien test5 = new CSinhVien("Sinh viên A", 22, "Nam", 7.5, 7.5, 7.5);
            Console.WriteLine(test5.ToString());

            Console.WriteLine("test6");
            CSinhVien test6 = new CSinhVien("Sinh viên A", 22, "Nam", 6.5, 6.5, 6.5);
            Console.WriteLine(test6.ToString());

            Console.WriteLine("test7");
            CSinhVien test7 = new CSinhVien("Sinh viên A", 22, "Nam", 5.5, 5.5, 5.5);
            Console.WriteLine(test7.ToString());

            Console.WriteLine("Cộng 2 sinh viên: lấy thông tin của sv1; học bổng = tổng học bổng của 2 sv");
            CSinhVien test8 = new CSinhVien();
            test8 = test7 + test3;
            Console.Write("test7 + test3: ");
            Console.WriteLine(test8.ToString());

            Console.Write("So sánh 2 sinh viên test5 >= test6: ");
            Console.WriteLine(test5 >= test6);

            Console.Write("So sánh 2 sinh viên test6 <= test7: ");
            Console.WriteLine(test6 <= test7);
           


            Console.WriteLine("Ví dụ sử dụng cho 2 sinh viên 2007.");
            CSinhVien2007 test9 = new CSinhVien2007("Sinh viên A", 22, "Nam", 5.5, 5.5, 5.5,2);
            Console.WriteLine(test9.ToString());
            CSinhVien2007 test10 = new CSinhVien2007("Sinh viên B", 22, "Nam", 5.5, 5.5, 5.5,3);
            Console.WriteLine(test10.ToString());

            Console.WriteLine("test9 + test10: ");
            Console.WriteLine((test9 + test10).ToString());

            Console.WriteLine("Press any key!");
            Console.ReadKey();
        }
    }
}