using System;
using System.Threading;
namespace Bai1 {
    internal class Bai1 {
            public static void Countdown() {
            for(int i = 10;i>0;i--) {
                Console.Write(i.ToString()+" ");
            }
        }
        public static void Main() {
            Thread t2 = new Thread(new ThreadStart(Countdown));
            t2.Start();
        }
    }
}