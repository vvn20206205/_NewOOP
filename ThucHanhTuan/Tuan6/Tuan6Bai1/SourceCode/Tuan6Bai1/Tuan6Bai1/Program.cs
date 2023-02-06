
// Vũ Văn Nghĩa 20206205
using System;
using System.Text;
namespace Tuan6Bai1 {
    internal class Program {
        static void Main(string[] args) {
         
            try {
               
             Console.OutputEncoding=Encoding.UTF8;
            Console.Title="Vũ Văn Nghĩa 20206205";

            List<double> Temperatures = new List<double>();

            for(int i = 20;i<30;i++) {
                Temperatures.Add(i+0.5);
            }

            Console.Write("Các phần tử của Temperatures là:");
            foreach(var i in Temperatures) {
                Console.Write($" {i} độ;");
            }
            Console.WriteLine();

            // Viết vòng lệnh lặp foreach để đếm số lượng temperature mà bằng hoặc lớn hơn 25 độ.
            int countEqualOrGreaterThan_25 = 0;
            double temperature_25 = 25;
            foreach(var i in Temperatures) {
                if(i>=temperature_25) {
                    countEqualOrGreaterThan_25+=1;
                }
            }
            Console.WriteLine($"Tổng số phần tử của Temperatures lớn hơn hoặc bằng 25 độ là: {countEqualOrGreaterThan_25}");

            // Nhập  
            double _test;
            bool kt;
            string _input;
            do {
                Console.Write($"Nhập nhiệt độ cần kiểm tra: ");
                _input=Console.ReadLine();
                kt=double.TryParse(_input,out _test);
            } while(!kt);

            Console.WriteLine($"Tổng số phần tử của Temperatures lớn hơn hoặc bằng {_test} độ là: {GreaterCount(Temperatures,_test)}");


            Console.WriteLine("You have exited the program!");
             Console.WriteLine("\nPress any key!");
            Console.ReadKey();
     
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
          }
        // số lượng phần tử của danh sách mà lớn hơn hoặc bằng min.
        public static int GreaterCount(List<double> _iList,double min) {
            int countEqualOrGreaterThan_min = 0;
            foreach(var i in _iList) {
                if(i>=min) {
                    countEqualOrGreaterThan_min+=1;
                }
            }
            return countEqualOrGreaterThan_min;
        }
    }
}