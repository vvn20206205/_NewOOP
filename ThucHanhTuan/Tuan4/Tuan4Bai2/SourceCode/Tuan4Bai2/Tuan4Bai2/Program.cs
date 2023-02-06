using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Tuan4Bai2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            try {
               
          
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Viết một chương trình Test để kiểm tra tất cả các hành vi (phương thức, toán tử) của lớp này.\n");
            Console.Write("Gốc tọa độ là: ");
            Point _Test0 = new Point();
            Console.WriteLine(_Test0.ToString());

            Point _Test1 = new Point(1,1);
            Console.Write("\nĐiểm _Test1 có tọa độ: ");
            Console.WriteLine(_Test1.ToString());

            Console.WriteLine("Điểm _Test1 có khoảng cách với gốc tọa độ là: "+_Test1.OriginDistanceO());
            Console.WriteLine("Điểm _Test1 có điểm đối xứng qua trục tung là: "+_Test1.PointSymmetryVerticalAxis());
            Console.WriteLine("Điểm _Test1 có điểm đối xứng qua trục hoành là: "+_Test1.PointSymmetryHorizontalAxis());
            Console.WriteLine("Điểm _Test1 có điểm đối xứng qua gốc tọa độ là: " + _Test1.PointSymmetryOriginDistanceO());
           
            Console.WriteLine("\nCác toán tử:  cộng, trừ, nhân: "  );
            Console.WriteLine(" _Test1 + _Test0 =  "+ (_Test1 + _Test0).ToString());
            Console.WriteLine(" _Test1 - _Test0 = "+( _Test1 - _Test0 ).ToString());
            Console.WriteLine(" _Test1 * _Test0 = "+( _Test1 * _Test0 ).ToString());


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