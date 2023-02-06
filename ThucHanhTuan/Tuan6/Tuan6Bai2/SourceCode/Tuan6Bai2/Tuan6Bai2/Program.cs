
// Vũ Văn Nghĩa 20206205
using System;
using System.Text;
namespace Tuan6Bai2 {
    internal class Program {
        static void Main(string[] args) {
        
            try {
               
              Console.OutputEncoding=Encoding.UTF8;
            Console.Title="Vũ Văn Nghĩa 20206205";
            // Gọi phương thức đó trên một mảng kiểu double.
            double[] MyArray = { 1.5,2.5,3.5,4.5 };

            Console.Write("Các phần tử của MyArray là:");
            foreach(var i in MyArray) {
                Console.Write($" {i};");
            }

            // Nhập  
            double _test;
            bool kt;
            do {
                Console.Write($"\n\tNhập phần tử cần kiểm tra: ");
                string _input =Console.ReadLine();
                kt=double.TryParse(_input,out _test);
            } while(!kt);

            Console.WriteLine($"Tổng số phần tử của MyArray lớn hơn hoặc bằng {_test} là: {GreaterCount(MyArray,_test)}");

            Console.WriteLine("You have exited the program!");
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
   
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
            }
        // trả về số lượng phân tử của một enumerable mà lớn hơn hoặc bằng min.
        public static int GreaterCount(IEnumerable<double> eble,double min) {
            int countEqualOrGreaterThan_min = 0;
            foreach(var i in eble) {
                if(i>=min) {
                    countEqualOrGreaterThan_min+=1;
                }
            }
            return countEqualOrGreaterThan_min;
        }
    }
}