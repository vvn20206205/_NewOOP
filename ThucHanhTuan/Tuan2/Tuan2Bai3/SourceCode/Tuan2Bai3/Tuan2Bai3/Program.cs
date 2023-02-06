using System;
using System.Collections.Generic;
using System.Text;
namespace Tuan2Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
               
          
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
          
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
    
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
           }
        public static void Menu()
        {
            int luachon;
            do
            {
                Console.WriteLine("Chương trình giải phương trình.");
                Console.WriteLine("1. Giải phương trình bậc 1.");
                Console.WriteLine("2. Giải phương trình bậc 2.");
                Console.WriteLine("0. Thoát chương trình.");
                do
                {
                    Console.Write("Mời bạn nhập lựa chọn từ 0 đến 2: ");
                    luachon = Convert.ToInt32(Console.ReadLine());
                } while (0 > luachon || luachon > 2);
                switch (luachon)
                {
                    case 1:
                        Console.Clear();
                        PhuongTrinhBac1 PT1 = new PhuongTrinhBac1();
                        PT1.NhapPhuongTrinh();
                        PT1.XuatPhuongTrinh();
                        PT1.GiaiPhuongTrinh();
                      
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        PhuongTrinhBac2 PT2 = new PhuongTrinhBac2();
                        PT2.NhapPhuongTrinh();
                        PT2.XuatPhuongTrinh();
                        PT2.GiaiPhuongTrinh();
                      
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
                        break;
                }
            } while (luachon != 0);
            Console.WriteLine("Bạn đã thoát chương trình!");
        }
    }
}