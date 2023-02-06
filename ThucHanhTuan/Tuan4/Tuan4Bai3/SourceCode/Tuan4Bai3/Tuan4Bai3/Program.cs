using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
namespace Tuan4Bai3
{

    internal class Program
    {
        static void Main(string[] args)
        {
         
            try {
               
             Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Viết một chương trình _Test để kiểm tra tất cả các hành vi (phương thức, toán tử) của lớp này.\n");
            Console.Write("(Default constructor) _Test0 là: ");
            MultidimensionalSpace _Test0 = new MultidimensionalSpace();
            Console.WriteLine(_Test0.ToString());

            Console.Write("(Constructor int SoChieu) Tọa độ _Test1 5 chiều là: ");
            MultidimensionalSpace _Test1 = new MultidimensionalSpace(5);
            Console.WriteLine(_Test1.ToString());

            List<double> _ArrayExample = new List<double>() { 1,2,3,4,5}; 
            MultidimensionalSpace _Test2 = new MultidimensionalSpace(_ArrayExample);
            Console.Write("(Constructor List tọa độ) Tọa độ _Test2 là: ");
            Console.WriteLine(_Test2.ToString());


            Console.WriteLine("Điểm _Test2 có khoảng cách với gốc tọa độ là: " + _Test2.OriginDistanceO());
            Console.WriteLine("Điểm _Test2 có điểm đối xứng qua gốc tọa độ là: " + _Test2.PointSymmetryOriginDistanceO());

            Console.WriteLine("\nCác toán tử:  cộng, trừ, nhân: ");
            Console.WriteLine(" _Test2 + _Test1 =  " + (_Test2 + _Test1).ToString());
            Console.WriteLine(" _Test2 - _Test1 = " + (_Test2 - _Test1).ToString());
            Console.WriteLine(" _Test2 * _Test1 = " + (_Test2 * _Test1).ToString());


            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
       
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
        }
    }
}