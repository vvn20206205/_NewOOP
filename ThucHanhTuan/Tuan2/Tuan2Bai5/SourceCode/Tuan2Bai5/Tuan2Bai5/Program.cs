//Xây dựng chương trình mô phỏng được:
//Kiểu dữ liệu tham chiếu, tham trị
//Chuyển đổi kiểu dữ liệu tham chiếu sang tham trị và ngược lại. 
//Trường hợp truyền tham số tham trị mà lại thay đổi giá trị
//Trường hợp truyền tham trị mà không bị thay đổi giá trị thì làm như thế nào
using System;
using System.Text;

namespace Tuan2Bai5 {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding=Encoding.UTF8;

            //Kiểu dữ liệu tham chiếu 
            int _MyId = 20206205;
            //Kiểu dữ liệu tham trị
            var _RefValue = _MyId;
            Console.WriteLine($"Kiểu dữ liệu tham chiếu: {_MyId}");
            Console.WriteLine($"Kiểu dữ liệu tham trị: {_RefValue}");
            //Chuyển đổi kiểu dữ liệu tham chiếu sang tham trị 
            _RefValue=_MyId+20000000;
            Console.WriteLine($"Chuyển đổi kiểu dữ liệu tham chiếu sang tham trị: {_RefValue}");
            //Chuyển đổi kiểu dữ liệu tham trị sang tham chiếu 
            int number = 10;
            Console.WriteLine("Kiểu dữ liệu tham trị: "+number);
            ConvertToReference(number);
            Console.WriteLine("Chuyển đổi kiểu dữ liệu tham trị sang tham chiếu: "+number);
            //Trường hợp truyền tham số tham trị mà lại thay đổi giá trị
            ChangeValue(ref _MyId);
            Console.WriteLine($"Chuyển đổi kiểu dữ liệu tham trị sang tham chiếu: {_MyId}");
            //Trường hợp truyền tham trị mà không bị thay đổi giá trị 
            KeepValue(_MyId);
            Console.WriteLine($"Trường hợp truyền tham trị mà không bị thay đổi giá trị: {_MyId}");

        }
        static void ConvertToReference(int value) {
            object objValue = value;
            Console.WriteLine("Kiểu dữ liệu tham chiếu: "+objValue);
        }
        static void ChangeValue(ref int iValue) {
            iValue=iValue+10000000;
        }

        static void KeepValue(int iValue) {
        }
    }
}