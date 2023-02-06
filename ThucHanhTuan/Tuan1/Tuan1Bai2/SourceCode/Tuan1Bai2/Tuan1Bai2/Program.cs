using System;
using System.Text;
namespace Tuan1Bai2 {
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