using System;
using System.Threading;
namespace Bai8 {
    internal class Bai8 {
        public static void Main(string[] args) {
            CalcNet.CalcClass c = new CalcNet.CalClass();
            Console.WriteLine("Please enter a number: ");
            short num1 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            short num2 = Convert.ToUInt16(Console.ReadLine());
            int res = c.Add(num1,num2);
            Console.WriteLine("The sum of the two numbers is {0}",res);
            res=c.Subtract(num1,num2);
            Console.WriteLine("The difference between the two numbers is {0}",res);
            Console.ReadLine();
        }
    }
}
