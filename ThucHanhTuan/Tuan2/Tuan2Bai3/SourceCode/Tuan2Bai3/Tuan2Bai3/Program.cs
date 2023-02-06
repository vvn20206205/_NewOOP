using System;
using System.Collections.Generic;
using System.Text;
namespace Tuan2Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Menu();
            Console.WriteLine("\nNhấn phím bất kì để kết thúc chương trình!");
            Console.ReadKey();
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
                        Console.WriteLine("\nNhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        PhuongTrinhBac2 PT2 = new PhuongTrinhBac2();
                        PT2.NhapPhuongTrinh();
                        PT2.XuatPhuongTrinh();
                        PT2.GiaiPhuongTrinh();
                        Console.WriteLine("\nNhấn phím bất kì để tiếp tục!");
                        Console.ReadKey();
                        break;
                }
            } while (luachon != 0);
            Console.WriteLine("Bạn đã thoát chương trình!");
        }
    }
}