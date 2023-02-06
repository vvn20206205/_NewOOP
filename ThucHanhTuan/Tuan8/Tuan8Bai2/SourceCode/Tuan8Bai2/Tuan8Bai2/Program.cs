using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
class Session8 {
    static void Main(string[] args) {
       
            try {
               
           Console.OutputEncoding=Encoding.Unicode;
        Console.InputEncoding=Encoding.Unicode;
        Thread t = new Thread(() => { NewThread("First"); });
        Thread t2 = new Thread(() => { NewThread("Second"); });
        Thread t3 = new Thread(() => { NewThread("Third"); });
        t.Start();
        t2.Start();
        t3.Start();
        while(true) {
            if(!t.IsAlive&&!t2.IsAlive&&!t3.IsAlive) {
                Console.WriteLine("Main thread exiting");
                break;
            }
        }   Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            } catch(Exception ex) {
                   Console.WriteLine(ex.Message);
            Console.WriteLine("\nPress any key!");
            Console.ReadKey();
            }
      
       
    }
    static void NewThread(string threadIndex) {
        Console.WriteLine("New thread  : Thread[{0}, 5, main]",threadIndex);
        for(int i = 1;i<6;i++) {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            int n = 6-i;
            Console.WriteLine(threadIndex+" : "+n);
            if(n==1) {
                Console.WriteLine(threadIndex+"exiting");
            }
        }
    }
}