using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Tuan4Bai2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Viết một chương trình Test để kiểm tra tất cả các hành vi (phương thức, toán tử) của lớp này.\n");
            Console.Write("Gốc tọa độ là: ");
            POINT test0 = new POINT();
            Console.WriteLine(test0.ToString());

            POINT test1 = new POINT(1,1);
            Console.Write("\nĐiểm test1 có tọa độ: ");
            Console.WriteLine(test1.ToString());

            Console.WriteLine("Điểm test1 có khoảng cách với gốc tọa độ là: "+test1.KhoangCachGocToaDo());
            Console.WriteLine("Điểm test1 có điểm đối xứng qua trục tung là: "+test1.DiemDoiXungTrucTung());
            Console.WriteLine("Điểm test1 có điểm đối xứng qua trục hoành là: "+test1.DiemDoiXungTrucHoanh());
            Console.WriteLine("Điểm test1 có điểm đối xứng qua gốc tọa độ là: " + test1.DiemDoiXungToaDo());
           
            Console.WriteLine("\nCác toán tử:  cộng, trừ, nhân: "  );
            Console.WriteLine(" test1 + test0 =  "+ (test1 + test0).ToString());
            Console.WriteLine(" test1 - test0 = "+( test1 - test0 ).ToString());
            Console.WriteLine(" test1 * test0 = "+( test1 * test0 ).ToString());


            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
        }
    }
} 