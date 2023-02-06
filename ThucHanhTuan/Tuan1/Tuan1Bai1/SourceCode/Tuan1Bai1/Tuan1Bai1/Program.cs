//Thực hành tuần 1
//THIẾT LẬP MÔI TRƯỜNG LÀM VIỆC
//1. 👉 Cài đặt Visual studio.Net
//2. 👉 Viết chương trình hello world
//3. 👉 Viết chương trình tính tổng từ 1-100
//4. 👉 Viết chương trình giải phương trình bậc hai
//5. 👉 Trình bày ý nghĩa của từng môn học trong chương trình đào tào và sự liên kết của nó
using System;
using System.Text;
namespace Tuan1Bai1 {
    internal class Program {
        #region Methods
        static void Main(string[] args) {
            try {
                Console.OutputEncoding=Encoding.UTF8;
                Console.Title="Vũ Văn Nghĩa 20206205";
                Console.WriteLine("Hello World!");
                Console.WriteLine("\nPress any key!");
                Console.ReadKey();
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPress any key!");
                Console.ReadKey();
            }
        }
        #endregion
    }
}