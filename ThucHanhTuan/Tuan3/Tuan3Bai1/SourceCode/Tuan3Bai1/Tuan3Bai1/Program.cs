using System;
using System.Drawing;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Tuan3Bai1 {
    internal class Program {
        static void Main(string[] args) {
            try {
                Console.OutputEncoding=Encoding.UTF8;
                Console.WriteLine("2. Viết một chương trình _Test để kiểm tra tất cả các hành vi của Circle class!\n");
                Circle _Test1 = new Circle(5.5);
                Console.WriteLine(_Test1.ToString());
                Circle _Test2 = new Circle(5.5,"green",6.6);
                Console.WriteLine(_Test2.ToString());
                Console.WriteLine("3. Viết một chương trình _Test đọc radius, color và weight từ dòng lệnh và bắt lỗi");
                Console.WriteLine("\tKhi các tham số dòng lệnh không được cung cấp hoặc không đủ:");
                Circle _Test3 = InputCircle();
                Console.WriteLine(_Test3.ToString());
                Console.WriteLine("\tKhi giá trị bán kính không phải là giá trị số:\n");
                Circle _Test4 = InputCircle();
                Console.WriteLine(_Test4.ToString());
                Console.WriteLine("\nPress any key!");
                Console.ReadKey();

            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPress any key!");
                Console.ReadKey();
            }

        }
        public static Circle InputCircle() {
            bool _checkValue = false;
            string _inputDataString = "";
            Console.Write("\t\tNhập thông tin hình tròn:\n");

            double _Radius;
            do {
                Console.Write("\t\tradius = ");
                _inputDataString=Console.ReadLine();
                _checkValue=double.TryParse(_inputDataString,out _Radius);
            } while(!_checkValue||_inputDataString=="");

            string _Color;
            do {
                Console.Write("\t\tcolor = ");
                _inputDataString=Console.ReadLine();
                _Color=_inputDataString;
            } while(_inputDataString=="");

            double _Weight;
            do {
                Console.Write("\t\tweight = ");
                _inputDataString=Console.ReadLine();
                _checkValue=double.TryParse(_inputDataString,out _Weight);
            } while(!_checkValue||_inputDataString=="");

            return new Circle(_Radius,_Color,_Weight);
        }
    }
}