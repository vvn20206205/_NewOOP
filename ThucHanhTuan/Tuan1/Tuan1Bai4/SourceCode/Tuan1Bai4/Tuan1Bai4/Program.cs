using System;
using System.Text;

namespace Tuan1Bai4 {
    internal class Program {
        static void Main(string[] args) {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Chương trình giải phương trình bậc hai");
            Console.WriteLine("ax^2 + bx + c = 0");
            float _inputQuadraticFactor2, _inputQuadraticFactor1, _inputQuadraticFactor0;


            Console.Write("Nhập hệ số a = ");
            _inputQuadraticFactor2=float.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số b = ");
            _inputQuadraticFactor1=float.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số c = ");
            _inputQuadraticFactor0=float.Parse(Console.ReadLine());

            QuadraticEquation _QuadraticEquation = new QuadraticEquation(_inputQuadraticFactor2,_inputQuadraticFactor1,_inputQuadraticFactor0);
            Console.WriteLine(_QuadraticEquation.SolveQuadraticEquation());

            Console.WriteLine("\nNhấn phím bất kì!");
            Console.ReadKey();
        }

    }
}