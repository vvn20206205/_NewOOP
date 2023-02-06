//Có Enum là các loại hình 
using System;
using System.Text;
namespace Tuan2Bai4 {


    internal class Program {

        static void Main(string[] args) {
            Console.OutputEncoding=Encoding.UTF8;

            // Hình tròn 
            CHinhTron _hinhtron = new CHinhTron(5);
            InThongTin(_hinhtron);
            // Hình chữ nhật
            CHinhChuNhat _hinhchunhat = new CHinhChuNhat(4,5);
            InThongTin(_hinhchunhat);
            // Hình thang
            CHinhThang _hinhthang = new CHinhThang(6,5,12,5);
            InThongTin(_hinhthang);
            // Hình tam giác
            CHinhTamGiac _hinhtamgiac = new CHinhTamGiac(3,4,5);
            InThongTin(_hinhtamgiac);

            Console.WriteLine("Press any key!");
            Console.ReadKey();
        }

        static void InThongTin(CHinh iHinh) {
            foreach(var _item in iHinh.Display()) {

                Console.WriteLine(_item);
            }
        }
    }
}