using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
class Session8 {
    static void Main(string[] args) {
        Console.OutputEncoding=Encoding.Unicode;
        Console.InputEncoding=Encoding.Unicode;
        Console.Write("Number of messages: ");
        int numOfMess = int.Parse(Console.ReadLine());
        Thread[] arrThread = new Thread[numOfMess];
        for(int i = 0;i<numOfMess;i++) {
            Console.Write("Message {0}: ",i+1);
            string mess = Console.ReadLine();
            Console.Write("Timeout: ");
            int TimeOut = int.Parse(Console.ReadLine());
            Console.Write("Priority: ");
            string Priority = Console.ReadLine();
            arrThread[i]=new Thread(() => {
                NewThread(mess,TimeOut,Priority);
            });
        }
        Console.WriteLine("Result: ");
        foreach(var thread in arrThread) {
            thread.Start();
        }
    }

    static void NewThread(string Mess,int TimeOut,string Priority) {
        while(true) {
            Thread.Sleep(TimeSpan.FromSeconds(TimeOut/1000));
            Console.WriteLine(Mess);
        }
    }
}