//Có Enum là các loại hình 
using System;
using System.Text;
namespace Tuan2Bai4 {


    internal class Program {

        static void Main(string[] args) {

            try {

                Console.OutputEncoding=Encoding.UTF8;

                // Hình tròn 
                Circle _Circle = new Circle(5);
                Display(_Circle);
                // Hình chữ nhật
                Rectangle _Rectangle = new Rectangle(4,5);
                Display(_Rectangle);
                // Hình thang
                Trapezoid _Trapezoid = new Trapezoid(6,5,12,5);
                Display(_Trapezoid);
                // Hình tam giác
                Triangle _Triangle = new Triangle(3,4,5);
                Display(_Triangle);


                Console.WriteLine("\nPress any key!");
                Console.ReadKey();

            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPress any key!");
                Console.ReadKey();
            }

        }

        static void Display(AShape iHinh) {
            foreach(var _item in iHinh.Display()) {

                Console.WriteLine(_item);
            }
        }
    }
}