using System;
using System.Text;
namespace Tuan4Bai1
{

    internal class Program
    {
        static void Main(string[] args)
        {
          
            try {
               
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Constructor – không tham số:");
            Student _Test1 = new Student();
            Console.WriteLine(_Test1.Display());
            Console.WriteLine("Constructor – Có 2 tham số: họ tên, tuổi");
            Student _Test2 = new Student("Sinh viên A", 22);
            Console.WriteLine(_Test2.Display());

            Console.WriteLine("_Test3");
            Student _Test3 = new Student("Sinh viên A", 22, "Nam", 9.5, 9.5, 9.5);
            Console.WriteLine(_Test3.Display());

            Console.WriteLine("_Test4");
            Student _Test4 = new Student("Sinh viên A", 22, "Nam", 8.5, 8.5, 8.5);
            Console.WriteLine(_Test4.Display());

            Console.WriteLine("_Test5");
            Student _Test5 = new Student("Sinh viên A", 22, "Nam", 7.5, 7.5, 7.5);
            Console.WriteLine(_Test5.Display());

            Console.WriteLine("_Test6");
            Student _Test6 = new Student("Sinh viên A", 22, "Nam", 6.5, 6.5, 6.5);
            Console.WriteLine(_Test6.Display());

            Console.WriteLine("_Test7");
            Student _Test7 = new Student("Sinh viên A", 22, "Nam", 5.5, 5.5, 5.5);
            Console.WriteLine(_Test7.Display());

            Console.WriteLine("Cộng 2 sinh viên: lấy thông tin của sv1; học bổng = tổng học bổng của 2 sv");
            Student _Test8 = new Student();
            _Test8 = _Test7 + _Test3;
            Console.Write("_Test7 + _Test3: ");
            Console.WriteLine(_Test8.Display());

            Console.Write("So sánh 2 sinh viên _Test5 >= _Test6: ");
            Console.WriteLine(_Test5 >= _Test6);

            Console.Write("So sánh 2 sinh viên _Test6 <= _Test7: ");
            Console.WriteLine(_Test6 <= _Test7);
           


            Console.WriteLine("Ví dụ sử dụng cho 2 sinh viên 2007.");
            Student2007 _Test9 = new Student2007("Sinh viên A", 22, "Nam", 5.5, 5.5, 5.5,2);
            Console.WriteLine(_Test9.Display());
            Student2007 _Test10 = new Student2007("Sinh viên B", 22, "Nam", 5.5, 5.5, 5.5,3);
            Console.WriteLine(_Test10.Display());

            Console.WriteLine("_Test9 + _Test10: ");
            Console.WriteLine((_Test9 + _Test10).Display());

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