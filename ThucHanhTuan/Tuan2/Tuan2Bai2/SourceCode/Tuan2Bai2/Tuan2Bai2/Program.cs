using System;
using System.Text;
namespace Tuan2Bai2 {

    internal class Program {
        static void Main(string[] args) {

            try {

                Console.OutputEncoding=Encoding.UTF8;
                TestMethodOfEmployee();


                Console.WriteLine("\nPress any key!");
                Console.ReadKey();

            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPress any key!");
                Console.ReadKey();
            }

        }
        public static void TestMethodOfEmployee() {
            Console.WriteLine("Viết một chương trình Test để kiểm tra tất cả các hành vi của lớp Employee.");

            Console.WriteLine("*Check out the default constructor:");
            Employee _Employee1 = new Employee();
            _Employee1.FirstName="Vũ";
            _Employee1.LastName="Nghĩa";
            _Employee1.Address="Hà Nội";
            _Employee1.Sin=4000;
            _Employee1.Salary=5000;
            Console.WriteLine("*Check method Bonus (percentage=5): {0}",_Employee1.Bonus(5));
            Console.WriteLine("*Check override method ToString:");
            Console.WriteLine(_Employee1.ToString());

            Console.WriteLine("*Check parameters passed in the constructor:");
            Employee _Employee2 = new Employee("Vũ","Nghĩa","Hải Dương",4,5000);
            Console.WriteLine("*Check method Bonus (percentage=10): {0}",_Employee2.Bonus(10));
            Console.WriteLine("*Check override method ToString:");
            Console.WriteLine(_Employee2.ToString());
        }
    }
}