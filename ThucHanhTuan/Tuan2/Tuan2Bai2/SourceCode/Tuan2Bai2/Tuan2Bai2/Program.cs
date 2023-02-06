using System;
using System.Text;
namespace Tuan2Bai2 {

    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding=Encoding.UTF8;
            Test();
            Console.WriteLine("Press any key!");
            Console.ReadKey();
        }
        public static void Test() {
            Console.WriteLine("Viết một chương trình Test để kiểm tra tất cả các hành vi của lớp Employee.");

            Console.WriteLine("*Check out the default constructor:");
            Employee _employee1 = new Employee();
            _employee1.FirstName="Vũ";
            _employee1.LastName="Nghĩa";
            _employee1.Address="Hà Nội";
            _employee1.Sin=4000;
            _employee1.Salary=5000;
            Console.WriteLine("*Check method Bonus (percentage=5): {0}",_employee1.Bonus(5));
            Console.WriteLine("*Check override method ToString:");
            Console.WriteLine(_employee1.ToString());

            Console.WriteLine("*Check parameters passed in the constructor:");
            Employee _employee2 = new Employee("Vũ","Nghĩa","Hải Dương",4,5000);
            Console.WriteLine("*Check method Bonus (percentage=10): {0}",_employee2.Bonus(10));
            Console.WriteLine("*Check override method ToString:");
            Console.WriteLine(_employee2.ToString());
        }
    }
}