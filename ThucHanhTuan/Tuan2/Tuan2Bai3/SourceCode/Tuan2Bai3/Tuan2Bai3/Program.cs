using System;
using System.Collections.Generic;
using System.Text;
namespace Tuan2Bai3 {
    internal class Program {
        static void Main(string[] args) {
            try {
                Console.OutputEncoding=Encoding.UTF8;
                Menu();

                Console.WriteLine("\nPress any key!");
                Console.ReadKey();

            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPress any key!");
                Console.ReadKey();
            }

        }
        public static void Menu() {
            int _choose;
            do {
                Console.WriteLine("Chương trình giải phương trình.");
                Console.WriteLine("1. Giải phương trình bậc 1.");
                Console.WriteLine("2. Giải phương trình bậc 2.");
                Console.WriteLine("0. Thoát chương trình.");
                do {
                    Console.Write("Mời bạn nhập lựa chọn từ 0 đến 2: ");
                    _choose=Convert.ToInt32(Console.ReadLine());
                } while(0>_choose||_choose>2);
                switch(_choose) {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Chương trình giải PT bậc 1.");
                        Console.WriteLine("Phương trình bậc 1 có dạng bx +c = 0");
                        Console.WriteLine("Nhập hệ số b,c:");
                        Console.Write("Nhập hệ số b (VD: 3+5i): ");
                        Complex _inputQuadraticFactor1 = new Complex();
                        _inputQuadraticFactor1.SetInputComplex();
                        _inputQuadraticFactor1.XuatSoPhuc();
                        Console.Write("Nhập hệ số c (VD: 3+5i): ");
                        Complex _inputQuadraticFactor0 = new Complex();
                        _inputQuadraticFactor0.SetInputComplex();
                        _inputQuadraticFactor0.XuatSoPhuc();
                        FirstDegreeEquation _Equation1 = new FirstDegreeEquation(_inputQuadraticFactor1,_inputQuadraticFactor0);

                        Console.WriteLine(_Equation1.Display());
                        Console.WriteLine(_Equation1.SolveQuadraticEquation());



                        Console.WriteLine("\nPress any key!");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Chương trình giải PT bậc 2.");
                        Console.WriteLine("Phương trình bậc hai có dạng ax^2 + bx +c = 0");
                        Console.WriteLine("Nhập hệ số a,b,c:");
                        Console.Write("Nhập hệ số a (VD: 3+5i): ");
                        Complex _inputQuadraticFactor2 = new Complex();
                        _inputQuadraticFactor2.SetInputComplex();
                        _inputQuadraticFactor2.XuatSoPhuc();
                        Console.Write("Nhập hệ số b (VD: 3+5i): ");
                        _inputQuadraticFactor1=new Complex();
                        _inputQuadraticFactor1.SetInputComplex();
                        _inputQuadraticFactor1.XuatSoPhuc();
                        Console.Write("Nhập hệ số c (VD: 3+5i): ");
                        _inputQuadraticFactor0=new Complex();
                        _inputQuadraticFactor0.SetInputComplex();
                        _inputQuadraticFactor0.XuatSoPhuc();
                        QuadraticEquation _Equation2 = new QuadraticEquation(_inputQuadraticFactor2,_inputQuadraticFactor1,_inputQuadraticFactor0);

                        Console.WriteLine(_Equation2.Display());
                        Console.WriteLine(_Equation2.SolveQuadraticEquation());
                        Console.WriteLine("\nPress any key!");
                        Console.ReadKey();
                        break;
                }
            } while(_choose!=0);
            Console.WriteLine("Bạn đã thoát chương trình!");
        }
    }
}